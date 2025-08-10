using NUnit.Framework;
using MathLibrary;
using System;

namespace MathLibrary.Tests
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

        // 1. Parameterized subtraction tests
        [TestCase(10, 5, 5)]
        [TestCase(5, 10, -5)]
        [TestCase(0, 0, 0)]
        public void TestSubtract(int a, int b, int expected)
        {
            Assert.That(_calculator.Subtract(a, b), Is.EqualTo(expected));
        }

        // 2. Multiplication tests
        [TestCase(2, 3, 6)]
        [TestCase(-2, 3, -6)]
        [TestCase(0, 100, 0)]
        public void TestMultiply(int a, int b, int expected)
        {
            Assert.That(_calculator.Multiply(a, b), Is.EqualTo(expected));
        }

        // 3. Division including exception
        [TestCase(10, 2, 5)]
        [TestCase(100, 4, 25)]
        public void TestDivide(int a, int b, int expected)
        {
            Assert.That(_calculator.Divide(a, b), Is.EqualTo(expected));
        }

        [Test]
        public void TestDivideByZero()
        {
            try
            {
                _calculator.Divide(10, 0);
                Assert.Fail("Division by zero"); // If no exception, fail the test
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Cannot divide by zero"));
            }
        }

        // 4. Test void method (AllClear)
        [Test]
        public void TestAddAndClear()
        {
            _calculator.Add(3, 4);
            Assert.That(_calculator.GetResult, Is.EqualTo(7));

            _calculator.AllClear();
            Assert.That(_calculator.GetResult, Is.EqualTo(0));
        }
    }
}
