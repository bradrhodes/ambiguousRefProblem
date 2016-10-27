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
			var breakout = new BreakoutMethodClass(var1, var2, var3);
			breakout.Run();
		}
	}
}