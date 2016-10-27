using Xunit;
using AmbiguousReferenceTest.ANamespace;

namespace AmbiguousReferenceTest.Tests
{
	public class RuntimeErrorTest
	{
		[Fact]
		public void ItShouldNotThrowAnException()
		{
			var classA = new ClassA();
			classA.SomeLongMethod(0, "", 1);
		}
	}
}