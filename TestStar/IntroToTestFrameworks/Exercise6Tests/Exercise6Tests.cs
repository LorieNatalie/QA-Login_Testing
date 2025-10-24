using NUnit.Framework;
using Calculators;
using System;

namespace Exercise6Tests
{
    [TestFixture]
    public class NegativeTestScenarios
    {
        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            var calculator = new SimpleCalculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Enter(10).DivideBy(0));
        }

        [Test]
        public void Addition_ToMaxValue_ThrowsOverflowException()
        {
            // Arrange
            var calculator = new SimpleCalculator().Enter(decimal.MaxValue);

            // Act & Assert
            // This test documents that adding to decimal.MaxValue throws an OverflowException.
            Assert.Throws<OverflowException>(() => calculator.Plus(1));
        }
    }
}