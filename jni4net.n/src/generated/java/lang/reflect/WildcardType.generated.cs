//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.reflect {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface WildcardType : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getLowerBounds();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getUpperBounds();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class WildcardType_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__WildcardType.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.WildcardType))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.WildcardType))]
    internal sealed partial class @__WildcardType : global::java.lang.Object, global::java.lang.reflect.WildcardType {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLowerBounds0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getUpperBounds1;
        
        protected @__WildcardType(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__WildcardType.staticClass = @__class;
            global::java.lang.reflect.@__WildcardType._getLowerBounds0 = @__env.GetMethodID(global::java.lang.reflect.@__WildcardType.staticClass, "getLowerBounds", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__WildcardType._getUpperBounds1 = @__env.GetMethodID(global::java.lang.reflect.@__WildcardType.staticClass, "getUpperBounds", "()[Ljava/lang/reflect/Type;");
        }
        
        public java.lang.reflect.Type[] getLowerBounds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__WildcardType._getLowerBounds0));
        }
        
        public java.lang.reflect.Type[] getUpperBounds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__WildcardType._getUpperBounds1));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__WildcardType);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getLowerBounds", "getLowerBounds0", "()[Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getUpperBounds", "getUpperBounds1", "()[Ljava/lang/reflect/Type;"));
            return methods;
        }
        
        private static global::System.IntPtr getLowerBounds0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.WildcardType @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.WildcardType>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__real.getLowerBounds());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr getUpperBounds1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.lang.reflect.WildcardType @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.WildcardType>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__real.getUpperBounds());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__WildcardType(@__env);
            }
        }
    }
    #endregion
}
