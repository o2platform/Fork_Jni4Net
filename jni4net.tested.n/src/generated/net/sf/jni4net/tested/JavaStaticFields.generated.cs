//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.jni4net.tested {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public unsafe partial class JavaStaticFields : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait0;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait1;
        
        internal static global::net.sf.jni4net.jni.MethodId _wait2;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getClass4;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals5;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString6;
        
        internal static global::net.sf.jni4net.jni.MethodId _notify7;
        
        internal static global::net.sf.jni4net.jni.MethodId _notifyAll8;
        
        internal static global::net.sf.jni4net.jni.FieldId _intField9;
        
        internal static global::net.sf.jni4net.jni.FieldId _stringField10;
        
        internal static global::net.sf.jni4net.jni.FieldId _byteField11;
        
        internal static global::net.sf.jni4net.jni.FieldId _charField12;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor13;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public JavaStaticFields() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            env.NewObject(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, global::net.sf.jni4net.tested.JavaStaticFields.@__ctor13, this);
        }
        
        protected JavaStaticFields(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::net.sf.jni4net.tested.JavaStaticFields.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int intField {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticIntField(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, global::net.sf.jni4net.tested.JavaStaticFields._intField9);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/String;")]
        public static global::java.lang.String stringField {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.GetStaticObjectField(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, global::net.sf.jni4net.tested.JavaStaticFields._stringField10));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("B")]
        public static byte byteField {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticByteField(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, global::net.sf.jni4net.tested.JavaStaticFields._byteField11);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("C")]
        public static char charField {
            get {
                global::net.sf.jni4net.jni.JNIEnv env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return env.GetStaticCharField(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, global::net.sf.jni4net.tested.JavaStaticFields._charField12);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::net.sf.jni4net.tested.JavaStaticFields.staticClass = staticClass;
            global::net.sf.jni4net.tested.JavaStaticFields._wait0 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "wait", "()V");
            global::net.sf.jni4net.tested.JavaStaticFields._wait1 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "wait", "(JI)V");
            global::net.sf.jni4net.tested.JavaStaticFields._wait2 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "wait", "(J)V");
            global::net.sf.jni4net.tested.JavaStaticFields._hashCode3 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "hashCode", "()I");
            global::net.sf.jni4net.tested.JavaStaticFields._getClass4 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "getClass", "()Ljava/lang/Class;");
            global::net.sf.jni4net.tested.JavaStaticFields._equals5 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::net.sf.jni4net.tested.JavaStaticFields._toString6 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "toString", "()Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaStaticFields._notify7 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "notify", "()V");
            global::net.sf.jni4net.tested.JavaStaticFields._notifyAll8 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "notifyAll", "()V");
            global::net.sf.jni4net.tested.JavaStaticFields._intField9 = env.GetStaticFieldID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "intField", "I");
            global::net.sf.jni4net.tested.JavaStaticFields._stringField10 = env.GetStaticFieldID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "stringField", "Ljava/lang/String;");
            global::net.sf.jni4net.tested.JavaStaticFields._byteField11 = env.GetStaticFieldID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "byteField", "B");
            global::net.sf.jni4net.tested.JavaStaticFields._charField12 = env.GetStaticFieldID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "charField", "C");
            global::net.sf.jni4net.tested.JavaStaticFields.@__ctor13 = env.GetMethodID(global::net.sf.jni4net.tested.JavaStaticFields.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void wait() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._wait0);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)V")]
        public void wait(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._wait1, new global::net.sf.jni4net.jni.Value(par0), new global::net.sf.jni4net.jni.Value(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public void wait(long par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._wait2, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        public virtual int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._hashCode3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        public global::java.lang.Class getClass() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._getClass4));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        public virtual bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._equals5, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._toString6));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notify() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._notify7);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public void notifyAll() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            env.CallVoidMethod(this, global::net.sf.jni4net.tested.JavaStaticFields._notifyAll8);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::net.sf.jni4net.tested.JavaStaticFields(env);
            }
        }
    }
    #endregion
}
