//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Reflection {
    
    
    #region Component Designer generated code 
    public partial class MemberInfo_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Reflection.@__MemberInfo.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Reflection.MemberInfo))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Reflection.MemberInfo))]
    internal sealed partial class @__MemberInfo : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MemberInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Reflection.@__MemberInfo.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__MemberInfo);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes0", "(Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetCustomAttributes", "GetCustomAttributes1", "(Lsystem/Type;Z)[Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IsDefined", "IsDefined2", "(Lsystem/Type;Z)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMemberType", "MemberType3", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "Name4", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getDeclaringType", "DeclaringType5", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getReflectedType", "ReflectedType6", "()Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getMetadataToken", "MetadataToken7", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getModule", "Module8", "()Lsystem/runtime/serialization/ISerializable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetTypeInfo", "GetTypeInfo9", "(IILsystem/ValueType;)V"));
            return methods;
        }
        
        private static global::System.IntPtr GetCustomAttributes0(global::System.IntPtr @__envp, global::System.IntPtr @__obj, bool inherit) {
            // (Z)[Lsystem/Object;
            // (Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object[]>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(inherit));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetCustomAttributes1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)[Lsystem/Object;
            // (LSystem/Type;Z)[LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object[]>(@__env, ((global::System.Reflection.ICustomAttributeProvider)(@__real)).GetCustomAttributes(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Type>(@__env, attributeType), inherit));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsDefined2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr attributeType, bool inherit) {
            // (Lsystem/Type;Z)Z
            // (LSystem/Type;Z)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return ((global::System.Reflection.ICustomAttributeProvider)(@__real)).IsDefined(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Type>(@__env, attributeType), inherit);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr MemberType3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/Reflection/MemberTypes;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Reflection.MemberTypes>(@__env, @__real.MemberType);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr Name4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<string>(@__env, @__real.Name);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr DeclaringType5(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Type>(@__env, @__real.DeclaringType);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr ReflectedType6(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Type;
            // ()LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Type>(@__env, @__real.ReflectedType);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static int MetadataToken7(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return @__real.MetadataToken;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr Module8(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/runtime/serialization/ISerializable;
            // ()LSystem/Reflection/Module;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Reflection.Module>(@__env, @__real.Module);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void GetTypeInfo9(global::System.IntPtr @__envp, global::System.IntPtr @__obj, uint iTInfo, uint lcid, global::System.IntPtr ppTInfo) {
            // (IILsystem/ValueType;)V
            // (LSystem/UInt32;LSystem/UInt32;LSystem/IntPtr;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Reflection.MemberInfo @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Reflection.MemberInfo>(@__env, @__obj);
            ((global::System.Runtime.InteropServices._MemberInfo)(@__real)).GetTypeInfo(iTInfo, lcid, ppTInfo);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Reflection.@__MemberInfo(@__env);
            }
        }
    }
    #endregion
}
