//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface GenericArrayType : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/Type;")]
        global::java.lang.reflect.Type getGenericComponentType();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class GenericArrayType_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__GenericArrayType.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.GenericArrayType))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.GenericArrayType))]
    internal sealed partial class @__GenericArrayType : global::java.lang.Object, global::java.lang.reflect.GenericArrayType {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericComponentType0;
        
        protected @__GenericArrayType(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.@__GenericArrayType.staticClass = staticClass;
            global::java.lang.reflect.@__GenericArrayType._getGenericComponentType0 = env.GetMethodID(global::java.lang.reflect.@__GenericArrayType.staticClass, "getGenericComponentType", "()Ljava/lang/reflect/Type;");
        }
        
        public global::java.lang.reflect.Type getGenericComponentType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.Type>(env, env.CallObjectMethodPtr(this, global::java.lang.reflect.@__GenericArrayType._getGenericComponentType0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__GenericArrayType);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getGenericComponentType", "getGenericComponentType0", "()Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::System.IntPtr getGenericComponentType0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/reflect/Type;
            // ()Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.reflect.GenericArrayType real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.reflect.GenericArrayType>(__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J(@__env, real.getGenericComponentType());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.@__GenericArrayType(env);
            }
        }
    }
    #endregion
}
