using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    [TestClass]
    public class SimpleCalculatorUnitTests
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
        public void TestOverflowSubtract()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            int a = int.MinValue;
            int b = 10;

            // Act & Assert
            var output = Assert.ThrowsException<OverflowException>(() => calculator.Subtract(a, b));
        }
    }

}
