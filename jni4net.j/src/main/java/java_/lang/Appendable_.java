// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

package java_.lang;

@net.sf.jni4net.attributes.ClrTypeInfo
public final class Appendable_ {
    
    //<generated-static>
    private static system.Type staticType;
    
    public static system.Type typeof() {
        return java_.lang.Appendable_.staticType;
    }
    
    private static void InitJNI(net.sf.jni4net.inj.INJEnv env, system.Type staticType) {
        java_.lang.Appendable_.staticType = staticType;
    }
    //</generated-static>
}

//<generated-proxy>
@net.sf.jni4net.attributes.ClrProxy
class __Appendable extends system.Object implements java.lang.Appendable {
    
    protected __Appendable(net.sf.jni4net.inj.INJEnv __env, int __handle) {
            super(__env, __handle);
    }
    
    @net.sf.jni4net.attributes.ClrMethod("(C)Ljava/lang/Appendable;")
    public native java.lang.Appendable append(char par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")
    public native java.lang.Appendable append(java.lang.CharSequence par0);
    
    @net.sf.jni4net.attributes.ClrMethod("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")
    public native java.lang.Appendable append(java.lang.CharSequence par0, int par1, int par2);
}
//</generated-proxy>
