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
    public unsafe partial class FileStream_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.IO.@__FileStream.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.IO.FileStream))]
    internal sealed unsafe partial class @__FileStream : global::java.lang.Object {
        
        internal static global::java.lang.Class staticClass;
        
        protected @__FileStream(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::System.IO.@__FileStream.staticClass = staticClass;
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__FileStream);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "isAsync", "IsAsync0", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getName", "Name1", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "GetAccessControl", "GetAccessControl2", "()Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "SetAccessControl", "SetAccessControl3", "(Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getHandle", "Handle4", "()Lsystem/ValueType;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "getSafeFileHandle", "SafeFileHandle5", "()Lsystem/IDisposable;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Lock", "Lock6", "(JJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "Unlock", "Unlock7", "(JJ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream0", "__ctorFileStream0", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream1", "__ctorFileStream1", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream2", "__ctorFileStream2", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream3", "__ctorFileStream3", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream4", "__ctorFileStream4", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;ILsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream5", "__ctorFileStream5", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;IZ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream6", "__ctorFileStream6", "(Lnet/sf/jni4net/inj/IClrProxy;Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsyste" +
                        "m/Enum;ILsystem/Enum;Ljava/lang/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream7", "__ctorFileStream7", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/ValueType;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream8", "__ctorFileStream8", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/ValueType;Lsystem/Enum;Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream9", "__ctorFileStream9", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/ValueType;Lsystem/Enum;ZI)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream10", "__ctorFileStream10", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/ValueType;Lsystem/Enum;ZIZ)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream11", "__ctorFileStream11", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/IDisposable;Lsystem/Enum;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream12", "__ctorFileStream12", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/IDisposable;Lsystem/Enum;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "__ctorFileStream13", "__ctorFileStream13", "(Lnet/sf/jni4net/inj/IClrProxy;Lsystem/IDisposable;Lsystem/Enum;IZ)V"));
            return methods;
        }
        
        private static bool IsAsync0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            return real.IsAsync;
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr Name1(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()LSystem/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.ConvertString(@__env, real.Name);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr GetAccessControl2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/Object;
            // ()LSystem/Security/AccessControl/FileSecurity;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.GetAccessControl());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void SetAccessControl3(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr fileSecurity) {
            // (Ljava/lang/Object;)V
            // (LSystem/Security/AccessControl/FileSecurity;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            real.SetAccessControl(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Security.AccessControl.FileSecurity>(__env, fileSecurity));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static global::System.IntPtr Handle4(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/ValueType;
            // ()LSystem/IntPtr;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            return ((global::System.IntPtr)(real.Handle));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr SafeFileHandle5(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Lsystem/IDisposable;
            // ()LMicrosoft/Win32/SafeHandles/SafeFileHandle;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.SafeFileHandle);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Lock6(global::System.IntPtr @__envi, global::System.IntPtr @__obj, long position, long length) {
            // (JJ)V
            // (JJ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            real.Lock(position, length);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void Unlock7(global::System.IntPtr @__envi, global::System.IntPtr @__obj, long position, long length) {
            // (JJ)V
            // (JJ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileStream>(__env, @__obj);
            real.Unlock(position, length);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream0(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode) {
            // (Ljava/lang/String;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream1(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream2(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileShare>(__env, share));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream3(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;I)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileShare>(__env, share), bufferSize);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream4(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize, global::System.IntPtr options) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;ILSystem/IO/FileOptions;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileShare>(__env, share), bufferSize, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileOptions>(__env, options));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream5(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr access, global::System.IntPtr share, int bufferSize, bool useAsync) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;IZ)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/IO/FileAccess;LSystem/IO/FileShare;IZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileShare>(__env, share), bufferSize, useAsync);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream6(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr path, global::System.IntPtr mode, global::System.IntPtr rights, global::System.IntPtr share, int bufferSize, global::System.IntPtr options, global::System.IntPtr fileSecurity) {
            // (Ljava/lang/String;Lsystem/Enum;Lsystem/Enum;Lsystem/Enum;ILsystem/Enum;Ljava/lang/Object;)V
            // (LSystem/String;LSystem/IO/FileMode;LSystem/Security/AccessControl/FileSystemRights;LSystem/IO/FileShare;ILSystem/IO/FileOptions;LSystem/Security/AccessControl/FileSecurity;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.String>(__env, path), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileMode>(__env, mode), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Security.AccessControl.FileSystemRights>(__env, rights), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileShare>(__env, share), bufferSize, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileOptions>(__env, options), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.Security.AccessControl.FileSecurity>(__env, fileSecurity));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream7(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access) {
            // (Lsystem/ValueType;Lsystem/Enum;)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream8(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access, bool ownsHandle) {
            // (Lsystem/ValueType;Lsystem/Enum;Z)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), ownsHandle);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream9(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access, bool ownsHandle, int bufferSize) {
            // (Lsystem/ValueType;Lsystem/Enum;ZI)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;ZI)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), ownsHandle, bufferSize);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream10(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access, bool ownsHandle, int bufferSize, bool isAsync) {
            // (Lsystem/ValueType;Lsystem/Enum;ZIZ)V
            // (LSystem/IntPtr;LSystem/IO/FileAccess;ZIZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(handle, global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), ownsHandle, bufferSize, isAsync);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream11(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access) {
            // (Lsystem/IDisposable;Lsystem/Enum;)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(__env, handle), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access));
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream12(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access, int bufferSize) {
            // (Lsystem/IDisposable;Lsystem/Enum;I)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(__env, handle), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), bufferSize);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        private static void @__ctorFileStream13(global::System.IntPtr @__envi, global::System.IntPtr @__clazz, global::System.IntPtr @__obj, global::System.IntPtr handle, global::System.IntPtr access, int bufferSize, bool isAsync) {
            // (Lsystem/IDisposable;Lsystem/Enum;IZ)V
            // (LMicrosoft/Win32/SafeHandles/SafeFileHandle;LSystem/IO/FileAccess;IZ)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::System.IO.FileStream real = new global::System.IO.FileStream(global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::Microsoft.Win32.SafeHandles.SafeFileHandle>(__env, handle), global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::System.IO.FileAccess>(__env, access), bufferSize, isAsync);
            global::net.sf.jni4net.utils.ClrProxiesMap.InitProxy(__env, __obj, real);
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::System.IO.@__FileStream(env);
            }
        }
    }
    #endregion
}
