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
    public unsafe partial class StackTraceElement : global::java.lang.Object, global::java.io.Serializable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClassName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFileName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLineNumber2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMethodName3;
        
        internal static global::net.sf.jni4net.jni.MethodId _isNativeMethod4;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor5;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V")]
        public StackTraceElement(global::java.lang.String par0, global::java.lang.String par1, global::java.lang.String par2, int par3) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.StackTraceElement.staticClass, global::java.lang.StackTraceElement.@__ctor5, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1), new global::net.sf.jni4net.jni.Value(par2), new global::net.sf.jni4net.jni.Value(par3));
        }
        
        protected StackTraceElement(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.StackTraceElement.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.StackTraceElement.staticClass = staticClass;
            global::java.lang.StackTraceElement._getClassName0 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getClassName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._getFileName1 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getFileName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._getLineNumber2 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getLineNumber", "()I");
            global::java.lang.StackTraceElement._getMethodName3 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "getMethodName", "()Ljava/lang/String;");
            global::java.lang.StackTraceElement._isNativeMethod4 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "isNativeMethod", "()Z");
            global::java.lang.StackTraceElement.@__ctor5 = env.GetMethodID(global::java.lang.StackTraceElement.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getClassName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.StackTraceElement._getClassName0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getFileName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.StackTraceElement._getFileName1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int getLineNumber() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.StackTraceElement._getLineNumber2);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getMethodName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.StackTraceElement._getMethodName3));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool isNativeMethod() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.StackTraceElement._isNativeMethod4);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.StackTraceElement(env);
            }
        }
    }
    #endregion
}
