//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public partial class IAsyncResult_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::System.@__IAsyncResult.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IAsyncResult))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IAsyncResult))]
    internal sealed partial class @__IAsyncResult : global::java.lang.Object, global::System.IAsyncResult {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsCompleted0;
        
        internal static global::net.sf.jni4net.jni.MethodId _AsyncWaitHandle1;
        
        internal static global::net.sf.jni4net.jni.MethodId _AsyncState2;
        
        internal static global::net.sf.jni4net.jni.MethodId _CompletedSynchronously3;
        
        private @__IAsyncResult(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public bool IsCompleted {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return ((bool)(@__env.CallBooleanMethod(this, global::System.@__IAsyncResult._IsCompleted0)));
            }
        }
        
        public global::System.Threading.WaitHandle AsyncWaitHandle {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.StrongJp2C<global::System.Threading.WaitHandle>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IAsyncResult._AsyncWaitHandle1));
            }
        }
        
        public object AsyncState {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.FullJ2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.@__IAsyncResult._AsyncState2));
            }
        }
        
        public bool CompletedSynchronously {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return ((bool)(@__env.CallBooleanMethod(this, global::System.@__IAsyncResult._CompletedSynchronously3)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.@__IAsyncResult.staticClass = @__class;
            global::System.@__IAsyncResult._IsCompleted0 = @__env.GetMethodID(global::System.@__IAsyncResult.staticClass, "isCompleted", "()Z");
            global::System.@__IAsyncResult._AsyncWaitHandle1 = @__env.GetMethodID(global::System.@__IAsyncResult.staticClass, "getAsyncWaitHandle", "()Lsystem/MarshalByRefObject;");
            global::System.@__IAsyncResult._AsyncState2 = @__env.GetMethodID(global::System.@__IAsyncResult.staticClass, "getAsyncState", "()Lsystem/Object;");
            global::System.@__IAsyncResult._CompletedSynchronously3 = @__env.GetMethodID(global::System.@__IAsyncResult.staticClass, "getCompletedSynchronously", "()Z");
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IAsyncResult);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isCompleted", "IsCompleted0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAsyncWaitHandle", "AsyncWaitHandle1", "()Lsystem/MarshalByRefObject;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getAsyncState", "AsyncState2", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCompletedSynchronously", "CompletedSynchronously3", "()Z"));
            return methods;
        }
        
        private static bool IsCompleted0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.IAsyncResult @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, @__obj);
            @__return = ((bool)(@__real.IsCompleted));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle AsyncWaitHandle1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/MarshalByRefObject;
            // ()LSystem/Threading/WaitHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IAsyncResult @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongC2Jp<global::System.Threading.WaitHandle>(@__env, @__real.AsyncWaitHandle);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle AsyncState2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::System.IAsyncResult @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<object>(@__env, @__real.AsyncState);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static bool CompletedSynchronously3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::System.IAsyncResult @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::System.IAsyncResult>(@__env, @__obj);
            @__return = ((bool)(@__real.CompletedSynchronously));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.@__IAsyncResult(@__env);
            }
        }
    }
    #endregion
}
