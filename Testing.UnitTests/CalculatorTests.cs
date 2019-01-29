using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            var calculator = new Calculator();
            var result = calculator.Add(5, 5);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            var calculator = new Calculator();
            var result = calculator.Subtract(2, 2);
            Assert.AreEqual(0, result);
            result = calculator.Subtract(3, 2);
            Assert.AreEqual(1, result);
            result = calculator.Subtract(-2, 2);
            Assert.AreEqual(-4, result);
        }
    }
}
