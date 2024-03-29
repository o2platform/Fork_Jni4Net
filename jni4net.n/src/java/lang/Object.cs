#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using net.sf.jni4net.jni;
using net.sf.jni4net.utils;

namespace java.lang
{
    public partial class Object : IJvmProxy
    {
        internal JniGlobalHandle jvmHandle;

        protected internal Object(JNIEnv env)
        {
        }

        protected JNIEnv Env
        {
            get { return JNIEnv.GetEnvForVm(jvmHandle.javaVM); }
        }

        #region Reference handling

        #region IJvmProxy Members

        JniGlobalHandle IJvmProxy.JvmHandle
        {
            get { return jvmHandle; }
        }

        void IJvmProxy.Init(JNIEnv env, JniLocalHandle obj)
        {
            jvmHandle = env.NewGlobalRef(obj);
            env.DeleteLocalRef(obj);
        }

        void IJvmProxy.Copy(JNIEnv env, JniGlobalHandle obj)
        {
            jvmHandle = obj;
        }


        #endregion

        #endregion

        public void Invoke(string method, string signature, params object[] args)
        {
            Env.CallVoidMethod(this, method, signature, args);
        }

        public TRes Invoke<TRes>(string method, string signature, params object[] args)
        {
            return Env.CallMethod<TRes>(this, method, signature, args);
        }

        public TRes GetFieldValue<TRes>(string fieldName, string signature)
        {
            return Env.GetField<TRes>(this, fieldName, signature);
        }

        public void SetFieldValue<T>(string fieldName, string signature, T value)
        {
            Env.SetField(this, fieldName, signature, value);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Object;
            if (other == null)
            {
                return false;
            }
            return equals(other);
        }

        public override int GetHashCode()
        {
            return hashCode();
        }

        public static bool operator ==(Object a, Object b)
        {
            if ((object) a == null && (object) b == null)
                return true;
            if ((object) a == null || (object) b == null)
                return false;
            return a.Env.IsSameObject(a, b);
        }

        public static bool operator !=(Object a, Object b)
        {
            if ((object) a == null && (object) b == null)
                return false;
            if ((object) a == null || (object) b == null)
                return true;
            return !a.Env.IsSameObject(a, b);
        }

        public override string ToString()
        {
            return toString();
        }
    }
}