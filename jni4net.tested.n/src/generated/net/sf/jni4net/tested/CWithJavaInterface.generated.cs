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
    public partial class CWithJavaInterface_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.@__CWithJavaInterface.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.tested.CWithJavaInterface))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.tested.CWithJavaInterface))]
    internal sealed partial class @__CWithJavaInterface : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__CWithJavaInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.tested.@__CWithJavaInterface.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__CWithJavaInterface);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getValue", "Value0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setValue", "Value1", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "compareTo", "compareTo2", "(Ljava/lang/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "run", "run3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "__ctorCWithJavaInterface0", "__ctorCWithJavaInterface0", "(Lnet/sf/jni4net/inj/IClrProxy;I)V"));
            return methods;
        }
        
        private static int Value0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            return ((int)(@__real.Value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void Value1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            @__real.Value = value;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static int compareTo2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr objectPar0) {
            // (Ljava/lang/Object;)I
            // (Ljava/lang/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            return ((int)(@__real.compareTo(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, objectPar0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void run3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.tested.CWithJavaInterface>(@__env, @__obj);
            @__real.run();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorCWithJavaInterface0(global::System.IntPtr @__envp, global::System.IntPtr @__class, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.tested.CWithJavaInterface @__real = new global::net.sf.jni4net.tested.CWithJavaInterface(value);
            global::net.sf.jni4net.utils.Convertor.InitProxy(@__env, @__obj, @__real);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.tested.@__CWithJavaInterface(@__env);
            }
        }
    }
    #endregion
}
