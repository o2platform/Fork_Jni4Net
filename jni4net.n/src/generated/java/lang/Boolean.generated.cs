//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Boolean : global::java.lang.Object, global::java.io.Serializable, global::java.lang.Comparable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getBoolean2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_toString3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_valueOf5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_booleanValue6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_parseBoolean7;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_TRUE8;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_FALSE9;
        
        internal static global::net.sf.jni4net.jni.FieldId j4n_TYPE10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorBoolean11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorBoolean12;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Boolean(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n__ctorBoolean11, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public Boolean(bool par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n__ctorBoolean12, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        protected Boolean(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Boolean.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Boolean;")]
        public static global::java.lang.Boolean TRUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Boolean>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_TRUE8));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Boolean;")]
        public static global::java.lang.Boolean FALSE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Boolean>(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_FALSE9));
            }
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_TYPE10));
            }
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Boolean.staticClass = @__class;
            global::java.lang.Boolean.j4n_compareTo0 = @__env.GetMethodID(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Boolean.j4n_compareTo1 = @__env.GetMethodID(global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I");
            global::java.lang.Boolean.j4n_getBoolean2 = @__env.GetStaticMethodID(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
            global::java.lang.Boolean.j4n_toString3 = @__env.GetStaticMethodID(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
            global::java.lang.Boolean.j4n_valueOf4 = @__env.GetStaticMethodID(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
            global::java.lang.Boolean.j4n_valueOf5 = @__env.GetStaticMethodID(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
            global::java.lang.Boolean.j4n_booleanValue6 = @__env.GetMethodID(global::java.lang.Boolean.staticClass, "booleanValue", "()Z");
            global::java.lang.Boolean.j4n_parseBoolean7 = @__env.GetStaticMethodID(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
            global::java.lang.Boolean.j4n_TRUE8 = @__env.GetStaticFieldID(global::java.lang.Boolean.staticClass, "TRUE", "Ljava/lang/Boolean;");
            global::java.lang.Boolean.j4n_FALSE9 = @__env.GetStaticFieldID(global::java.lang.Boolean.staticClass, "FALSE", "Ljava/lang/Boolean;");
            global::java.lang.Boolean.j4n_TYPE10 = @__env.GetStaticFieldID(global::java.lang.Boolean.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Boolean.j4n__ctorBoolean11 = @__env.GetMethodID(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.lang.Boolean.j4n__ctorBoolean12 = @__env.GetMethodID(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Boolean.j4n_compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Boolean;)I")]
        public virtual int compareTo(global::java.lang.Boolean par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Boolean.j4n_compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Z")]
        public static bool getBoolean(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_getBoolean2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Ljava/lang/String;")]
        public static global::java.lang.String toString(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_toString3, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)Ljava/lang/Boolean;")]
        public static global::java.lang.Boolean valueOf(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Boolean>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_valueOf4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Boolean;")]
        public static global::java.lang.Boolean valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Boolean>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_valueOf5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool booleanValue() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return ((bool)(@__env.CallBooleanMethod(this, global::java.lang.Boolean.j4n_booleanValue6)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Z")]
        public static bool parseBoolean(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return ((bool)(@__env.CallStaticBooleanMethod(global::java.lang.Boolean.staticClass, global::java.lang.Boolean.j4n_parseBoolean7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Boolean(@__env);
            }
        }
    }
    #endregion
}
