// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package net.sf.jni4net.tested;

@net.sf.jni4net.attributes.ClrType
public class CWithJavaInterface extends system.Object implements java.lang.Comparable, java.lang.Runnable {
    
    //<generated-proxy>
    private static system.Type staticType;
    
    protected CWithJavaInterface(net.sf.jni4net.inj.INJEnv __env, long __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrConstructor("(I)V")
    public CWithJavaInterface(int value) {
            super(((net.sf.jni4net.inj.INJEnv)(null)), 0);
        net.sf.jni4net.tested.CWithJavaInterface.__ctorCWithJavaInterface0(this, value);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    private native static void __ctorCWithJavaInterface0(net.sf.jni4net.inj.IClrProxy thiz, int value);
    
    @net.sf.jni4net.attributes.ClrMethod("()I")
    public native final int getValue();
    
    @net.sf.jni4net.attributes.ClrMethod("(I)V")
    public native final void setValue(int value);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/Object;)I")
    public native int compareTo(java.lang.Object objectPar0);
    
    @net.sf.jni4net.attributes.ClrMethod("()V")
    public native void run();
    
    public static system.Type typeof() {
        return net.sf.jni4net.tested.CWithJavaInterface.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        net.sf.jni4net.tested.CWithJavaInterface.staticType = staticType;
    }
    //</generated-proxy>
}
