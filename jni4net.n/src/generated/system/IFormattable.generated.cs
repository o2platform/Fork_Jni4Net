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
    public unsafe partial class IFormattable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__IFormattable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IFormattable))]
    internal unsafe partial class @__IFormattable : global::java.lang.Object, global::System.IFormattable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _ToString0;
        
        protected @__IFormattable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__IFormattable.staticClass = staticClass;
            global::System.@__IFormattable._ToString0 = env.GetMethodID(global::System.@__IFormattable.staticClass, "ToString", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;");
        }
        
        public virtual string ToString(string format, global::System.IFormatProvider formatProvider) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<string>(env.CallObjectMethod(this, global::System.@__IFormattable._ToString0, new global::net.sf.jni4net.jni.Value(format), new global::net.sf.jni4net.jni.Value(formatProvider)));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__IFormattable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString0", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* ToString0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* format, global::java.lang.Object.JavaPtr* formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.IFormattable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormattable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, formatProvider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__IFormattable(env);
            }
        }
    }
    #endregion
}
