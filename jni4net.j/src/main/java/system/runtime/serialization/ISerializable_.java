// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.runtime.serialization;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class ISerializable_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return system.runtime.serialization.ISerializable_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.runtime.serialization.ISerializable_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __ISerializable extends system.Object implements system.runtime.serialization.ISerializable {
    
    @net.sf.jni4net.attributes.ClrMethod("(LSystem/Runtime/Serialization/SerializationInfo;LSystem/Runtime/Serialization/StreamingContext;)V")
    public native void GetObjectData(java.lang.Object info, system.ValueType context);
}
//</generated-proxy>
