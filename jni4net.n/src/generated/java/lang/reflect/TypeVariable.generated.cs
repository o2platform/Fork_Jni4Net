//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface TypeVariable : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/GenericDeclaration;")]
        global::java.lang.reflect.GenericDeclaration getGenericDeclaration();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getBounds();
    }
    #endregion
    
    #region Component Designer generated code 
    public unsafe partial class TypeVariable_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__TypeVariable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.TypeVariable))]
    internal sealed unsafe partial class @__TypeVariable : global::java.lang.Object, global::java.lang.reflect.TypeVariable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericDeclaration0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getBounds2;
        
        protected @__TypeVariable(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.reflect.@__TypeVariable.staticClass = staticClass;
            global::java.lang.reflect.@__TypeVariable._getGenericDeclaration0 = env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
            global::java.lang.reflect.@__TypeVariable._getName1 = env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.@__TypeVariable._getBounds2 = env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getBounds", "()[Ljava/lang/reflect/Type;");
        }
        
        public global::java.lang.reflect.GenericDeclaration getGenericDeclaration() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.reflect.GenericDeclaration>(env.CallObjectMethod(this, global::java.lang.reflect.@__TypeVariable._getGenericDeclaration0));
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.reflect.@__TypeVariable._getName1));
        }
        
        public java.lang.reflect.Type[] getBounds() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return ((java.lang.reflect.Type[])(env.ConvertArrayToNet<java.lang.reflect.Type>(env.CallObjectMethod(this, global::java.lang.reflect.@__TypeVariable._getBounds2))));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__TypeVariable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getGenericDeclaration", "getGenericDeclaration0", "()Ljava/lang/reflect/GenericDeclaration;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getName", "getName1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getBounds", "getBounds2", "()[Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::java.lang.Object.JavaPtr* getGenericDeclaration0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/reflect/GenericDeclaration;
            // ()Ljava/lang/reflect/GenericDeclaration;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.TypeVariable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.TypeVariable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getGenericDeclaration());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* getName1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.TypeVariable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.TypeVariable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getName());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* getBounds2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::java.lang.reflect.TypeVariable real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.reflect.TypeVariable>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.getBounds());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.reflect.@__TypeVariable(env);
            }
        }
    }
    #endregion
}
