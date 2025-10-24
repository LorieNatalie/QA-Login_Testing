using NUnit.Framework;

namespace Exercise3Tests
{
    public class NegativeNumberTests : BaseTest
    {
        [Test]
        public void NegativeAddition()
        {
            var result = calculator.Enter(-4).Plus(-2).Equals();
            Assert.AreEqual(-6, result);
        }

        [Test]
        public void NegativeSubtraction()
        {
            var result = calculator.Enter(-4).Minus(-2).Equals();
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void NegativeMultiplication()
        {
            var result = calculator.Enter(-4).MultiplyBy(-2).Equals();
            Assert.AreEqual(8, result);
        }

        [Test]
        public void NegativeDivision()
        {
            var result = calculator.Enter(-4).DivideBy(-2).Equals();
            Assert.AreEqual(2, result);
        }
    }
}