//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public unsafe partial class ICloneable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__ICloneable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.ICloneable))]
    internal unsafe partial class @__ICloneable : global::java.lang.Object, global::System.ICloneable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _Clone0;
        
        protected @__ICloneable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__ICloneable.staticClass = staticClass;
            global::System.@__ICloneable._Clone0 = env.GetMethodID(global::System.@__ICloneable.staticClass, "Clone", "()Lsystem/Object;");
        }
        
        public virtual object Clone() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<object>(env.CallObjectMethod(this, global::System.@__ICloneable._Clone0));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(ICloneable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Clone", "Clone0", "()Lsystem/Object;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* Clone0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.ICloneable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.ICloneable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Clone());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__ICloneable(env);
            }
        }
    }
    #endregion
}
