//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class JInterfacesHelper : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCWithJavaInterfaceC0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCWithJavaInterface1;
        
        internal static global::net.sf.jni4net.jni.MethodId _createJWithClrInterface2;
        
        internal static global::net.sf.jni4net.jni.MethodId _createJWithClrInterfaceUnreg3;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait4;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait5;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait6;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode7;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass8;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals9;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString10;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify11;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll12;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor13;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JInterfacesHelper() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, global::net.sf.jni4net.tested.JInterfacesHelper.@__ctor13, this);
        }
        
        protected JInterfacesHelper(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JInterfacesHelper.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.JInterfacesHelper.staticClass = staticClass;
            global::net.sf.jni4net.tested.JInterfacesHelper._getCWithJavaInterfaceC0 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "getCWithJavaInterfaceC", "(Lnet/sf/jni4net/tested/CWithJavaInterface;)Lnet/sf/jni4net/tested/CWithJavaInter" +
                    "face;");
            global::net.sf.jni4net.tested.JInterfacesHelper._getCWithJavaInterface1 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "getCWithJavaInterface", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;");
            global::net.sf.jni4net.tested.JInterfacesHelper._createJWithClrInterface2 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterface", "(I)Lnet/sf/jni4net/tested/JWithClrInterface;");
            global::net.sf.jni4net.tested.JInterfacesHelper._createJWithClrInterfaceUnreg3 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "createJWithClrInterfaceUnreg", "(I)Lsystem/IComparable;");
            global::net.sf.jni4net.tested.JInterfacesHelper._wait4 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "wait", "()V");
            global::net.sf.jni4net.tested.JInterfacesHelper._wait5 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "wait", "(JI)V");
            global::net.sf.jni4net.tested.JInterfacesHelper._wait6 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "wait", "(J)V");
            global::net.sf.jni4net.tested.JInterfacesHelper._hashCode7 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "hashCode", "()I");
            global::net.sf.jni4net.tested.JInterfacesHelper._getClass8 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "getClass", "()Ljava/lang/Class;");
            global::net.sf.jni4net.tested.JInterfacesHelper._equals9 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JInterfacesHelper._toString10 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "toString", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JInterfacesHelper._notify11 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "notify", "()V");
            global::net.sf.jni4net.tested.JInterfacesHelper._notifyAll12 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "notifyAll", "()V");
            global::net.sf.jni4net.tested.JInterfacesHelper.@__ctor13 = env.GetMethodID(global::net.sf.jni4net.tested.JInterfacesHelper.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/jni4net/tested/CWithJavaInterface;)Lnet/sf/jni4net/tested/CWithJavaInter" +
            "face;")]
        public virtual global::net.sf.jni4net.tested.CWithJavaInterface getCWithJavaInterfaceC(global::net.sf.jni4net.tested.CWithJavaInterface par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::net.sf.jni4net.tested.CWithJavaInterface>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._getCWithJavaInterfaceC0, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Runnable;)Ljava/lang/Runnable;")]
        public virtual global::java.lang.Runnable getCWithJavaInterface(global::java.lang.Runnable par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Runnable>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._getCWithJavaInterface1, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)Lnet/sf/jni4net/tested/JWithClrInterface;")]
        public virtual global::net.sf.jni4net.tested.JWithClrInterface createJWithClrInterface(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::net.sf.jni4net.tested.JWithClrInterface>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._createJWithClrInterface2, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)LSystem/IComparable;")]
        public virtual global::System.IComparable createJWithClrInterfaceUnreg(int par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::System.IComparable>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._createJWithClrInterfaceUnreg3, new global::net.sf.jni4net.jni.Value(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._wait4);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._wait5, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._wait6, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._hashCode7);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._getClass8));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._equals9, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._toString10));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._notify11);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JInterfacesHelper._notifyAll12);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.JInterfacesHelper(env);
            }
        }
    }
    #endregion
}
