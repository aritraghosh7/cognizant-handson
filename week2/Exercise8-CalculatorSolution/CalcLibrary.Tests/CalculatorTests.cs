using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void Add_WhenCalled_ReturnsSum(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TearDown]
        public void Cleanup()
        {
            // Optional cleanup code
        }
    }
}
