//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace java.lang.annotation {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface Annotation {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()I")]
        int hashCode();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/Object;)Z")]
        bool equals(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        global::java.lang.String toString();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/Class;")]
        global::java.lang.Class annotationType();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class Annotation_ {
        
        public new static global::java.lang.Class _class {
            get {
                return global::java.lang.annotation.@__Annotation.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute()]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::java.lang.annotation.Annotation))]
    internal sealed partial class @__Annotation : global::java.lang.Object, global::java.lang.annotation.Annotation {
        
        internal static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _hashCode0;
        
        internal static global::net.sf.jni4net.jni.MethodId _equals1;
        
        internal static global::net.sf.jni4net.jni.MethodId _toString2;
        
        internal static global::net.sf.jni4net.jni.MethodId _annotationType3;
        
        protected @__Annotation(global::net.sf.jni4net.jni.JNIEnv env) : 
                base(env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv env, java.lang.Class staticClass) {
            global::java.lang.annotation.@__Annotation.staticClass = staticClass;
            global::java.lang.annotation.@__Annotation._hashCode0 = env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "hashCode", "()I");
            global::java.lang.annotation.@__Annotation._equals1 = env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "equals", "(Ljava/lang/Object;)Z");
            global::java.lang.annotation.@__Annotation._toString2 = env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "toString", "()Ljava/lang/String;");
            global::java.lang.annotation.@__Annotation._annotationType3 = env.GetMethodID(global::java.lang.annotation.@__Annotation.staticClass, "annotationType", "()Ljava/lang/Class;");
        }
        
        public int hashCode() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallIntMethod(this, global::java.lang.annotation.@__Annotation._hashCode0);
        }
        
        public bool equals(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return env.CallBooleanMethod(this, global::java.lang.annotation.@__Annotation._equals1, new global::net.sf.jni4net.jni.Value(par0));
        }
        
        public global::java.lang.String toString() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.String>(env.CallObjectMethod(this, global::java.lang.annotation.@__Annotation._toString2));
        }
        
        public global::java.lang.Class annotationType() {
            global::net.sf.jni4net.jni.JNIEnv env = this.Env;
            return global::net.sf.jni4net.Bridge.ToCLR<global::java.lang.Class>(env.CallObjectMethod(this, global::java.lang.annotation.@__Annotation._annotationType3));
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv env, global::java.lang.Class clazz) {
            global::System.Type type = typeof(__Annotation);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "hashCode", "hashCode0", "()I"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "equals", "equals1", "(Ljava/lang/Object;)Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "toString", "toString2", "()Ljava/lang/String;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(type, "annotationType", "annotationType3", "()Ljava/lang/Class;"));
            return methods;
        }
        
        private static int hashCode0(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()I
            // ()I
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.annotation.Annotation real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.annotation.Annotation>(__env, @__obj);
            return real.hashCode();
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(int);
        }
        
        private static bool equals1(global::System.IntPtr @__envi, global::System.IntPtr @__obj, global::System.IntPtr par0) {
            // (Ljava/lang/Object;)Z
            // (Ljava/lang/Object;)Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.annotation.Annotation real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.annotation.Annotation>(__env, @__obj);
            return real.equals(global::net.sf.jni4net.utils.JavaProxiesMap.Wrap<global::java.lang.Object>(__env, par0));
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(bool);
        }
        
        private static global::System.IntPtr toString2(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/String;
            // ()Ljava/lang/String;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.annotation.Annotation real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.annotation.Annotation>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.toString());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        private static global::System.IntPtr annotationType3(global::System.IntPtr @__envi, global::System.IntPtr @__obj) {
            // ()Ljava/lang/Class;
            // ()Ljava/lang/Class;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envi);
            try {
            global::java.lang.annotation.Annotation real = global::net.sf.jni4net.utils.ClrProxiesMap.ToClr<global::java.lang.annotation.Annotation>(__env, @__obj);
            return global::net.sf.jni4net.utils.ClrProxiesMap.WrapClr(@__env, real.annotationType());
            }catch (global::System.Exception ex){__env.ThrowExisting(ex);}
            return default(global::System.IntPtr);
        }
        
        internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJavaProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv env) {
                return new global::java.lang.annotation.@__Annotation(env);
            }
        }
    }
    #endregion
}
