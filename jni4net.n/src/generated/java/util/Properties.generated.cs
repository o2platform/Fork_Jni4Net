//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Properties : global::java.util.Hashtable {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setProperty0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getProperty1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getProperty2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_load3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_list4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_list5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_loadFromXML6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_propertyNames7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_save8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_store9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_storeToXML10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_storeToXML11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorProperties12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorProperties13;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Properties;)V")]
        public Properties(global::java.util.Properties par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::java.util.Properties.staticClass, global::java.util.Properties.j4n__ctorProperties12, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public Properties() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::java.util.Properties.staticClass, global::java.util.Properties.j4n__ctorProperties13, this);
            }
        }
        
        protected Properties(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.Properties.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.Properties.staticClass = @__class;
            global::java.util.Properties.j4n_setProperty0 = @__env.GetMethodID(global::java.util.Properties.staticClass, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
            global::java.util.Properties.j4n_getProperty1 = @__env.GetMethodID(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
            global::java.util.Properties.j4n_getProperty2 = @__env.GetMethodID(global::java.util.Properties.staticClass, "getProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
            global::java.util.Properties.j4n_load3 = @__env.GetMethodID(global::java.util.Properties.staticClass, "load", "(Ljava/io/InputStream;)V");
            global::java.util.Properties.j4n_list4 = @__env.GetMethodID(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintStream;)V");
            global::java.util.Properties.j4n_list5 = @__env.GetMethodID(global::java.util.Properties.staticClass, "list", "(Ljava/io/PrintWriter;)V");
            global::java.util.Properties.j4n_loadFromXML6 = @__env.GetMethodID(global::java.util.Properties.staticClass, "loadFromXML", "(Ljava/io/InputStream;)V");
            global::java.util.Properties.j4n_propertyNames7 = @__env.GetMethodID(global::java.util.Properties.staticClass, "propertyNames", "()Ljava/util/Enumeration;");
            global::java.util.Properties.j4n_save8 = @__env.GetMethodID(global::java.util.Properties.staticClass, "save", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            global::java.util.Properties.j4n_store9 = @__env.GetMethodID(global::java.util.Properties.staticClass, "store", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            global::java.util.Properties.j4n_storeToXML10 = @__env.GetMethodID(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V");
            global::java.util.Properties.j4n_storeToXML11 = @__env.GetMethodID(global::java.util.Properties.staticClass, "storeToXML", "(Ljava/io/OutputStream;Ljava/lang/String;)V");
            global::java.util.Properties.j4n__ctorProperties12 = @__env.GetMethodID(global::java.util.Properties.staticClass, "<init>", "(Ljava/util/Properties;)V");
            global::java.util.Properties.j4n__ctorProperties13 = @__env.GetMethodID(global::java.util.Properties.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;")]
        public virtual global::java.lang.Object setProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Properties.j4n_setProperty0, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/String;")]
        public virtual global::java.lang.String getProperty(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Properties.j4n_getProperty1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;")]
        public virtual global::java.lang.String getProperty(global::java.lang.String par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Properties.j4n_getProperty2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/InputStream;)V")]
        public virtual void load(global::java.io.InputStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_load3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintStream;)V")]
        public virtual void list(global::java.io.PrintStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_list4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/PrintWriter;)V")]
        public virtual void list(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_list5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/InputStream;)V")]
        public virtual void loadFromXML(global::java.io.InputStream par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_loadFromXML6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/util/Enumeration;")]
        public virtual global::java.util.Enumeration propertyNames() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.Properties.j4n_propertyNames7));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
        public virtual void save(global::java.io.OutputStream par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_save8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
        public virtual void store(global::java.io.OutputStream par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_store9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;Ljava/lang/String;Ljava/lang/String;)V")]
        public virtual void storeToXML(global::java.io.OutputStream par0, global::java.lang.String par1, global::java.lang.String par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_storeToXML10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;Ljava/lang/String;)V")]
        public virtual void storeToXML(global::java.io.OutputStream par0, global::java.lang.String par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::java.util.Properties.j4n_storeToXML11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.Properties(@__env);
            }
        }
    }
    #endregion
}
