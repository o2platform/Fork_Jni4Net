//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class MarshalByRefObject_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__MarshalByRefObject.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.MarshalByRefObject))]
    internal sealed partial class @__MarshalByRefObject : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__MarshalByRefObject(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__MarshalByRefObject.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__MarshalByRefObject);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetLifetimeService", "GetLifetimeService0", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "InitializeLifetimeService", "InitializeLifetimeService1", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CreateObjRef", "CreateObjRef2", "(Lsystem/Type;)Lsystem/runtime/serialization/ISerializable;"));
            return methods;
        }
        
        private static global::System.IntPtr GetLifetimeService0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.MarshalByRefObject real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.MarshalByRefObject>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetLifetimeService());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr InitializeLifetimeService1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.MarshalByRefObject real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.MarshalByRefObject>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.InitializeLifetimeService());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr CreateObjRef2(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr requestedType) {
            // (Lsystem/Type;)Lsystem/runtime/serialization/ISerializable;
            // (LSystem/Type;)LSystem/Runtime/Remoting/ObjRef;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.MarshalByRefObject real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.MarshalByRefObject>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.CreateObjRef(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, requestedType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__MarshalByRefObject(env);
            }
        }
    }
    #endregion
}
