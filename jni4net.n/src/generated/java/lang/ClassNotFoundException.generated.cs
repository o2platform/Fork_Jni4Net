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
    public partial class ClassNotFoundException : global::java.lang.Exception {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getException0;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor1;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor2;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor3;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public ClassNotFoundException(global::java.lang.String par0, global::java.lang.Throwable par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor1, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Throwable>(@__env, par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public ClassNotFoundException() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor2, this);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public ClassNotFoundException(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.ClassNotFoundException.staticClass, global::java.lang.ClassNotFoundException.@__ctor3, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected ClassNotFoundException(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.ClassNotFoundException.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.ClassNotFoundException.staticClass = @__class;
            global::java.lang.ClassNotFoundException._getException0 = @__env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "getException", "()Ljava/lang/Throwable;");
            global::java.lang.ClassNotFoundException.@__ctor1 = @__env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.ClassNotFoundException.@__ctor2 = @__env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "()V");
            global::java.lang.ClassNotFoundException.@__ctor3 = @__env.GetMethodID(global::java.lang.ClassNotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable getException() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Throwable>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.ClassNotFoundException._getException0));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.ClassNotFoundException(@__env);
            }
        }
    }
    #endregion
}
