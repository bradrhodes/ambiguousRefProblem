using System;
using System.Threading;
using AmbiguousReferenceTest.CNamespace;
using ClassB = AmbiguousReferenceTest.BNamespace.ClassB;

namespace AmbiguousReferenceTest.ANamespace
{
	public class ClassA
	{
		public void DoSomething()
		{
			var b = new ClassB();
			b.DoSomethingB();
		}

		public void SomeLongMethod(int var1, string var2, int var3)
		{
			var c = new ClassC();
			c.DoThingC();

			var b = new ClassB();
			b.DoSomethingB();
		}
	}
}