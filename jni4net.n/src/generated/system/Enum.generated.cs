//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    
    
    #region Component Designer generated code 
    public unsafe partial class Enum_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.@__Enum.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Enum))]
    internal sealed unsafe partial class @__Enum : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__Enum(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.@__Enum.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Enum);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "CompareTo", "CompareTo0", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString1", "(Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetTypeCode", "GetTypeCode2", "()Lsystem/Enum;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToBoolean", "ToBoolean3", "(Lsystem/IFormatProvider;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToChar", "ToChar4", "(Lsystem/IFormatProvider;)C"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToSByte", "ToSByte5", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToByte", "ToByte6", "(Lsystem/IFormatProvider;)B"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt16", "ToInt167", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt16", "ToUInt168", "(Lsystem/IFormatProvider;)S"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt32", "ToInt329", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt32", "ToUInt3210", "(Lsystem/IFormatProvider;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToInt64", "ToInt6411", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToUInt64", "ToUInt6412", "(Lsystem/IFormatProvider;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToSingle", "ToSingle13", "(Lsystem/IFormatProvider;)F"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDouble", "ToDouble14", "(Lsystem/IFormatProvider;)D"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDecimal", "ToDecimal15", "(Lsystem/IFormatProvider;)Lsystem/Decimal;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToDateTime", "ToDateTime16", "(Lsystem/IFormatProvider;)Lsystem/DateTime;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString17", "(Lsystem/IFormatProvider;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToType", "ToType18", "(Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Parse", "Parse19", "(Lsystem/Type;Ljava/lang/String;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Parse", "Parse20", "(Lsystem/Type;Ljava/lang/String;Z)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetUnderlyingType", "GetUnderlyingType21", "(Lsystem/Type;)Lsystem/Type;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetValues", "GetValues22", "(Lsystem/Type;)Lsystem/Array;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetName", "GetName23", "(Lsystem/Type;Lsystem/Object;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetNames", "GetNames24", "(Lsystem/Type;)[Lsystem/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToObject", "ToObject25", "(Lsystem/Type;Lsystem/Object;)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "IsDefined", "IsDefined26", "(Lsystem/Type;Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Format", "Format27", "(Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToString", "ToString28", "(Ljava/lang/String;)Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToObject", "ToObject29", "(Lsystem/Type;B)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToObject", "ToObject30", "(Lsystem/Type;S)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToObject", "ToObject31", "(Lsystem/Type;I)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ToObject", "ToObject32", "(Lsystem/Type;J)Lsystem/Object;"));
            return methods;
        }
        
        private static int CompareTo0(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* obj) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IComparable)(real)).CompareTo(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, obj));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::java.lang.Object.JavaPtr* ToString1(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* format, global::java.lang.Object.JavaPtr* formatProvider) {
            // (Ljava/lang/String;Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/String;LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, ((global::System.IFormattable)(real)).ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, formatProvider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetTypeCode2(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj) {
            // ()Lsystem/Enum;
            // ()LSystem/TypeCode;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.IConvertible)(real)).GetTypeCode());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool ToBoolean3(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Z
            // (LSystem/IFormatProvider;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToBoolean(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static char ToChar4(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)C
            // (LSystem/IFormatProvider;)C
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToChar(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(char);
        }
        
        private static sbyte ToSByte5(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)LSystem/SByte;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((sbyte)(((global::System.IConvertible)(real)).ToSByte(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(sbyte);
        }
        
        private static byte ToByte6(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)B
            // (LSystem/IFormatProvider;)B
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToByte(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(byte);
        }
        
        private static short ToInt167(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)S
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToInt16(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(short);
        }
        
        private static ushort ToUInt168(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)S
            // (LSystem/IFormatProvider;)LSystem/UInt16;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((ushort)(((global::System.IConvertible)(real)).ToUInt16(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(ushort);
        }
        
        private static int ToInt329(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToInt32(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static uint ToUInt3210(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)I
            // (LSystem/IFormatProvider;)LSystem/UInt32;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((uint)(((global::System.IConvertible)(real)).ToUInt32(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(uint);
        }
        
        private static long ToInt6411(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)J
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToInt64(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static ulong ToUInt6412(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)J
            // (LSystem/IFormatProvider;)LSystem/UInt64;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((ulong)(((global::System.IConvertible)(real)).ToUInt64(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider))));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(ulong);
        }
        
        private static float ToSingle13(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)F
            // (LSystem/IFormatProvider;)F
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToSingle(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(float);
        }
        
        private static double ToDouble14(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)D
            // (LSystem/IFormatProvider;)D
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return ((global::System.IConvertible)(real)).ToDouble(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(double);
        }
        
        private static global::java.lang.Object.JavaPtr* ToDecimal15(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Lsystem/Decimal;
            // (LSystem/IFormatProvider;)LSystem/Decimal;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.IConvertible)(real)).ToDecimal(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToDateTime16(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Lsystem/DateTime;
            // (LSystem/IFormatProvider;)LSystem/DateTime;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.IConvertible)(real)).ToDateTime(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToString17(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/IFormatProvider;)Ljava/lang/String;
            // (LSystem/IFormatProvider;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, ((global::System.IConvertible)(real)).ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToType18(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* conversionType, global::java.lang.Object.JavaPtr* provider) {
            // (Lsystem/Type;Lsystem/IFormatProvider;)Lsystem/Object;
            // (LSystem/Type;LSystem/IFormatProvider;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, ((global::System.IConvertible)(real)).ToType(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, conversionType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IFormatProvider>(__env, provider)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Parse19(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value) {
            // (Lsystem/Type;Ljava/lang/String;)Lsystem/Object;
            // (LSystem/Type;LSystem/String;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.Parse(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, value)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* Parse20(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value, bool ignoreCase) {
            // (Lsystem/Type;Ljava/lang/String;Z)Lsystem/Object;
            // (LSystem/Type;LSystem/String;Z)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.Parse(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, value), ignoreCase));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetUnderlyingType21(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType) {
            // (Lsystem/Type;)Lsystem/Type;
            // (LSystem/Type;)LSystem/Type;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.GetUnderlyingType(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetValues22(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType) {
            // (Lsystem/Type;)Lsystem/Array;
            // (LSystem/Type;)LSystem/Array;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.GetValues(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetName23(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value) {
            // (Lsystem/Type;Lsystem/Object;)Ljava/lang/String;
            // (LSystem/Type;LSystem/Object;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, global::System.Enum.GetName(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, value)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* GetNames24(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType) {
            // (Lsystem/Type;)[Lsystem/String;
            // (LSystem/Type;)[LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.GetNames(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToObject25(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value) {
            // (Lsystem/Type;Lsystem/Object;)Lsystem/Object;
            // (LSystem/Type;LSystem/Object;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, value)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static bool IsDefined26(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value) {
            // (Lsystem/Type;Lsystem/Object;)Z
            // (LSystem/Type;LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::System.Enum.IsDefined(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::java.lang.Object.JavaPtr* Format27(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, global::java.lang.Object.JavaPtr* value, global::java.lang.Object.JavaPtr* format) {
            // (Lsystem/Type;Lsystem/Object;Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/Type;LSystem/Object;LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, global::System.Enum.Format(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Object>(__env, value), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToString28(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Object.JavaPtr* @__obj, global::java.lang.Object.JavaPtr* format) {
            // (Ljava/lang/String;)Ljava/lang/String;
            // (LSystem/String;)LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            global::System.Enum real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Enum>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.ToString(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, format)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToObject29(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, sbyte value) {
            // (Lsystem/Type;B)Lsystem/Object;
            // (LSystem/Type;LSystem/SByte;)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToObject30(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, short value) {
            // (Lsystem/Type;S)Lsystem/Object;
            // (LSystem/Type;S)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToObject31(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, int value) {
            // (Lsystem/Type;I)Lsystem/Object;
            // (LSystem/Type;I)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        private static global::java.lang.Object.JavaPtr* ToObject32(global::net.sf.jni4net.jni.JNIEnv.JavaPtr* @__envi, global::java.lang.Class.JavaPtr* @__clazz, global::java.lang.Object.JavaPtr* enumType, long value) {
            // (Lsystem/Type;J)Lsystem/Object;
            // (LSystem/Type;J)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = (*@__envi).Wrap();
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.Enum.ToObject(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Type>(__env, enumType), value));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::java.lang.Object.JavaPtr*);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.@__Enum(env);
            }
        }
    }
    #endregion
}
