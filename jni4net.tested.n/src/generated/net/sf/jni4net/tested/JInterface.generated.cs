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
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface JInterface {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void runForrestRun();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void run();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class JInterface_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__JInterface.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.JInterface))]
    internal sealed partial class @__JInterface : global::java.lang.Object, global::net.sf.jni4net.tested.JInterface {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _runForrestRun0;
        
        internal static global::net.sf.jni4net.jni.MethodId _run1;
        
        internal static global::net.sf.jni4net.jni.MethodId _cdefined2;
        
        protected @__JInterface(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.@__JInterface.staticClass = staticClass;
            global::net.sf.jni4net.tested.@__JInterface._runForrestRun0 = env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "runForrestRun", "()V");
            global::net.sf.jni4net.tested.@__JInterface._run1 = env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "run", "()V");
            global::net.sf.jni4net.tested.@__JInterface._cdefined2 = env.GetMethodID(global::net.sf.jni4net.tested.@__JInterface.staticClass, "cdefined", "()V");
        }
        
        public void runForrestRun() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface._runForrestRun0);
        }
        
        public void run() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface._run1);
        }
        
        public void cdefined() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.@__JInterface._cdefined2);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__JInterface);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "runForrestRun", "runForrestRun0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "run", "run1", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "cdefined", "cdefined2", "()V"));
            return methods;
        }
        
        private static void runForrestRun0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.tested.JInterface real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.tested.JInterface>(__env, @__obj);
            real.runForrestRun();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void run1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.tested.JInterface real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.tested.JInterface>(__env, @__obj);
            real.run();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void cdefined2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::net.sf.jni4net.tested.JInterface real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::net.sf.jni4net.tested.JInterface>(__env, @__obj);
            real.cdefined();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.@__JInterface(env);
            }
        }
    }
    #endregion
}
