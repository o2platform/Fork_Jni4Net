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
    public partial class NotSupportedException_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__NotSupportedException.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.NotSupportedException))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.NotSupportedException))]
    internal sealed partial class @__NotSupportedException : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__NotSupportedException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__NotSupportedException.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__NotSupportedException);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNotSupportedException0", "__ctorNotSupportedException0", "(Lnet/sf/jni4net/inj/ICClrProxy;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNotSupportedException1", "__ctorNotSupportedException1", "(Lnet/sf/jni4net/inj/ICClrProxy;Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorNotSupportedException2", "__ctorNotSupportedException2", "(Lnet/sf/jni4net/inj/ICClrProxy;Ljava/lang/String;Lsystem/Exception;)V"));
            return methods;
        }
        
        private static void @__ctorNotSupportedException0(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NotSupportedException @__real = new global::System.NotSupportedException();
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNotSupportedException1(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NotSupportedException @__real = new global::System.NotSupportedException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorNotSupportedException2(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, global::System.IntPtr message, global::System.IntPtr innerException) {
            // (Ljava/lang/String;Lsystem/Exception;)V
            // (LSystem/String;LSystem/Exception;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.NotSupportedException @__real = new global::System.NotSupportedException(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, message), global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.Exception>(@__env, innerException));
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.ICJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__NotSupportedException(@__env);
            }
        }
    }
    #endregion
}
