using CalculatorImpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class SimpleCalculatorUnitTestsInvalid
    {
        [TestMethod]
        public void TestOverflowAdd()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MaxValue;
            int b = 10;

            // Act & Assert
            var output = Assert.ThrowsException<OverflowException>(() => calculator.Add(a, b));
        }

        [TestMethod]
        public void TestOverflowSubtract()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MinValue;
            int b = 10;

            // Act & Assert
            var output = Assert.ThrowsException<OverflowException>(() => calculator.Subtract(a, b));
        }

        [TestMethod]
        public void TestOverflowMultiply()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MaxValue;
            int b = 10;

            // Act & Assert
            var output = Assert.ThrowsException<OverflowException>(() => calculator.Multiply(a, b));
        }

        [TestMethod]
        public void TestDivideByZeroDivide()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = 50;
            int b = 0;

            // Act & Assert
            var output = Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}
