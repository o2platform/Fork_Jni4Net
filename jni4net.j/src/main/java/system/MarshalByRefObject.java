// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system;

@net.sf.jni4net.attributes.ClrType
public class MarshalByRefObject extends system.Object {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected MarshalByRefObject(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    protected MarshalByRefObject() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object GetLifetimeService();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Object;")
    public native system.Object InitializeLifetimeService();
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Type;)LSystem/Runtime/Remoting/ObjRef;")
    public native system.runtime.serialization.ISerializable CreateObjRef(system.Type requestedType);
    
    public static system.Type typeof() {
        return system.MarshalByRefObject.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.MarshalByRefObject.staticType = staticType;
    }
    //</generated-proxy>
}
