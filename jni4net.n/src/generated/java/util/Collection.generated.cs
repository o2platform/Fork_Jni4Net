//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.util {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Collection : global::java.lang.Iterable {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int hashCode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool add(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void clear();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool equals(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool contains(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        bool addAll(global::java.util.Collection par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int size();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Ljava/lang/Object;")]
        java.lang.Object[] toArray();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;")]
        java.lang.Object[] toArray(java.lang.Object[] par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool remove(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isEmpty();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        bool containsAll(global::java.util.Collection par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        bool removeAll(global::java.util.Collection par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/util/Collection;)Z")]
        bool retainAll(global::java.util.Collection par0);
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Collection_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.util.@__Collection.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::java.util.Collection))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.util.Collection))]
    internal sealed partial class @__Collection : global::java.lang.Object, global::java.util.Collection {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _iterator0;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode1;
        
        internal static global::net.sf.jni4net.jni.MethodId _add2;
        
        internal static global::net.sf.jni4net.jni.MethodId _clear3;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals4;
        
        internal static global::net.sf.jni4net.jni.MethodId _contains5;
        
        internal static global::net.sf.jni4net.jni.MethodId _addAll6;
        
        internal static global::net.sf.jni4net.jni.MethodId _size7;
        
        internal static global::net.sf.jni4net.jni.MethodId _toArray8;
        
        internal static global::net.sf.jni4net.jni.MethodId _toArray9;
        
        internal static global::net.sf.jni4net.jni.MethodId _remove10;
        
        internal static global::net.sf.jni4net.jni.MethodId _isEmpty11;
        
        internal static global::net.sf.jni4net.jni.MethodId _containsAll12;
        
        internal static global::net.sf.jni4net.jni.MethodId _removeAll13;
        
        internal static global::net.sf.jni4net.jni.MethodId _retainAll14;
        
        protected @__Collection(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::java.util.@__Collection.staticClass = @__class;
            global::java.util.@__Collection._iterator0 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "iterator", "()Ljava/util/Iterator;");
            global::java.util.@__Collection._hashCode1 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "hashCode", "()I");
            global::java.util.@__Collection._add2 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "add", "(Ljava/lang/Object;)Z");
            global::java.util.@__Collection._clear3 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "clear", "()V");
            global::java.util.@__Collection._equals4 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.util.@__Collection._contains5 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "contains", "(Ljava/lang/Object;)Z");
            global::java.util.@__Collection._addAll6 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "addAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__Collection._size7 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "size", "()I");
            global::java.util.@__Collection._toArray8 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "toArray", "()[Ljava/lang/Object;");
            global::java.util.@__Collection._toArray9 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
            global::java.util.@__Collection._remove10 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "remove", "(Ljava/lang/Object;)Z");
            global::java.util.@__Collection._isEmpty11 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "isEmpty", "()Z");
            global::java.util.@__Collection._containsAll12 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__Collection._removeAll13 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
            global::java.util.@__Collection._retainAll14 = @__env.GetMethodID(global::java.util.@__Collection.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
        }
        
        public global::java.util.Iterator iterator() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Iterator>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Collection._iterator0));
        }
        
        public int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.@__Collection._hashCode1)));
        }
        
        public bool add(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._add2, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        public void clear() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::java.util.@__Collection._clear3);
        }
        
        public bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._equals4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        public bool contains(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._contains5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        public bool addAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._addAll6, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, par0))));
        }
        
        public int size() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((int)(@__env.CallIntMethod(this, global::java.util.@__Collection._size7)));
        }
        
        public java.lang.Object[] toArray() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.lang.Object[]>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Collection._toArray8));
        }
        
        public java.lang.Object[] toArray(java.lang.Object[] par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.lang.Object[]>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.@__Collection._toArray9, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, par0)));
        }
        
        public bool remove(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._remove10, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0))));
        }
        
        public bool isEmpty() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._isEmpty11)));
        }
        
        public bool containsAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._containsAll12, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, par0))));
        }
        
        public bool removeAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._removeAll13, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, par0))));
        }
        
        public bool retainAll(global::java.util.Collection par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::java.util.@__Collection._retainAll14, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.util.Collection>(@__env, par0))));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__Collection);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "iterator", "iterator0", "()Ljava/util/Iterator;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "hashCode", "hashCode1", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "add", "add2", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "clear", "clear3", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "equals", "equals4", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "contains", "contains5", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "addAll", "addAll6", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "size", "size7", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "toArray", "toArray8", "()[Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "toArray", "toArray9", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "remove", "remove10", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isEmpty", "isEmpty11", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "containsAll", "containsAll12", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "removeAll", "removeAll13", "(Ljava/util/Collection;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "retainAll", "retainAll14", "(Ljava/util/Collection;)Z"));
            return methods;
        }
        
        private static global::System.IntPtr iterator0(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Ljava/util/Iterator;
            // ()Ljava/util/Iterator;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.FullC2J<global::java.util.Iterator>(@__env, ((global::java.lang.Iterable)(@__real)).iterator());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static int hashCode1(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((int)(@__real.hashCode()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static bool add2(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.add(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static void clear3(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            @__real.clear();
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
        }
        
        private static bool equals4(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.equals(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool contains5(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.contains(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool addAll6(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.addAll(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static int size7(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((int)(@__real.size()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static global::System.IntPtr toArray8(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()[Ljava/lang/Object;
            // ()[Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongCp2J(@__env, @__real.toArray());
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr toArray9(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // ([Ljava/lang/Object;)[Ljava/lang/Object;
            // ([Ljava/lang/Object;)[Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongCp2J(@__env, @__real.toArray(global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<java.lang.Object[]>(@__env, par0)));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static bool remove10(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.remove(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool isEmpty11(global::System.IntPtr @__envp, global::System.IntPtr @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.isEmpty()));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool containsAll12(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.containsAll(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool removeAll13(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.removeAll(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static bool retainAll14(global::System.IntPtr @__envp, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/util/Collection;)Z
            // (Ljava/util/Collection;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::java.util.Collection @__real = global::net.sf.jni4net.utils.Convertor.J2C<global::java.util.Collection>(@__env, @__obj);
            return ((bool)(@__real.retainAll(global::net.sf.jni4net.utils.Convertor.FullJ2C<global::java.util.Collection>(@__env, par0))));
            }catch (global::System.Exception ex){@__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::java.util.@__Collection(@__env);
            }
        }
    }
    #endregion
}
