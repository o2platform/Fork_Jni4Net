//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class Long : global::java.lang.Number, global::java.lang.Comparable {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo0;
        
        internal static global::net.sf.jni4net.jni.MethodId _compareTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong2;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong3;
        
        internal static global::net.sf.jni4net.jni.MethodId _getLong4;
        
        internal static global::net.sf.jni4net.jni.MethodId _toHexString5;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString6;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString7;
        
        internal static global::net.sf.jni4net.jni.MethodId _decode8;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf9;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf10;
        
        internal static global::net.sf.jni4net.jni.MethodId _valueOf11;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverse12;
        
        internal static global::net.sf.jni4net.jni.MethodId _reverseBytes13;
        
        internal static global::net.sf.jni4net.jni.MethodId _bitCount14;
        
        internal static global::net.sf.jni4net.jni.MethodId _highestOneBit15;
        
        internal static global::net.sf.jni4net.jni.MethodId _lowestOneBit16;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfLeadingZeros17;
        
        internal static global::net.sf.jni4net.jni.MethodId _numberOfTrailingZeros18;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateLeft19;
        
        internal static global::net.sf.jni4net.jni.MethodId _rotateRight20;
        
        internal static global::net.sf.jni4net.jni.MethodId _signum21;
        
        internal static global::net.sf.jni4net.jni.MethodId _toBinaryString22;
        
        internal static global::net.sf.jni4net.jni.MethodId _toOctalString23;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseLong24;
        
        internal static global::net.sf.jni4net.jni.MethodId _parseLong25;
        
        internal static global::net.sf.jni4net.jni.FieldId _MIN_VALUE26;
        
        internal static global::net.sf.jni4net.jni.FieldId _MAX_VALUE27;
        
        internal static global::net.sf.jni4net.jni.FieldId _TYPE28;
        
        internal static global::net.sf.jni4net.jni.FieldId _SIZE29;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor30;
        
        internal static global::net.sf.jni4net.jni.MethodId @__ctor31;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)V")]
        public Long(long par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Long.staticClass, global::java.lang.Long.@__ctor30, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)V")]
        public Long(global::java.lang.String par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            @__env.NewObject(global::java.lang.Long.staticClass, global::java.lang.Long.@__ctor31, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        protected Long(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.Long.staticClass;
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long MIN_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.lang.Long.staticClass, global::java.lang.Long._MIN_VALUE26)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("J")]
        public static long MAX_VALUE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((long)(@__env.GetStaticLongField(global::java.lang.Long.staticClass, global::java.lang.Long._MAX_VALUE27)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("Ljava/lang/Class;")]
        public static global::java.lang.Class TYPE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return global::net.sf.jni4net.utils.Convertor.StrongJ2CpClass(@__env, @__env.GetStaticObjectFieldPtr(global::java.lang.Long.staticClass, global::java.lang.Long._TYPE28));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("I")]
        public static int SIZE {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
                return ((int)(@__env.GetStaticIntField(global::java.lang.Long.staticClass, global::java.lang.Long._SIZE29)));
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.lang.Long.staticClass = @__class;
            global::java.lang.Long._compareTo0 = @__env.GetMethodID(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Object;)I");
            global::java.lang.Long._compareTo1 = @__env.GetMethodID(global::java.lang.Long.staticClass, "compareTo", "(Ljava/lang/Long;)I");
            global::java.lang.Long._getLong2 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;");
            global::java.lang.Long._getLong3 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;");
            global::java.lang.Long._getLong4 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "getLong", "(Ljava/lang/String;)Ljava/lang/Long;");
            global::java.lang.Long._toHexString5 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "toHexString", "(J)Ljava/lang/String;");
            global::java.lang.Long._toString6 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "toString", "(J)Ljava/lang/String;");
            global::java.lang.Long._toString7 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "toString", "(JI)Ljava/lang/String;");
            global::java.lang.Long._decode8 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "decode", "(Ljava/lang/String;)Ljava/lang/Long;");
            global::java.lang.Long._valueOf9 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "valueOf", "(J)Ljava/lang/Long;");
            global::java.lang.Long._valueOf10 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;");
            global::java.lang.Long._valueOf11 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;");
            global::java.lang.Long._reverse12 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "reverse", "(J)J");
            global::java.lang.Long._reverseBytes13 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "reverseBytes", "(J)J");
            global::java.lang.Long._bitCount14 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "bitCount", "(J)I");
            global::java.lang.Long._highestOneBit15 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "highestOneBit", "(J)J");
            global::java.lang.Long._lowestOneBit16 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "lowestOneBit", "(J)J");
            global::java.lang.Long._numberOfLeadingZeros17 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "numberOfLeadingZeros", "(J)I");
            global::java.lang.Long._numberOfTrailingZeros18 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "numberOfTrailingZeros", "(J)I");
            global::java.lang.Long._rotateLeft19 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "rotateLeft", "(JI)J");
            global::java.lang.Long._rotateRight20 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "rotateRight", "(JI)J");
            global::java.lang.Long._signum21 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "signum", "(J)I");
            global::java.lang.Long._toBinaryString22 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "toBinaryString", "(J)Ljava/lang/String;");
            global::java.lang.Long._toOctalString23 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "toOctalString", "(J)Ljava/lang/String;");
            global::java.lang.Long._parseLong24 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;)J");
            global::java.lang.Long._parseLong25 = @__env.GetStaticMethodID(global::java.lang.Long.staticClass, "parseLong", "(Ljava/lang/String;I)J");
            global::java.lang.Long._MIN_VALUE26 = @__env.GetStaticFieldID(global::java.lang.Long.staticClass, "MIN_VALUE", "J");
            global::java.lang.Long._MAX_VALUE27 = @__env.GetStaticFieldID(global::java.lang.Long.staticClass, "MAX_VALUE", "J");
            global::java.lang.Long._TYPE28 = @__env.GetStaticFieldID(global::java.lang.Long.staticClass, "TYPE", "Ljava/lang/Class;");
            global::java.lang.Long._SIZE29 = @__env.GetStaticFieldID(global::java.lang.Long.staticClass, "SIZE", "I");
            global::java.lang.Long.@__ctor30 = @__env.GetMethodID(global::java.lang.Long.staticClass, "<init>", "(J)V");
            global::java.lang.Long.@__ctor31 = @__env.GetMethodID(global::java.lang.Long.staticClass, "<init>", "(Ljava/lang/String;)V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)I")]
        public virtual int compareTo(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Long._compareTo0, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Long;)I")]
        public virtual int compareTo(global::java.lang.Long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.lang.Long._compareTo1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;")]
        public static global::java.lang.Long getLong(global::java.lang.String par0, global::java.lang.Long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._getLong2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;J)Ljava/lang/Long;")]
        public static global::java.lang.Long getLong(global::java.lang.String par0, long par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._getLong3, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Long;")]
        public static global::java.lang.Long getLong(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._getLong4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/String;")]
        public static global::java.lang.String toHexString(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._toHexString5, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/String;")]
        public static global::java.lang.String toString(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._toString6, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)Ljava/lang/String;")]
        public static global::java.lang.String toString(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._toString7, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Long;")]
        public static global::java.lang.Long decode(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._decode8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/Long;")]
        public static global::java.lang.Long valueOf(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._valueOf9, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)Ljava/lang/Long;")]
        public static global::java.lang.Long valueOf(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._valueOf10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)Ljava/lang/Long;")]
        public static global::java.lang.Long valueOf(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Long>(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._valueOf11, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)J")]
        public static long reverse(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._reverse12, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)J")]
        public static long reverseBytes(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._reverseBytes13, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)I")]
        public static int bitCount(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Long.staticClass, global::java.lang.Long._bitCount14, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)J")]
        public static long highestOneBit(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._highestOneBit15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)J")]
        public static long lowestOneBit(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._lowestOneBit16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)I")]
        public static int numberOfLeadingZeros(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Long.staticClass, global::java.lang.Long._numberOfLeadingZeros17, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)I")]
        public static int numberOfTrailingZeros(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Long.staticClass, global::java.lang.Long._numberOfTrailingZeros18, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)J")]
        public static long rotateLeft(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._rotateLeft19, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(JI)J")]
        public static long rotateRight(long par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._rotateRight20, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)I")]
        public static int signum(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((int)(@__env.CallStaticIntMethod(global::java.lang.Long.staticClass, global::java.lang.Long._signum21, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/String;")]
        public static global::java.lang.String toBinaryString(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._toBinaryString22, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(J)Ljava/lang/String;")]
        public static global::java.lang.String toOctalString(long par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallStaticObjectMethodPtr(global::java.lang.Long.staticClass, global::java.lang.Long._toOctalString23, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0)));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)J")]
        public static long parseLong(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._parseLong24, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;I)J")]
        public static long parseLong(global::java.lang.String par0, int par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            return ((long)(@__env.CallStaticLongMethod(global::java.lang.Long.staticClass, global::java.lang.Long._parseLong25, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1))));
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.ICJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.lang.Long(@__env);
            }
        }
    }
    #endregion
}
