//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.IO {
    
    
    #region Component Designer generated code 
    public partial class Stream_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.IO.@__Stream.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.IO.Stream))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.Stream))]
    internal sealed partial class @__Stream : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__Stream(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.IO.@__Stream.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Stream);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Dispose", "Dispose0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCanRead", "CanRead1", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCanSeek", "CanSeek2", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCanTimeout", "CanTimeout3", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getCanWrite", "CanWrite4", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getLength", "Length5", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getPosition", "Position6", "()J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setPosition", "Position7", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getReadTimeout", "ReadTimeout8", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setReadTimeout", "ReadTimeout9", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getWriteTimeout", "WriteTimeout10", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "setWriteTimeout", "WriteTimeout11", "(I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Close", "Close12", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Flush", "Flush13", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "EndRead", "EndRead14", "(Ljava/lang/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "EndWrite", "EndWrite15", "(Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Seek", "Seek16", "(JLsystem/Enum;)J"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "SetLength", "SetLength17", "(J)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Read", "Read18", "([BII)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "ReadByte", "ReadByte19", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Write", "Write20", "([BII)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "WriteByte", "WriteByte21", "(B)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Synchronized", "Synchronized22", "(Lsystem/io/Stream;)Lsystem/io/Stream;"));
            return methods;
        }
        
        private static void Dispose0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            ((global::System.IDisposable)(real)).Dispose();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static bool CanRead1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.CanRead;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool CanSeek2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.CanSeek;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool CanTimeout3(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.CanTimeout;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool CanWrite4(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.CanWrite;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static long Length5(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.Length;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static long Position6(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()J
            // ()J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.Position;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static void Position7(global::System.IntPtr @__envi, global::System.IntPtr @__obj, long value) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.Position = value;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int ReadTimeout8(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.ReadTimeout;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void ReadTimeout9(global::System.IntPtr @__envi, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.ReadTimeout = value;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int WriteTimeout10(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.WriteTimeout;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void WriteTimeout11(global::System.IntPtr @__envi, global::System.IntPtr @__obj, int value) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.WriteTimeout = value;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void Close12(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.Close();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void Flush13(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.Flush();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int EndRead14(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr asyncResult) {
            // (Ljava/lang/Object;)I
            // (LSystem/IAsyncResult;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.EndRead(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IAsyncResult>(__env, asyncResult));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void EndWrite15(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr asyncResult) {
            // (Ljava/lang/Object;)V
            // (LSystem/IAsyncResult;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.EndWrite(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IAsyncResult>(__env, asyncResult));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static long Seek16(global::System.IntPtr @__envi, global::System.IntPtr @__obj, long offset, global::System.IntPtr origin) {
            // (JLsystem/Enum;)J
            // (JLSystem/IO/SeekOrigin;)J
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.Seek(offset, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.SeekOrigin>(__env, origin));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(long);
        }
        
        private static void SetLength17(global::System.IntPtr @__envi, global::System.IntPtr @__obj, long value) {
            // (J)V
            // (J)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.SetLength(value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static int Read18(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr buffer, int offset, int count) {
            // ([BII)I
            // ([BII)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.Read(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Byte[]>(__env, buffer), offset, count);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static int ReadByte19(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            return real.ReadByte();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void Write20(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr buffer, int offset, int count) {
            // ([BII)V
            // ([BII)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.Write(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Byte[]>(__env, buffer), offset, count);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void WriteByte21(global::System.IntPtr @__envi, global::System.IntPtr @__obj, byte value) {
            // (B)V
            // (B)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.Stream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, @__obj);
            real.WriteByte(value);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::System.IntPtr Synchronized22(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr stream) {
            // (Lsystem/io/Stream;)Lsystem/io/Stream;
            // (LSystem/IO/Stream;)LSystem/IO/Stream;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, global::System.IO.Stream.Synchronized(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.Stream>(__env, stream)));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.IO.@__Stream(env);
            }
        }
    }
    #endregion
}
