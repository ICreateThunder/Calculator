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

            // Expect result to loop around (Two's Complement)
            int result = int.MinValue + 9;

            // Act
            var output = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(result, output);
        }

        [TestMethod]
        public void TestOverflowSubtract()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MinValue;
            int b = 10;

            // Expect result to loop around (Two's Complement)
            int result = int.MaxValue - 9;

            // Act
            var output = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(result, output);
        }

        // TODO: Multiplication overflow should be looked into further.
        // Test passes but logic may return unexpected behaviour!
        [TestMethod]
        public void TestOverflowMultiply()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MaxValue;
            int b = 20;

            int result = -20;

            // Act
            var output = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(result, output);
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
