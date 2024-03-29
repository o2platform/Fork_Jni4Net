/* Copyright (C) 2009 by Pavel Savara
This file is part of of jni4net - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

package net.sf.jni4net.test;

import net.sf.jni4net.Bridge;
import net.sf.jni4net.Out;
import net.sf.jni4net.inj.INJException;
import net.sf.jni4net.tested.*;
import org.junit.BeforeClass;
import org.junit.Test;
import org.junit.Assert;
import system.*;
import system.Object;
import system.reflection.Assembly;

import java.io.File;
import java.io.IOException;
import java.lang.String;

import static org.hamcrest.CoreMatchers.*;

public class TestClr {

	@BeforeClass
	public static void setup() throws IOException {
		//Bridge.setVerbose(true);
		//Bridge.setDebug(true);
		Bridge.init(new File("../jni4net.tested.n/target"));
		final File path = new File("../jni4net.tested.n/target/jni4net.tested.n-" + Bridge.getVersion() + ".dll").getCanonicalFile();
		Bridge.LoadAndRegisterAssemblyFrom(path);
	}


	@Test
	public void testClrReflection() throws IOException {
		JavaToClrReflection.reflect();
	}

	@Test()
	public void testNoException() {
		ClrException.NoException();
	}

    @Test()
    public void testExceptionEqals() {
        NullReferenceException nre=new NullReferenceException("test");
        NullReferenceException nre2=new NullReferenceException("test2");

        Assert.assertTrue(nre.equals(nre));
        Assert.assertFalse(nre.equals(nre2));
    }

	@Test(expected = NullReferenceException.class)
	public void testException() {
		ClrException.ThrowBack();
	}

	@Test()
	public void testPrimitiveTypes() {
		JavaCallBack.callBackException();
	}

	@Test()
	public void testExceptionType() {
		JavaCallBack.callBackException();
	}

	@Test()
	public void testCtor() {
		StaticMethods sm=new StaticMethods(); 
	}

	@Test()
	public void testWrap() {
		String s="sdfs";
		system.Object object = Bridge.wrapJVM(s);
		String res=Bridge.unwrapJVM(object);
		Assert.assertThat(res, equalTo(s));
	}

	@Test(expected = INJException.class)
	public void testWrapCant() {
		system.String s=new system.String("afsadf");
		Bridge.wrapJVM(s);
	}

	@Test(expected = INJException.class)
	public void testWrapCant2() {
		system.String s=new system.String("afsadf");
		Bridge.unwrapJVM(s);
	}

	@Test()
	public void testCast() {
		CInterfacesHelper he=new CInterfacesHelper();
		final Object object = he.CWithJavaInterfaceUnreg(1);
		final Object object2 = he.CWithJavaInterfaceUnreg(2);
		final Runnable runnable = Bridge.cast(object, Runnable.class);
		final Comparable comparable = Bridge.cast(object, Comparable.class);
		runnable.run();
		Assert.assertThat(comparable.compareTo(object2), equalTo(0));
	}

	@Test()
	public void testString() {
		String s="ahoj";
		system.String ss=new system.String(s);
		Assert.assertThat(ss.toString(), equalTo(s));		
	}

	@Test()
	public void testCWithJavaInterface() {
		int res= JavaCallBack.callBackComparison();
		Assert.assertThat(res, is(1));
	}

	@Test()
	public void testJWithClrInterface() {
		int res= JavaCallBack.callBackComparison2();
		Assert.assertThat(res, is(1));
	}

	@Test()
	public void testJWithClrInterfaceUnreg() {
		int res= JavaCallBack.callBackComparison3();
		Assert.assertThat(res, is(1));
	}

	//SLOW @Test()
	public void testGarbage() {
		long[] longs;
		for(int i=0;i<100;i++){
			inner();
			System.gc();
			System.gc();
			System.gc();
			System.gc();
		}
	}

	private void inner() {
		Type type = system.Console.typeof();
		Assembly assembly = type.getAssembly();
		//system.Console.WriteLine(assembly.getFullName());
		type=null;
		assembly=null;
	}

    @Test()
    public void outParam() {
        Out<DateTime> dt=new Out<DateTime>();
        if (DateTime.TryParse("2009-08-28",dt)){
            System.out.println(dt);
        }
        Assert.assertThat(dt.getValue().getYear(), is(2009));
    }

    @Test()
    public void testDelegatePtr() {
        final CIfcImpl ici=new CIfcImpl();
        final TestDelegate impl = new TestDelegate() {
            public int j;
            public String toString(){
                return ""+j;
            }
            public Object Invoke(int i, String s) {
                ici.setintProp(ici.getintProp()+1);
                j++;
                return Bridge.convert(s + i);
            }
        };
        ici.setfcePtr(impl);
        Assert.assertThat(ici.RunPtr(), is((Object)Bridge.convert("ahoj1")));

        final TestDelegate testDelegate = ici.getfcePtr();

        final system.Object object = ici.getfcePtr().Invoke(6, "nazdar");
        Assert.assertThat(object.ToString(), equalTo ("nazdar6"));

        Assert.assertThat(ici.getintProp(), is (2));
        Assert.assertThat(impl.toString(), is ("2"));



    }

    @Test()
    public void testDelegateEvent() {
        CIfcImpl ici=new CIfcImpl();
        ici.addEnvDispatcher(new TestDelegate() {
            public system.Object Invoke(int i, java.lang.String s) {
                return Bridge.convert(s+i);
            }
        });
        Assert.assertThat(ici.RunEvnt(), is((Object)Bridge.convert("ahoj2")));
    }
}