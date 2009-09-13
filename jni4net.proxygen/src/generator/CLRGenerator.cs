﻿#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of tools for jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System.CodeDom;
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
            tgtType.TypeAttributes = TypeAttributes.NotPublic | TypeAttributes.Sealed;
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

        protected CodeStatementCollection CreateMethodSignature(CodeTypeDeclaration tgtType, GMethod method,
                                                                bool isProxy)
        {
            bool add = true;
            CodeStatementCollection tgtStatements;
            CodeTypeMember tgtMember;
            CodeMemberMethod tgtMethod = null;
            CodeMemberPropertyEx tgtProperty = null;
            if (method.IsConstructor)
            {
                var tgtConstructor = new CodeConstructor();
                tgtMethod = tgtConstructor;
                tgtMember = tgtMethod;
                tgtStatements = tgtMethod.Statements;
                if (!type.IsRootType)
                {
                    tgtConstructor.BaseConstructorArgs.Add(
                        new CodeCastExpression(TypeReference("net.sf.jni4net.jni.JNIEnv"),
                                               new CodePrimitiveExpression(null)));
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
                Utils.AddAttribute(tgtMember, "net.sf.jni4net.attributes.JavaMethodAttribute", method.JVMSignature);
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
            createMethod.Parameters.Add(new CodeParameterDeclarationExpression(TypeReference(typeof (JNIEnv)),
                                                                               envVariableName));
            createMethod.Statements.Add(
                new CodeMethodReturnStatement(new CodeObjectCreateExpression(CurrentType,
                                                                             envVariable)));
            createMethod.Name = "CreateProxy";
            createMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            constructionHelper.Members.Add(createMethod);
            constructionHelper.TypeAttributes = TypeAttributes.NotPublic | TypeAttributes.Sealed;
            tgtType.Members.Add(constructionHelper);
        }

        private CodeMethodInvokeExpression CreateConversionExpressionJ2C(GType paramType, CodeExpression invokeExpression)
        {
            return CEEJ2C(paramType, invokeExpression, false);
        }

        private CodeMethodInvokeExpression CreateConversionExpressionJ2CParam(GType paramType, CodeExpression invokeExpression)
        {
            return CEEJ2C(paramType, invokeExpression, true);
        }

        private CodeMethodInvokeExpression CEEJ2C(GType paramType, CodeExpression invokeExpression, bool param)
        {
            CodeTypeReference[] par;
            if (paramType.IsArray)
            {
                GType element = paramType.ArrayElement;
                if (element.IsPrimitive)
                {
                    par = new CodeTypeReference[] {};
                    return CCE("ArrayPrimJ2C" + element.Name, par, invokeExpression, true);
                }
                if (element == Repository.javaLangString)
                {
                    par = new CodeTypeReference[] {};
                    return CCE("ArrayStrongJ2CpString", par, invokeExpression, true);
                }
                if (element == Repository.systemString)
                {
                    par = new CodeTypeReference[] { };
                    return CCE("ArrayStrongJ2CString", par, invokeExpression, true);
                }
                if (element == Repository.javaLangClass)
                {
                    par = new CodeTypeReference[] {};
                    return CCE("ArrayStrongJ2CpClass", par, invokeExpression, true);
                }
                if (!element.IsInterface && !element.IsCLRRootType && element.IsCLRRealType)
                {
                    par = new[] {paramType.CLRReference, paramType.ArrayElement.CLRReference};
                    return CCE("ArrayStrongJp2C", par, invokeExpression, true);
                }
                if (!element.IsInterface && !element.IsJVMRootType && element.IsJVMRealType)
                {
                    par = new[] {paramType.CLRReference, paramType.ArrayElement.CLRReference};
                    return CCE("ArrayStrongJ2Cp", par, invokeExpression, true);
                }
                par = new[] {paramType.CLRReference, paramType.ArrayElement.CLRReference};
                return CCE("ArrayFullJ2C", par, invokeExpression, true);
            }
            if (paramType.IsPrimitive)
            {
                par = new CodeTypeReference[] {};
                return CCE("PrimJ2C" + paramType.Name, par, invokeExpression, false);
            }
            if (paramType == Repository.javaLangString)
            {
                par = new CodeTypeReference[] {};
                return CCE("StrongJ2CpString", par, invokeExpression, true);
            }
            if (paramType == Repository.systemString)
            {
                par = new CodeTypeReference[] { };
                return CCE("StrongJ2CString", par, invokeExpression, true);
            }
            if (paramType == Repository.javaLangClass)
            {
                par = new CodeTypeReference[] {};
                return CCE("StrongJ2CpClass", par, invokeExpression, true);
            }
            if (!paramType.IsInterface && !paramType.IsCLRRootType && paramType.IsCLRRealType)
            {
                par = new[] {paramType.CLRReference};
                return CCE("StrongJp2C", par, invokeExpression, true);
            }
            if (!paramType.IsInterface && !paramType.IsJVMRootType && paramType.IsJVMRealType)
            {
                par = new[] {paramType.CLRReference};
                return CCE("StrongJ2Cp", par, invokeExpression, true);
            }
            par = new[] {paramType.CLRReference};
            return CCE("FullJ2C", par, invokeExpression, true);
        }

        private CodeMethodInvokeExpression CreateConversionExpressionC2J(GType paramType,
                                                                         CodeExpression invokeExpression)
        {
            return CEEC2J("", paramType, invokeExpression);
        }

        private CodeMethodInvokeExpression CreateConversionExpressionC2JParam(GType paramType,
                                                                              CodeExpression invokeExpression)
        {
            return CEEC2J("Par", paramType, invokeExpression);
        }

        private CodeMethodInvokeExpression CEEC2J(string prefix, GType paramType, CodeExpression invokeExpression)
        {
            CodeTypeReference[] par;
            if (paramType.IsArray)
            {
                GType element = paramType.ArrayElement;
                if (element.IsPrimitive)
                {
                    par = new CodeTypeReference[] {};
                    return CCE(prefix + "ArrayPrimC2J", par, invokeExpression, true);
                }
                if (element == Repository.systemString)
                {
                    par = new CodeTypeReference[] {};
                    return CCE(prefix + "ArrayStrongC2JString", par, invokeExpression, true);
                }
                if (!element.IsInterface && !element.IsCLRRootType && element.IsCLRRealType)
                {
                    par = new[] {paramType.CLRReference, paramType.ArrayElement.CLRReference};
                    return CCE(prefix + "ArrayStrongC2Jp", par, invokeExpression, true);
                }
                if (!element.IsInterface && !element.IsJVMRootType && element.IsJVMRealType)
                {
                    par = new CodeTypeReference[] {};
                    return CCE(prefix + "ArrayStrongCp2J", par, invokeExpression, true);
                }
                par = new[] {paramType.CLRReference, paramType.ArrayElement.CLRReference};
                return CCE(prefix + "ArrayFullC2J", par, invokeExpression, true);
            }
            if (paramType.IsPrimitive)
            {
                par = new CodeTypeReference[] {};
                return CCE(prefix + "PrimC2J", par, invokeExpression, false);
            }
            if (paramType == Repository.javaLangString ||
                paramType == Repository.javaLangClass)
            {
                par = new CodeTypeReference[] {};
                return CCE(prefix + "StrongCp2J", par, invokeExpression, false);
            }
            if (paramType == Repository.systemString)
            {
                par = new CodeTypeReference[] {};
                return CCE(prefix + "StrongC2JString", par, invokeExpression, true);
            }
            if (!paramType.IsInterface && !paramType.IsCLRRootType && paramType.IsCLRRealType)
            {
                par = new[] {paramType.CLRReference};
                return CCE(prefix + "StrongC2Jp", par, invokeExpression, true);
            }
            if (!paramType.IsInterface && !paramType.IsJVMRootType && paramType.IsJVMRealType)
            {
                par = new CodeTypeReference[] {};
                return CCE(prefix + "StrongCp2J", par, invokeExpression, false);
            }
            par = new[] {paramType.CLRReference};
            return CCE(prefix + "FullC2J", par, invokeExpression, true);
        }

        private CodeMethodInvokeExpression CCE(string conversion, CodeTypeReference[] parameters,
                                               CodeExpression invokeExpression, bool env)
        {
            if (env)
            {
                return new CodeMethodInvokeExpression(
                    new CodeMethodReferenceExpression(TypeReferenceEx(typeof (Convertor)),
                                                      conversion, parameters),
                    envVariable, invokeExpression);
            }
            else
            {
                return new CodeMethodInvokeExpression(
                    new CodeMethodReferenceExpression(TypeReferenceEx(typeof (Convertor)),
                                                      conversion, parameters),
                    invokeExpression);
            }
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