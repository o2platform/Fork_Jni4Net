// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package system.reflection;

@net.sf.jni4net.attributes.ClrType
public class MethodInfo extends system.reflection.MethodBase {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected MethodInfo(net.sf.jni4net.inj.INJEnv env, int handle) {
            super(env, handle);
    }
    
    protected MethodInfo() {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Type;")
    public native system.Type getReturnType();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/ParameterInfo;")
    public native system.reflection.ParameterInfo getReturnParameter();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/ICustomAttributeProvider;")
    public native system.reflection.ICustomAttributeProvider getReturnTypeCustomAttributes();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodInfo;")
    public native system.reflection.MethodInfo GetBaseDefinition();
    
    @net.sf.jni4net.attributes.ClrMethod("()LSystem/Reflection/MethodInfo;")
    public native system.reflection.MethodInfo GetGenericMethodDefinition();
    
    @net.sf.jni4net.attributes.ClrMethod("([LSystem/Type;)LSystem/Reflection/MethodInfo;")
    public native system.reflection.MethodInfo MakeGenericMethod(system.Type[] typeArguments);
    
    public static system.Type typeof() {
        return system.reflection.MethodInfo.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        system.reflection.MethodInfo.staticType = staticType;
    }
    //</generated-proxy>
}
