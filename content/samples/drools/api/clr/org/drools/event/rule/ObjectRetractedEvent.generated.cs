//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.@event.rule {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface ObjectRetractedEvent : global::org.drools.@event.rule.WorkingMemoryEvent {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Lorg/drools/runtime/rule/FactHandle;")]
        global::org.drools.runtime.rule.FactHandle getFactHandle();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Object;")]
        global::java.lang.Object getOldObject();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class ObjectRetractedEvent_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.@event.rule.ObjectRetractedEvent), typeof(global::org.drools.@event.rule.ObjectRetractedEvent_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.@event.rule.ObjectRetractedEvent), typeof(global::org.drools.@event.rule.ObjectRetractedEvent_))]
    internal sealed partial class @__ObjectRetractedEvent : global::java.lang.Object, global::org.drools.@event.rule.ObjectRetractedEvent {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _getKnowledgeRuntime0;
        
        internal static global::net.sf.jni4net.jni.MethodId _getPropagationContext1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getFactHandle2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getOldObject3;
        
        private @__ObjectRetractedEvent(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass = @__class;
            global::org.drools.@event.rule.@__ObjectRetractedEvent._getKnowledgeRuntime0 = @__env.GetMethodID(global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass, "getKnowledgeRuntime", "()Lorg/drools/runtime/KnowledgeRuntime;");
            global::org.drools.@event.rule.@__ObjectRetractedEvent._getPropagationContext1 = @__env.GetMethodID(global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass, "getPropagationContext", "()Lorg/drools/runtime/rule/PropagationContext;");
            global::org.drools.@event.rule.@__ObjectRetractedEvent._getFactHandle2 = @__env.GetMethodID(global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass, "getFactHandle", "()Lorg/drools/runtime/rule/FactHandle;");
            global::org.drools.@event.rule.@__ObjectRetractedEvent._getOldObject3 = @__env.GetMethodID(global::org.drools.@event.rule.@__ObjectRetractedEvent.staticClass, "getOldObject", "()Ljava/lang/Object;");
        }
        
        public global::org.drools.runtime.KnowledgeRuntime getKnowledgeRuntime() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.KnowledgeRuntime>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ObjectRetractedEvent._getKnowledgeRuntime0));
            }
        }
        
        public global::org.drools.runtime.rule.PropagationContext getPropagationContext() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.PropagationContext>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ObjectRetractedEvent._getPropagationContext1));
            }
        }
        
        public global::org.drools.runtime.rule.FactHandle getFactHandle() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.runtime.rule.FactHandle>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ObjectRetractedEvent._getFactHandle2));
            }
        }
        
        public global::java.lang.Object getOldObject() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::org.drools.@event.rule.@__ObjectRetractedEvent._getOldObject3));
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__ObjectRetractedEvent);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getKnowledgeRuntime", "getKnowledgeRuntime0", "()Lorg/drools/runtime/KnowledgeRuntime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getPropagationContext", "getPropagationContext1", "()Lorg/drools/runtime/rule/PropagationContext;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getFactHandle", "getFactHandle2", "()Lorg/drools/runtime/rule/FactHandle;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getOldObject", "getOldObject3", "()Ljava/lang/Object;"));
            return methods;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getKnowledgeRuntime0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            // ()Lorg/drools/runtime/KnowledgeRuntime;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ObjectRetractedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ObjectRetractedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.KnowledgeRuntime>(@__env, ((global::org.drools.@event.KnowledgeRuntimeEvent)(@__real)).getKnowledgeRuntime());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getPropagationContext1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/rule/PropagationContext;
            // ()Lorg/drools/runtime/rule/PropagationContext;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ObjectRetractedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ObjectRetractedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.PropagationContext>(@__env, ((global::org.drools.@event.rule.WorkingMemoryEvent)(@__real)).getPropagationContext());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getFactHandle2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Lorg/drools/runtime/rule/FactHandle;
            // ()Lorg/drools/runtime/rule/FactHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ObjectRetractedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ObjectRetractedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::org.drools.runtime.rule.FactHandle>(@__env, @__real.getFactHandle());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle getOldObject3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Ljava/lang/Object;
            // ()Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::org.drools.@event.rule.ObjectRetractedEvent @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::org.drools.@event.rule.ObjectRetractedEvent>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.lang.Object>(@__env, @__real.getOldObject());
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.@event.rule.@__ObjectRetractedEvent(@__env);
            }
        }
    }
    #endregion
}
