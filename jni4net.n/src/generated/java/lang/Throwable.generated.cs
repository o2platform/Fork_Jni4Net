//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class Throwable : global::java.io.Serializable, global::System.IDisposable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace1;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace2;
        
        internal static global::net.sf.jni4net.jni.MethodId _printStackTrace3;
        
        internal static global::net.sf.jni4net.jni.MethodId _fillInStackTrace4;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCause5;
        
        internal static global::net.sf.jni4net.jni.MethodId _initCause6;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getMessage8;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLocalizedMessage9;
        
        internal static global::net.sf.jni4net.jni.MethodId _getStackTrace10;
        
        internal static global::net.sf.jni4net.jni.MethodId _setStackTrace11;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait12;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait13;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait14;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode15;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass16;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals17;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify18;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll19;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor20;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor21;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor22;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor23;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Throwable(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor20, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.String par0, global::java.lang.Throwable par1) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor21, this, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)V")]
        public Throwable(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor22, this, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Throwable() {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.GetEnv();
            env.NewObject(global::java.lang.Throwable.staticClass, global::java.lang.Throwable.@__ctor23, this);
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Throwable.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.Throwable.staticClass = staticClass;
            global::java.lang.Throwable._printStackTrace1 = env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintWriter;)V");
            global::java.lang.Throwable._printStackTrace2 = env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "(Ljava/io/PrintStream;)V");
            global::java.lang.Throwable._printStackTrace3 = env.GetMethodID(global::java.lang.Throwable.staticClass, "printStackTrace", "()V");
            global::java.lang.Throwable._fillInStackTrace4 = env.GetMethodID(global::java.lang.Throwable.staticClass, "fillInStackTrace", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._getCause5 = env.GetMethodID(global::java.lang.Throwable.staticClass, "getCause", "()Ljava/lang/Throwable;");
            global::java.lang.Throwable._initCause6 = env.GetMethodID(global::java.lang.Throwable.staticClass, "initCause", "(Ljava/lang/Throwable;)Ljava/lang/Throwable;");
            global::java.lang.Throwable._toString7 = env.GetMethodID(global::java.lang.Throwable.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.Throwable._getMessage8 = env.GetMethodID(global::java.lang.Throwable.staticClass, "getMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getLocalizedMessage9 = env.GetMethodID(global::java.lang.Throwable.staticClass, "getLocalizedMessage", "()Ljava/lang/String;");
            global::java.lang.Throwable._getStackTrace10 = env.GetMethodID(global::java.lang.Throwable.staticClass, "getStackTrace", "()[Ljava/lang/StackTraceElement;");
            global::java.lang.Throwable._setStackTrace11 = env.GetMethodID(global::java.lang.Throwable.staticClass, "setStackTrace", "([Ljava/lang/StackTraceElement;)V");
            global::java.lang.Throwable._wait12 = env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "()V");
            global::java.lang.Throwable._wait13 = env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(JI)V");
            global::java.lang.Throwable._wait14 = env.GetMethodID(global::java.lang.Throwable.staticClass, "wait", "(J)V");
            global::java.lang.Throwable._hashCode15 = env.GetMethodID(global::java.lang.Throwable.staticClass, "hashCode", "()I");
            global::java.lang.Throwable._getClass16 = env.GetMethodID(global::java.lang.Throwable.staticClass, "getClass", "()Ljava/lang/Class;");
            global::java.lang.Throwable._equals17 = env.GetMethodID(global::java.lang.Throwable.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.lang.Throwable._notify18 = env.GetMethodID(global::java.lang.Throwable.staticClass, "notify", "()V");
            global::java.lang.Throwable._notifyAll19 = env.GetMethodID(global::java.lang.Throwable.staticClass, "notifyAll", "()V");
            global::java.lang.Throwable.@__ctor20 = env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.Throwable.@__ctor21 = env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctor22 = env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
            global::java.lang.Throwable.@__ctor23 = env.GetMethodID(global::java.lang.Throwable.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(LSystem/Object;)V")]
        public virtual void printStackTrace(object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public virtual void printStackTrace(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace2, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void printStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._printStackTrace3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable fillInStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Throwable>(env.CallObjectMethod(this, global::java.lang.Throwable._fillInStackTrace4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable getCause() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Throwable>(env.CallObjectMethod(this, global::java.lang.Throwable._getCause5));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Throwable;)Ljava/lang/Throwable;")]
        public virtual global::java.lang.Throwable initCause(global::java.lang.Throwable par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Throwable>(env.CallObjectMethod(this, global::java.lang.Throwable._initCause6, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Throwable._toString7));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getMessage() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Throwable._getMessage8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getLocalizedMessage() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.Throwable._getLocalizedMessage9));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/StackTraceElement;")]
        public virtual java.lang.StackTraceElement[] getStackTrace() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.StackTraceElement[])(env.ConvertArrayToNet<java.lang.StackTraceElement>(env.CallObjectMethod(this, global::java.lang.Throwable._getStackTrace10))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/StackTraceElement;)V")]
        public virtual void setStackTrace(java.lang.StackTraceElement[] par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._setStackTrace11, global::net.sf.jni4net.jni.Value.CreateArray(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._wait12);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._wait13, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._wait14, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.Throwable._hashCode15);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.Throwable._getClass16));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.Throwable._equals17, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._notify18);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.lang.Throwable._notifyAll19);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.Throwable(env);
            }
        }
    }
    #endregion
}
