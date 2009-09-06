﻿using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using java.lang;
using Microsoft.CSharp;
using net.sf.jni4net.jni;
using net.sf.jni4net.proxygen.model;
using net.sf.jni4net.utils;
using StringBuilder=System.Text.StringBuilder;

namespace net.sf.jni4net.proxygen.generator
{
    internal abstract partial class CLRGenerator : Generator
    {
        protected const string cdc = "Component Designer generated code ";
        protected CodeStatementCollection InitStatements;

        protected CLRGenerator(GType type)
            : base(type)
        {
        }

        protected override void Generate()
        {
            string package = type.CLRNamespace.Replace('.', '/').ToLower();
            string dirCs = Path.Combine(config.TargetDirClr, package);
            if (!Directory.Exists(dirCs))
            {
                Directory.CreateDirectory(dirCs);
            }

            string csFile = GetFileName(dirCs);

            string newFile = GenerateNamespace();
            if (newFile == null)
            {
                // no type to store
                return;
            }

            //Console.WriteLine(newFile);

            // replace with new text
            using (var sw = new StreamWriter(csFile))
            {
                sw.Write(newFile);
            }
        }

        /// <summary>
        /// Compile unit
        /// </summary>
        private string GenerateNamespace()
        {
            var sb = new StringBuilder();
            var buffer = new StringWriter(sb);

            var cscProvider = new CSharpCodeProvider();
            var cop = new CodeGeneratorOptions();
            var unit = new CodeCompileUnit();
            var nameSpace = new CodeNamespace(type.CLRNamespace);

            Generate(nameSpace);
            if (nameSpace.Types.Count == 0)
            {
                // no type to store
                return null;
            }

            unit.Namespaces.Add(nameSpace);
            cscProvider.GenerateCodeFromCompileUnit(unit, buffer, cop);
            buffer.Close();

            sb.Replace("This code was generated by a tool.",
                       "This code was generated by jni4net. See http://jni4net.sourceforge.net/ ");

            //unsafe
            //sb.Replace("internal partial class @__", "internal unsafe partial class @__");
            //sb.Replace("public partial class", "public unsafe partial class");
            //sb.Replace("internal sealed partial class @__", "internal sealed unsafe partial class @__");

            return sb.ToString();
        }

        protected virtual string GetFileName(string dirCs)
        {
            return Path.Combine(dirCs, type.Name + ".generated.cs");
        }

