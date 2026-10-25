using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -2, -3)]
        [TestCase(-5, 5, 0)]
        [TestCase(100, 250, 350)]
        public void Add_ReturnsSum(int a, int b, int expected)
        {
            Assert.That(Operations.Add(a, b), Is.EqualTo(expected));
        }
    }
}