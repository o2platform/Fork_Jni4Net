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
    public partial interface TypeVariable : global::java.lang.reflect.Type {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String getName();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/reflect/Type;")]
        java.lang.reflect.Type[] getBounds();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/reflect/GenericDeclaration;")]
        global::java.lang.reflect.GenericDeclaration getGenericDeclaration();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class TypeVariable_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::java.lang.reflect.@__TypeVariable.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.lang.reflect.TypeVariable), typeof(global::java.lang.reflect.TypeVariable_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.reflect.TypeVariable), typeof(global::java.lang.reflect.TypeVariable_))]
    internal sealed partial class @__TypeVariable : global::java.lang.Object, global::java.lang.reflect.TypeVariable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getName0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getBounds1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getGenericDeclaration2;
        
        private @__TypeVariable(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.reflect.@__TypeVariable.staticClass = @__class;
            global::java.lang.reflect.@__TypeVariable._getName0 = @__env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getName", "()Ljava/lang/String;");
            global::java.lang.reflect.@__TypeVariable._getBounds1 = @__env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getBounds", "()[Ljava/lang/reflect/Type;");
            global::java.lang.reflect.@__TypeVariable._getGenericDeclaration2 = @__env.GetMethodID(global::java.lang.reflect.@__TypeVariable.staticClass, "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;");
        }
        
        public global::java.lang.String getName() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__TypeVariable._getName0));
        }
        
        public java.lang.reflect.Type[] getBounds() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayFullJ2C<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__TypeVariable._getBounds1));
        }
        
        public global::java.lang.reflect.GenericDeclaration getGenericDeclaration() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.GenericDeclaration>(@__env, @__env.CallObjectMethodPtr(this, global::java.lang.reflect.@__TypeVariable._getGenericDeclaration2));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__TypeVariable);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getName", "getName0", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getBounds", "getBounds1", "()[Ljava/lang/reflect/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getGenericDeclaration", "getGenericDeclaration2", "()Ljava/lang/reflect/GenericDeclaration;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getName0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.lang.reflect.TypeVariable @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.TypeVariable>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.getName());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getBounds1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()[Ljava/lang/reflect/Type;
            // ()[Ljava/lang/reflect/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.lang.reflect.TypeVariable @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.TypeVariable>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.ArrayFullC2J<java.lang.reflect.Type[], global::java.lang.reflect.Type>(@__env, @__real.getBounds());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getGenericDeclaration2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/reflect/GenericDeclaration;
            // ()Ljava/lang/reflect/GenericDeclaration;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::java.lang.reflect.TypeVariable @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.reflect.TypeVariable>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.reflect.GenericDeclaration>(@__env, @__real.getGenericDeclaration());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.reflect.@__TypeVariable(@__env);
            }
        }
    }
    #endregion
}