        /// <summary>
        /// Create static type info for interface
        /// </summary>
        protected void GenerateStatic(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration(type.Name + "_");
            SetCurrentType(type.CLRNamespace + "." + type.Name + "_", type.CLRNamespace + "." + type.Name,
                           type.CLRNamespace + ".__" + type.Name);
            tgtType.IsPartial = true;
            nameSpace.Types.Add(tgtType);

            GenerateStaticFields(tgtType);

            int m = 0;
            foreach (GMethod method in type.MethodsWithInterfaces)
            {
                string uName = ("_" + method.CLRName + m);
                if (method.IsField && method.IsStatic)
                {
                    CreateMethodC2J(method, tgtType, uName, false);
                }
                m++;
            }
            //todo static constructor ?

            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));
        }

        /// <summary>
        /// Create proxy for interface
        /// </summary>
        protected void GenerateProxy(CodeNamespace nameSpace)
        {
            var tgtType = new CodeTypeDeclaration("__" + type.Name);
            SetCurrentType(type.CLRNamespace + ".__" + type.Name
                           , type.CLRNamespace + "." + type.Name, type.CLRNamespace + ".__" + type.Name);
            nameSpace.Types.Add(tgtType);
            tgtType.TypeAttributes = TypeAttributes.NotPublic|TypeAttributes.Sealed;
            Utils.AddAttribute(tgtType, "net.sf.jni4net.attributes.JavaProxyAttribute", type.CLRReference);
            tgtType.BaseTypes.Add(Repository.javaLangObject.CLRReference);
            if (type.IsInterface)
            {
                tgtType.BaseTypes.Add(type.CLRReference);
            }
            tgtType.IsPartial = true;

            GenerateTypeOfInit(tgtType);
            GenerateWrapperInitJ2C();
            if (type.Registration == null || !type.Registration.NoMethods)
            {
                if (type.IsInterface)
                {
                    GenerateProxyMethodsC2J(tgtType);
                }
                GenerateWrapperMethodsJ2C(tgtType);
            }
            GenerateConstructionHelper(tgtType);
            CreateEnvConstructor(tgtType, "net.sf.jni4net.jni.JNIEnv", false, false);

            tgtType.StartDirectives.Add(new CodeRegionDirective(CodeRegionMode.Start, cdc));
            tgtType.EndDirectives.Add(new CodeRegionDirective(CodeRegionMode.End, cdc));
        }


        private void GenerateProxyMethodsC2J(CodeTypeDeclaration tgtType)
        {
            int m = 0;
            foreach (GMethod method in type.MethodsWithInterfaces)
            {
                string uName = ("_" + method.CLRName + m);
                CreateMethodC2J(method, tgtType, uName, true);
                m++;
            }
            foreach (GMethod method in type.Constructors)
            {
                string uName = ("_" + method.CLRName + m);
                CreateMethodC2J(method, tgtType, uName, false);
                m++;
            }
        }

        protected CodeStatementCollection CreateMethodSignature(CodeTypeDeclaration tgtType, GMethod method, bool isProxy)
        {
            bool add = true;
            CodeStatementCollection tgtStatements;
            CodeTypeMember tgtMember;
            CodeMemberMethod tgtMethod = null;
            CodeMemberPropertyEx tgtProperty = null;
            if (method.IsConstructor)
            {
                CodeConstructor tgtConstructor = new CodeConstructor();
                tgtMethod = tgtConstructor;
                tgtMember = tgtMethod;
                tgtStatements = tgtMethod.Statements;
                if (!type.IsRootType)
                {
                    tgtConstructor.BaseConstructorArgs.Add(
                        new CodeCastExpression(TypeReference("net.sf.jni4net.jni.JNIEnv"), new CodePrimitiveExpression(null)));
                }

            }
            else if (method.IsField)
            {
                var p = new CodeMemberProperty();
                tgtMember = p;
                tgtStatements = p.GetStatements;
                p.Name = method.CLRName;
                p.Type = method.ReturnType.CLRReference;
            }
            else if (method.IsProperty)
            {
                tgtProperty = new CodeMemberPropertyEx();
                tgtProperty.Setter = method.CLRPropertySetter;
                tgtProperty.Getter = method.CLRPropertyGetter;
                tgtProperty.Name = method.CLRName;
                if (method.UseExplicitInterface)
                {
                    tgtProperty.PrivateImplementationType = method.DeclaringType.CLRReference;
                }

                foreach (CodeTypeMember m in tgtType.Members)
                {
                    var member = m as CodeMemberPropertyEx;
                    if (member != null)
                        if (member.Getter == method || member.Setter == method)
                        {
                            tgtProperty = member;
                            add = false;
                            break;
                        }
                }
                if (add)
                {
                    int count = method.Parameters.Count;
                    if (method.IsCLRPropertySetter)
                    {
                        count--;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        var tgtParameter = new CodeParameterDeclarationExpression();
                        tgtParameter.Name = method.ParameterNames[i];
                        tgtParameter.Type = method.Parameters[i].CLRReference;
                        tgtProperty.Parameters.Add(tgtParameter);
                    }
                }

                tgtMember = tgtProperty;
                if (method.IsCLRPropertySetter)
                {
                    tgtStatements = tgtProperty.SetStatements;
                }
                else
                {
                    tgtProperty.Type = method.ReturnType.CLRReference;
                    tgtStatements = tgtProperty.GetStatements;
                }
            }
            else
            {
                tgtMethod = new CodeMemberMethod();
                tgtMethod.Name = method.CLRName;
                tgtMethod.ReturnType = method.ReturnType.CLRReference;
                tgtMember = tgtMethod;
                tgtStatements = tgtMethod.Statements;
                if (method.UseExplicitInterface)
                {
                    tgtMethod.PrivateImplementationType = method.DeclaringType.CLRReference;
                }
            }
            if (!config.SkipSignatures && !isProxy)
            {
                Utils.AddAttribute(tgtMember, "net.sf.jni4net.attributes.JavaMethodAttribute", method.CLRSignature);
            }
            tgtMember.Attributes = method.Attributes;
            if (isProxy)
            {
                tgtMember.Attributes |= MemberAttributes.Final;
            }
            if (tgtMethod != null)
            {
                GenerateParameters(method, tgtMethod);
            }
            if (add)
            {
                tgtType.Members.Add(tgtMember);
            }
            return tgtStatements;
        }

        protected void GenerateParameters(GMethod method, CodeMemberMethod tgtMethod)
        {
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                var tgtParameter = new CodeParameterDeclarationExpression();
                tgtParameter.Name = method.ParameterNames[i];
                tgtParameter.Type = method.Parameters[i].CLRReference;
                tgtMethod.Parameters.Add(tgtParameter);
            }
        }

        protected void GenerateStaticFields(CodeTypeDeclaration tgtType)
        {
            var claprop = new CodeMemberProperty();
            claprop.Type = Repository.javaLangClass.CLRReference;
            claprop.Name = "_class";
            claprop.GetStatements.Add(
                new CodeMethodReturnStatement(new CodeFieldReferenceExpression(ProxyTypeEx, "staticClass")));
            tgtType.Members.Add(claprop);
            claprop.Attributes = MemberAttributes.Static | MemberAttributes.Public | MemberAttributes.New;
        }

        protected void GenerateTypeOfInit(CodeTypeDeclaration tgtType)
        {
            var staticfield = new CodeMemberField(Repository.javaLangClass.CLRReference, "staticClass");
            staticfield.Attributes = MemberAttributes.Static | MemberAttributes.FamilyAndAssembly;
            tgtType.Members.Add(staticfield);

            var init = new CodeMemberMethod();
            init.Name = "InitJNI";
            init.Attributes |= MemberAttributes.Static;
            var jniEnv = new CodeTypeReference(typeof (JNIEnv), CodeTypeReferenceOptions.GlobalReference);
            var statClass = new CodeTypeReference(typeof (Class));
            init.Parameters.Add(new CodeParameterDeclarationExpression(jniEnv, envVariableName));
            init.Parameters.Add(new CodeParameterDeclarationExpression(statClass, classVariableName));
            init.Statements.Add(
                new CodeAssignStatement(
                    new CodeFieldReferenceExpression(
                        CurrentTypeEx, "staticClass"),
                    new CodeVariableReferenceExpression(classVariableName)));

            tgtType.Members.Add(init);

            InitStatements = init.Statements;
        }

        protected void GenerateConstructionHelper(CodeTypeDeclaration tgtType)
        {
            var constructionHelper = new CodeTypeDeclaration("ContructionHelper");
            constructionHelper.BaseTypes.Add(TypeReference(typeof (IConstructionHelper)));
            var createMethod = new CodeMemberMethod();
            createMethod.ReturnType = TypeReference(typeof (IJavaProxy));
            createMethod.Parameters.Add(new CodeParameterDeclarationExpression(TypeReference(typeof (JNIEnv)), envVariableName));
            createMethod.Statements.Add(
                new CodeMethodReturnStatement(new CodeObjectCreateExpression(CurrentType,
                                                                             envVariable)));
            createMethod.Name = "CreateProxy";
            createMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            constructionHelper.Members.Add(createMethod);
            constructionHelper.TypeAttributes = TypeAttributes.NotPublic | TypeAttributes.Sealed;
            tgtType.Members.Add(constructionHelper);
        }

        #region Nested type: CodeMemberPropertyEx

        private class CodeMemberPropertyEx : CodeMemberProperty
        {
            public GMethod Getter;
            public GMethod Setter;
        }

        #endregion
    }
}