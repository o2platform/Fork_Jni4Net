//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net {
    
    
    #region Component Designer generated code 
    public partial class Bridge_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.@__Bridge.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.jni4net.Bridge))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.jni4net.Bridge))]
    internal sealed partial class @__Bridge : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__Bridge(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.jni4net.@__Bridge.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Bridge);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSetup", "Setup0", "()Lnet/sf/jni4net/BridgeSetup;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnownAssemblies", "KnownAssemblies1", "()Lsystem/collections/IList;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CreateJVM", "CreateJVM2", "(Lnet/sf/jni4net/BridgeSetup;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "LoadAndRegisterAssembly", "LoadAndRegisterAssembly3", "(Ljava/lang/String;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RegisterAssembly", "RegisterAssembly4", "(Lsystem/reflection/Assembly;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "SetSystemClassLoader", "SetSystemClassLoader5", "(Ljava/lang/ClassLoader;)V"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle Setup0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()Lnet/sf/jni4net/BridgeSetup;
            // ()Lnet/sf/jni4net/BridgeSetup;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::net.sf.jni4net.BridgeSetup>(@__env, global::net.sf.jni4net.Bridge.Setup);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle KnownAssemblies1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class) {
            // ()Lsystem/collections/IList;
            // ()[[LSystem/Collections/Generic/IList`1;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::System.Collections.Generic.IList<System.Reflection.Assembly>>(@__env, global::net.sf.jni4net.Bridge.KnownAssemblies);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static global::net.sf.jni4net.utils.JniHandle CreateJVM2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle setup) {
            // (Lnet/sf/jni4net/BridgeSetup;)Lsystem/Object;
            // (Lnet/sf/jni4net/BridgeSetup;)Lnet/sf/jni4net/jni/JNIEnv;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            return global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::net.sf.jni4net.jni.JNIEnv>(@__env, global::net.sf.jni4net.Bridge.CreateJVM(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::net.sf.jni4net.BridgeSetup>(@__env, setup)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return default(global::net.sf.jni4net.utils.JniHandle);
        }
        
        private static void LoadAndRegisterAssembly3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle assemblyPath) {
            // (Ljava/lang/String;)V
            // (LSystem/String;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.Bridge.LoadAndRegisterAssembly(global::net.sf.jni4net.utils.Convertor.StrongJ2CString(@__env, assemblyPath));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void RegisterAssembly4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle assembly) {
            // (Lsystem/reflection/Assembly;)V
            // (LSystem/Reflection/Assembly;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.Bridge.RegisterAssembly(global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Reflection.Assembly>(@__env, assembly));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void SetSystemClassLoader5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__class, global::net.sf.jni4net.utils.JniLocalHandle classLoader) {
            // (Ljava/lang/ClassLoader;)V
            // (Ljava/lang/ClassLoader;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.jni4net.Bridge.SetSystemClassLoader(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.ClassLoader>(@__env, classLoader));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.jni4net.@__Bridge(@__env);
            }
        }
    }
    #endregion
}
