//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.time {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface SessionClock {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()J")]
        long getCurrentTime();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class SessionClock_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.time.@__SessionClock.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.time.SessionClock), typeof(global::org.drools.time.SessionClock_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.time.SessionClock), typeof(global::org.drools.time.SessionClock_))]
    internal sealed partial class @__SessionClock : global::java.lang.Object, global::org.drools.time.SessionClock {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getCurrentTime0;
        
        private @__SessionClock(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.time.@__SessionClock.staticClass = @__class;
            global::org.drools.time.@__SessionClock._getCurrentTime0 = @__env.GetMethodID(global::org.drools.time.@__SessionClock.staticClass, "getCurrentTime", "()J");
        }
        
        public long getCurrentTime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((long)(@__env.CallLongMethod(this, global::org.drools.time.@__SessionClock._getCurrentTime0)));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__SessionClock);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCurrentTime", "getCurrentTime0", "()J"));
            return methods;
        }
        
        private static long getCurrentTime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            long @__return = default(long);
            try {
            global::org.drools.time.SessionClock @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.time.SessionClock>(@__env, @__obj);
            @__return = ((long)(@__real.getCurrentTime()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.time.@__SessionClock(@__env);
            }
        }
    }
    #endregion
}
