//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Security {
    
    
    #region Component Designer generated code 
    public unsafe partial class IEvidenceFactory_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Security.@__IEvidenceFactory.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Security.IEvidenceFactory))]
    internal sealed unsafe partial class @__IEvidenceFactory : global::java.lang.Object, global::System.Security.IEvidenceFactory {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _Evidence0;
        
        protected @__IEvidenceFactory(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public global::System.Security.Policy.Evidence Evidence {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = this.Env;
                return global::net.sf.jni4net.Bridge.ToCLR<global::System.Security.Policy.Evidence>(env.CallObjectMethod(this, global::System.Security.@__IEvidenceFactory._Evidence0));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.Security.@__IEvidenceFactory.staticClass = staticClass;
            global::System.Security.@__IEvidenceFactory._Evidence0 = env.GetMethodID(global::System.Security.@__IEvidenceFactory.staticClass, "getEvidence", "()Lsystem/collections/ICollection;");
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IEvidenceFactory);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getEvidence", "Evidence0", "()Lsystem/collections/ICollection;"));
            return methods;
        }
        
        private static global::System.IntPtr Evidence0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/ICollection;
            // ()LSystem/Security/Policy/Evidence;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.Security.IEvidenceFactory real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Security.IEvidenceFactory>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.Evidence);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.Security.@__IEvidenceFactory(env);
            }
        }
    }
    #endregion
}
