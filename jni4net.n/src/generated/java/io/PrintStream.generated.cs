//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.io {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class PrintStream : global::java.io.FilterOutputStream, global::java.lang.Appendable, global::java.io.Closeable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _append0;
        
        internal static global::net.sf.jni4net.jni.MethodId _append1;
        
        internal static global::net.sf.jni4net.jni.MethodId _append2;
        
        internal static global::net.sf.jni4net.jni.MethodId _close3;
        
        internal static global::net.sf.jni4net.jni.MethodId _println4;
        
        internal static global::net.sf.jni4net.jni.MethodId _println5;
        
        internal static global::net.sf.jni4net.jni.MethodId _println6;
        
        internal static global::net.sf.jni4net.jni.MethodId _println7;
        
        internal static global::net.sf.jni4net.jni.MethodId _println8;
        
        internal static global::net.sf.jni4net.jni.MethodId _println9;
        
        internal static global::net.sf.jni4net.jni.MethodId _println10;
        
        internal static global::net.sf.jni4net.jni.MethodId _println11;
        
        internal static global::net.sf.jni4net.jni.MethodId _println12;
        
        internal static global::net.sf.jni4net.jni.MethodId _println13;
        
        internal static global::net.sf.jni4net.jni.MethodId _format14;
        
        internal static global::net.sf.jni4net.jni.MethodId _format15;
        
        internal static global::net.sf.jni4net.jni.MethodId _print16;
        
        internal static global::net.sf.jni4net.jni.MethodId _print17;
        
        internal static global::net.sf.jni4net.jni.MethodId _print18;
        
        internal static global::net.sf.jni4net.jni.MethodId _print19;
        
        internal static global::net.sf.jni4net.jni.MethodId _print20;
        
        internal static global::net.sf.jni4net.jni.MethodId _print21;
        
        internal static global::net.sf.jni4net.jni.MethodId _print22;
        
        internal static global::net.sf.jni4net.jni.MethodId _print23;
        
        internal static global::net.sf.jni4net.jni.MethodId _print24;
        
        internal static global::net.sf.jni4net.jni.MethodId _checkError25;
        
        internal static global::net.sf.jni4net.jni.MethodId _printf26;
        
        internal static global::net.sf.jni4net.jni.MethodId _printf27;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor28;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor29;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor30;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor31;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor32;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor33;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor34;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)V")]
        public PrintStream(global::java.io.File par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor28, this, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.io.File>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;Z)V")]
        public PrintStream(global::java.io.OutputStream par0, bool par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor29, this, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.io.OutputStream>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;ZLjava/lang/String;)V")]
        public PrintStream(global::java.io.OutputStream par0, bool par1, global::java.lang.String par2) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor30, this, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.io.OutputStream>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par2));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public PrintStream(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor31, this, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/String;)V")]
        public PrintStream(global::java.lang.String par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor32, this, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Ljava/lang/String;)V")]
        public PrintStream(global::java.io.File par0, global::java.lang.String par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor33, this, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.io.File>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par1));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/OutputStream;)V")]
        public PrintStream(global::java.io.OutputStream par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.io.PrintStream.staticClass, global::java.io.PrintStream.@__ctor34, this, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.io.OutputStream>(@__env, par0));
        }
        
        protected PrintStream(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.io.PrintStream.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.io.PrintStream.staticClass = @__class;
            global::java.io.PrintStream._append0 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "append", "(C)Ljava/lang/Appendable;");
            global::java.io.PrintStream._append1 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;)Ljava/lang/Appendable;");
            global::java.io.PrintStream._append2 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "append", "(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;");
            global::java.io.PrintStream._close3 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "close", "()V");
            global::java.io.PrintStream._println4 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(Z)V");
            global::java.io.PrintStream._println5 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(C)V");
            global::java.io.PrintStream._println6 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(I)V");
            global::java.io.PrintStream._println7 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "()V");
            global::java.io.PrintStream._println8 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(J)V");
            global::java.io.PrintStream._println9 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/Object;)V");
            global::java.io.PrintStream._println10 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(Ljava/lang/String;)V");
            global::java.io.PrintStream._println11 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "([C)V");
            global::java.io.PrintStream._println12 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(D)V");
            global::java.io.PrintStream._println13 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "println", "(F)V");
            global::java.io.PrintStream._format14 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "format", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
            global::java.io.PrintStream._format15 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
            global::java.io.PrintStream._print16 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(I)V");
            global::java.io.PrintStream._print17 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(J)V");
            global::java.io.PrintStream._print18 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/Object;)V");
            global::java.io.PrintStream._print19 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(Ljava/lang/String;)V");
            global::java.io.PrintStream._print20 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(F)V");
            global::java.io.PrintStream._print21 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "([C)V");
            global::java.io.PrintStream._print22 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(Z)V");
            global::java.io.PrintStream._print23 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(C)V");
            global::java.io.PrintStream._print24 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "print", "(D)V");
            global::java.io.PrintStream._checkError25 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "checkError", "()Z");
            global::java.io.PrintStream._printf26 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "printf", "(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
            global::java.io.PrintStream._printf27 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "printf", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;");
            global::java.io.PrintStream.@__ctor28 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;)V");
            global::java.io.PrintStream.@__ctor29 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;Z)V");
            global::java.io.PrintStream.@__ctor30 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;ZLjava/lang/String;)V");
            global::java.io.PrintStream.@__ctor31 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;)V");
            global::java.io.PrintStream.@__ctor32 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
            global::java.io.PrintStream.@__ctor33 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/File;Ljava/lang/String;)V");
            global::java.io.PrintStream.@__ctor34 = @__env.GetMethodID(global::java.io.PrintStream.staticClass, "<init>", "(Ljava/io/OutputStream;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(char par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._append0, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(global::java.lang.CharSequence par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._append1, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.lang.CharSequence>(@__env, par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/CharSequence;II)Ljava/lang/Appendable;")]
        public virtual global::java.lang.Appendable append(global::java.lang.CharSequence par0, int par1, int par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.lang.Appendable>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._append2, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.lang.CharSequence>(@__env, par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._close3);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public virtual void println(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)V")]
        public virtual void println(char par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void println(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void println() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println7);
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void println(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println8, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)V")]
        public virtual void println(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println9, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.lang.Object>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public virtual void println(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println10, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([C)V")]
        public virtual void println(char[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println11, global::net.sf.jni4net.utils.Convertor.ParArrayC2J<char[]>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)V")]
        public virtual void println(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(F)V")]
        public virtual void println(float par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._println13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;")]
        public virtual global::java.io.PrintStream format(global::java.lang.Object par0, global::java.lang.String par1, java.lang.Object[] par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.io.PrintStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._format14, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParArrayC2J<java.lang.Object[]>(@__env, par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;")]
        public virtual global::java.io.PrintStream format(global::java.lang.String par0, java.lang.Object[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.io.PrintStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._format15, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayC2J<java.lang.Object[]>(@__env, par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(I)V")]
        public virtual void print(int par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public virtual void print(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)V")]
        public virtual void print(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print18, global::net.sf.jni4net.utils.Convertor.ParSameC2J<global::java.lang.Object>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public virtual void print(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print19, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(F)V")]
        public virtual void print(float par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print20, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([C)V")]
        public virtual void print(char[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print21, global::net.sf.jni4net.utils.Convertor.ParArrayC2J<char[]>(@__env, par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public virtual void print(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print22, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(C)V")]
        public virtual void print(char par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print23, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(D)V")]
        public virtual void print(double par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.io.PrintStream._print24, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        public virtual bool checkError() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.io.PrintStream._checkError25)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Locale;Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;")]
        public virtual global::java.io.PrintStream printf(global::java.lang.Object par0, global::java.lang.String par1, java.lang.Object[] par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.io.PrintStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._printf26, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParArrayC2J<java.lang.Object[]>(@__env, par2)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;[Ljava/lang/Object;)Ljava/io/PrintStream;")]
        public virtual global::java.io.PrintStream printf(global::java.lang.String par0, java.lang.Object[] par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::java.io.PrintStream>(@__env, @__env.CallObjectMethodPtr(this, global::java.io.PrintStream._printf27, global::net.sf.jni4net.utils.Convertor.ParFinalCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParArrayC2J<java.lang.Object[]>(@__env, par1)));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.io.PrintStream(@__env);
            }
        }
    }
    #endregion
}
