//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace org.drools.command {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface BatchExecutionCommand : global::org.drools.command.Command {
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class BatchExecutionCommand_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::org.drools.command.@__BatchExecutionCommand.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::org.drools.command.BatchExecutionCommand), typeof(global::org.drools.command.BatchExecutionCommand_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::org.drools.command.BatchExecutionCommand), typeof(global::org.drools.command.BatchExecutionCommand_))]
    internal sealed partial class @__BatchExecutionCommand : global::java.lang.Object, global::org.drools.command.BatchExecutionCommand {
        
        internal new static global::java.lang.Class staticClass;
        
        private @__BatchExecutionCommand(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::org.drools.command.@__BatchExecutionCommand.staticClass = @__class;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__BatchExecutionCommand);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            return methods;
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::org.drools.command.@__BatchExecutionCommand(@__env);
            }
        }
    }
    #endregion
}
