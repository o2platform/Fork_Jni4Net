//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Iterator {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool hasNext();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        global::java.lang.Object next();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void remove();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Iterator_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.@__Iterator.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.util.Iterator))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Iterator))]
    internal sealed partial class @__Iterator : global::java.lang.Object, global::java.util.Iterator {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _hasNext0;
        
        internal static global::net.sf.jni4net.jni.MethodId _next1;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove2;
        
        protected @__Iterator(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.util.@__Iterator.staticClass = staticClass;
            global::java.util.@__Iterator._hasNext0 = env.GetMethodID(global::java.util.@__Iterator.staticClass, "hasNext", "()Z");
            global::java.util.@__Iterator._next1 = env.GetMethodID(global::java.util.@__Iterator.staticClass, "next", "()Ljava/lang/Object;");
            global::java.util.@__Iterator._remove2 = env.GetMethodID(global::java.util.@__Iterator.staticClass, "remove", "()V");
        }
        
        public bool hasNext() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.util.@__Iterator._hasNext0);
        }
        
        public global::java.lang.Object next() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Object>(env.CallObjectMethod(this, global::java.util.@__Iterator._next1));
        }
        
        public void remove() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::java.util.@__Iterator._remove2);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Iterator);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "hasNext", "hasNext0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "next", "next1", "()Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "remove", "remove2", "()V"));
            return methods;
        }
        
        private static bool hasNext0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.util.Iterator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Iterator>(__env, @__obj);
            return real.hasNext();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr next1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/Object;
            // ()Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.util.Iterator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Iterator>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.next());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void remove2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.util.Iterator real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.util.Iterator>(__env, @__obj);
            real.remove();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.util.@__Iterator(env);
            }
        }
    }
    #endregion
}
