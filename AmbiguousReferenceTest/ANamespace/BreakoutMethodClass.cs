using AmbiguousReferenceTest.CNamespace;
using ClassB = AmbiguousReferenceTest.BNamespace.ClassB;

namespace AmbiguousReferenceTest.ANamespace
{
	public class BreakoutMethodClass
	{
		private readonly int _var1;
		private readonly string _var2;
		private readonly int _var3;

		public BreakoutMethodClass(int var1, string var2, int var3)
		{
			_var1 = var1;
			_var2 = var2;
			_var3 = var3;
		}

		public void Run()
		{
			var c = new ClassC();
			c.DoThingC();

			var b = new ClassB();
			b.DoSomethingB();
			
		}
	}
}