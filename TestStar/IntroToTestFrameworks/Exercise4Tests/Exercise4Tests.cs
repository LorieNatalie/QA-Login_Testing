using Calculators;
using Exercise4;
using NUnit.Framework;

namespace Exercise4Tests
{
    public class Exercise4Tests
    {
        private CalculatorFactory calculatorFactory;

        [SetUp]
        public void Setup()
        {
            calculatorFactory = new CalculatorFactory();
        }

        [Test]
        public void Addition_WithInitialState100AndAdd20_Returns120()
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(100.00m);
            var result = calculator.Plus(20.00m).Equals();
            Assert.AreEqual(120.00m, result);
        }

        [Test]
        public void Subtraction_WithInitialState10AndSubtract5_Returns5()
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(10.00m);
            var result = calculator.Minus(5.00m).Equals();
            Assert.AreEqual(5.00m, result);
        }

        [Test]
        public void Multiplication_WithInitialState25AndMultiplyBy4_Returns100()
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(25);
            var result = calculator.MultiplyBy(4.00m).Equals();
            Assert.AreEqual(100.00m, result);
        }

        [Test]
        public void Division_WithInitialState33AndDivideBy11_Returns3()
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(33);
            var result = calculator.DivideBy(11.00m).Equals();
            Assert.AreEqual(3.00m, result);
        }
    }
}