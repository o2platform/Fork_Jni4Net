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
    public unsafe partial class Error : global::java.lang.Throwable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor2;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public Error(global::java.lang.String par0, global::java.lang.Throwable par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Error.staticClass, global::java.lang.Error.@__ctor0, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public Error(global::java.lang.Throwable par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Error.staticClass, global::java.lang.Error.@__ctor1, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Error() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Error.staticClass, global::java.lang.Error.@__ctor2, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Error(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::java.lang.Error.staticClass, global::java.lang.Error.@__ctor3, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        protected Error(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Error.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.Error.staticClass = staticClass;
            global::java.lang.Error.@__ctor0 = env.GetMethodID(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.Error.@__ctor1 = env.GetMethodID(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
            global::java.lang.Error.@__ctor2 = env.GetMethodID(global::java.lang.Error.staticClass, "<init>", "()V");
            global::java.lang.Error.@__ctor3 = env.GetMethodID(global::java.lang.Error.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.Error(env);
            }
        }
    }
    #endregion
}
