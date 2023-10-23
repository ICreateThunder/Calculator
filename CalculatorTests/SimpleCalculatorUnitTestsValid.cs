using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorImpl;

namespace CalculatorTests
{
    [TestClass]
    public class SimpleCalculatorUnitTestsValid
    {
        [TestMethod]
        public void TestValidAdd()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = 5;
            int b = 10;
            int result = 15;

            // Act
            var output = calculator.Add(a, b);

            // Asset
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void TestValidSubtract()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = 15;
            int b = 10;

            int result = 5;

            // Act
            var output = calculator.Subtract(a, b);

            // Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void TestValidMultiply()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = 5;
            int b = 10;
            int result = 50;

            // Act
            var output = calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(output, result);
        }

        [TestMethod]
        public void TestValidDivide()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = 50;
            int b = 10;
            int result = 5;

            // Act
            var output = calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(output, result);
        }
    }

}
