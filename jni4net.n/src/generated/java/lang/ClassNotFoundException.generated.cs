//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class ClassNotFoundException : global::java.lang.Exception {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getException0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor2;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public ClassNotFoundException(global::java.lang.String par0, global::java.lang.Throwable par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor1, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ClassNotFoundException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor2, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public ClassNotFoundException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor3, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected ClassNotFoundException(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.ClassNotFoundException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.ClassNotFoundException.staticClass = staticClass;
            global::java.lang.ClassNotFoundException._getException0 = env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "getException", "()Ljava/lang/Throwable;");
            global::java.lang.ClassNotFoundException.@__ctor1 = env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.ClassNotFoundException.@__ctor2 = env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "()V");
            global::java.lang.ClassNotFoundException.@__ctor3 = env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable getException() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Throwable>(env.CallObjectMethod(this, global::java.lang.ClassNotFoundException._getException0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.ClassNotFoundException(env);
            }
        }
    }
    #endregion
}
