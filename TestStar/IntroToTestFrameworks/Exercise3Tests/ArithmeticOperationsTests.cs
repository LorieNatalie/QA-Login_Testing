using NUnit.Framework;

namespace Exercise3Tests
{
    public class ArithmeticOperationsTests : BaseTest
    {
        [Test]
        public void AdditionTest()
        {
            var result = calculator.Plus(2).Equals();
            Assert.AreEqual(6, result);
        }

        [Test]
        public void SubtractionTest()
        {
            var result = calculator.Minus(2).Equals();
            Assert.AreEqual(2, result);
        }

        [Test]
        public void MultiplicationTest()
        {
            var result = calculator.MultiplyBy(3).Equals();
            Assert.AreEqual(12, result);
        }

        [Test]
        public void DivisionTest()
        {
            var result = calculator.DivideBy(2).Equals();
            Assert.AreEqual(2, result);
        }
    }
}