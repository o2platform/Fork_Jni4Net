//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public unsafe partial class NullReferenceException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__NullReferenceException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.NullReferenceException))]
    internal unsafe partial class @__NullReferenceException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__NullReferenceException(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__NullReferenceException.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__NullReferenceException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNullReferenceException0", "__ctorNullReferenceException0", "(Lnet/sf/jni4net/inj/IClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNullReferenceException1", "__ctorNullReferenceException1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorNullReferenceException2", "__ctorNullReferenceException2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorNullReferenceException0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.NullReferenceException real = new global::System.NullReferenceException();
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNullReferenceException1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.NullReferenceException real = new global::System.NullReferenceException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNullReferenceException2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* message, global::java.lang.Object.JavaPtr* innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.NullReferenceException real = new global::System.NullReferenceException(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, message), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Exception>(__env, innerException));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__NullReferenceException(env);
            }
        }
    }
    #endregion
}
