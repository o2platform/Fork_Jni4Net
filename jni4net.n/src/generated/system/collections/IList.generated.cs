//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Collections {
    
    
    #region Component Designer generated code 
    public partial class IList_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::System.Collections.@__IList.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::System.Collections.IList))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::System.Collections.IList))]
    internal sealed partial class @__IList : global::java.lang.Object, global::System.Collections.IList {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _GetEnumerator0;
        
        internal static global::net.sf.jni4net.jni.MethodId _CopyTo1;
        
        internal static global::net.sf.jni4net.jni.MethodId _Count2;
        
        internal static global::net.sf.jni4net.jni.MethodId _SyncRoot3;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsSynchronized4;
        
        internal static global::net.sf.jni4net.jni.MethodId _Item5;
        
        internal static global::net.sf.jni4net.jni.MethodId _Item6;
        
        internal static global::net.sf.jni4net.jni.MethodId _Add7;
        
        internal static global::net.sf.jni4net.jni.MethodId _Contains8;
        
        internal static global::net.sf.jni4net.jni.MethodId _Clear9;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsReadOnly10;
        
        internal static global::net.sf.jni4net.jni.MethodId _IsFixedSize11;
        
        internal static global::net.sf.jni4net.jni.MethodId _IndexOf12;
        
        internal static global::net.sf.jni4net.jni.MethodId _Insert13;
        
        internal static global::net.sf.jni4net.jni.MethodId _Remove14;
        
        internal static global::net.sf.jni4net.jni.MethodId _RemoveAt15;
        
        protected @__IList(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public int Count {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return @__env.CallIntMethod(this, global::System.Collections.@__IList._Count2);
            }
        }
        
        public object SyncRoot {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IList._SyncRoot3));
            }
        }
        
        public bool IsSynchronized {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return @__env.CallBooleanMethod(this, global::System.Collections.@__IList._IsSynchronized4);
            }
        }
        
        public object this[int index] {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IList._Item5, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, index)));
            }
            set {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                @__env.CallVoidMethod(this, global::System.Collections.@__IList._Item6, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, index), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
            }
        }
        
        public bool IsReadOnly {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return @__env.CallBooleanMethod(this, global::System.Collections.@__IList._IsReadOnly10);
            }
        }
        
        public bool IsFixedSize {
            get {
                global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
                return @__env.CallBooleanMethod(this, global::System.Collections.@__IList._IsFixedSize11);
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::System.Collections.@__IList.staticClass = @__class;
            global::System.Collections.@__IList._GetEnumerator0 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "GetEnumerator", "()Lsystem/collections/IEnumerator;");
            global::System.Collections.@__IList._CopyTo1 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "CopyTo", "(Lsystem/Array;I)V");
            global::System.Collections.@__IList._Count2 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "getCount", "()I");
            global::System.Collections.@__IList._SyncRoot3 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "getSyncRoot", "()Lsystem/Object;");
            global::System.Collections.@__IList._IsSynchronized4 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "isSynchronized", "()Z");
            global::System.Collections.@__IList._Item5 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "getItem", "(I)Lsystem/Object;");
            global::System.Collections.@__IList._Item6 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "setItem", "(ILsystem/Object;)V");
            global::System.Collections.@__IList._Add7 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "Add", "(Lsystem/Object;)I");
            global::System.Collections.@__IList._Contains8 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "Contains", "(Lsystem/Object;)Z");
            global::System.Collections.@__IList._Clear9 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "Clear", "()V");
            global::System.Collections.@__IList._IsReadOnly10 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "isReadOnly", "()Z");
            global::System.Collections.@__IList._IsFixedSize11 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "isFixedSize", "()Z");
            global::System.Collections.@__IList._IndexOf12 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "IndexOf", "(Lsystem/Object;)I");
            global::System.Collections.@__IList._Insert13 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "Insert", "(ILsystem/Object;)V");
            global::System.Collections.@__IList._Remove14 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "Remove", "(Lsystem/Object;)V");
            global::System.Collections.@__IList._RemoveAt15 = @__env.GetMethodID(global::System.Collections.@__IList.staticClass, "RemoveAt", "(I)V");
        }
        
        public global::System.Collections.IEnumerator GetEnumerator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IEnumerator>(@__env, @__env.CallObjectMethodPtr(this, global::System.Collections.@__IList._GetEnumerator0));
        }
        
        public void CopyTo(global::System.Array array, int index) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IList._CopyTo1, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, array), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, index));
        }
        
        public int Add(object value) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return @__env.CallIntMethod(this, global::System.Collections.@__IList._Add7, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
        }
        
        public bool Contains(object value) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return @__env.CallBooleanMethod(this, global::System.Collections.@__IList._Contains8, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
        }
        
        public void Clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IList._Clear9);
        }
        
        public int IndexOf(object value) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return @__env.CallIntMethod(this, global::System.Collections.@__IList._IndexOf12, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
        }
        
        public void Insert(int index, object value) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IList._Insert13, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, index), global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
        }
        
        public void Remove(object value) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IList._Remove14, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, value));
        }
        
        public void RemoveAt(int index) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::System.Collections.@__IList._RemoveAt15, global::net.sf.jni4net.utils.Convertor.ParamC2J(@__env, index));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IList);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "GetEnumerator", "GetEnumerator0", "()Lsystem/collections/IEnumerator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "CopyTo", "CopyTo1", "(Lsystem/Array;I)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getCount", "Count2", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getSyncRoot", "SyncRoot3", "()Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isSynchronized", "IsSynchronized4", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "getItem", "Item5", "(I)Lsystem/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setItem", "Item6", "(ILsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Add", "Add7", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Contains", "Contains8", "(Lsystem/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Clear", "Clear9", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isReadOnly", "IsReadOnly10", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isFixedSize", "IsFixedSize11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "IndexOf", "IndexOf12", "(Lsystem/Object;)I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Insert", "Insert13", "(ILsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "Remove", "Remove14", "(Lsystem/Object;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "RemoveAt", "RemoveAt15", "(I)V"));
            return methods;
        }
        
        private static global::System.IntPtr GetEnumerator0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/collections/IEnumerator;
            // ()LSystem/Collections/IEnumerator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<global::System.Collections.IEnumerator>(@__env, ((global::System.Collections.IEnumerable)(@__real)).GetEnumerator());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void CopyTo1(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr array, int index) {
            // (Lsystem/Array;I)V
            // (LSystem/Array;I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            ((global::System.Collections.ICollection)(@__real)).CopyTo(global::net.sf.jni4net.utils.Convertor.J2C<global::System.Array>(@__env, array), index);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static int Count2(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return ((global::System.Collections.ICollection)(@__real)).Count;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr SyncRoot3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Lsystem/Object;
            // ()LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, ((global::System.Collections.ICollection)(@__real)).SyncRoot);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool IsSynchronized4(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return ((global::System.Collections.ICollection)(@__real)).IsSynchronized;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr Item5(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int index) {
            // (I)Lsystem/Object;
            // (I)LSystem/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.C2J<object>(@__env, @__real[index]);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static void Item6(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int index, global::System.IntPtr value) {
            // (ILsystem/Object;)V
            // (ILSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            @__real[index] = global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static int Add7(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return @__real.Add(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static bool Contains8(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)Z
            // (LSystem/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return @__real.Contains(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static void Clear9(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            @__real.Clear();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static bool IsReadOnly10(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return @__real.IsReadOnly;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool IsFixedSize11(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return @__real.IsFixedSize;
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int IndexOf12(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)I
            // (LSystem/Object;)I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            return @__real.IndexOf(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static void Insert13(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int index, global::System.IntPtr value) {
            // (ILsystem/Object;)V
            // (ILSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            @__real.Insert(index, global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void Remove14(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr value) {
            // (Lsystem/Object;)V
            // (LSystem/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            @__real.Remove(global::net.sf.jni4net.utils.Convertor.J2C<object>(@__env, value));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static void RemoveAt15(global::System.IntPtr @__envp, global::System.IntPtr @__obj, int index) {
            // (I)V
            // (I)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::System.Collections.IList @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::System.Collections.IList>(@__env, @__obj);
            @__real.RemoveAt(index);
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::System.Collections.@__IList(@__env);
            }
        }
    }
    #endregion
}
