using NUnit.Framework;
using Exercise4;
using Calculators;
using System.Collections.Generic;

namespace Exercise5Tests
{
    [TestFixture]
    public class Exercise5Tests
    {
        private CalculatorFactory calculatorFactory;

        [SetUp]
        public void Setup()
        {
            calculatorFactory = new CalculatorFactory();
        }

        // Addition tests with [TestCase]
        [Test]
        [TestCase(100, 20, 120)]
        [TestCase(50, 25, 75)]
        [TestCase(0, 0, 0)]
        [TestCase(-50, 25, -25)]
        public void Addition_WithVariousInitialStatesAndAdditions(decimal initialState, decimal addValue, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.Plus(addValue).Equals();
            Assert.AreEqual(expected, result);
        }

        // Addition tests with [TestCaseSource]
        [Test]
        [TestCaseSource(nameof(AdditionTestData))]
        public void Addition_WithTestCaseSource(decimal initialState, decimal addValue, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.Plus(addValue).Equals();
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<TestCaseData> AdditionTestData()
        {
            yield return new TestCaseData(100m, 20m, 120m);
            yield return new TestCaseData(0m, 0m, 0m);
            yield return new TestCaseData(-50m, 25m, -25m);
        }

        // Subtraction tests with [TestCase]
        [Test]
        [TestCase(100, 20, 80)]
        [TestCase(50, 25, 25)]
        [TestCase(0, 0, 0)]
        [TestCase(-50, 20, -70)]
        public void Subtraction_WithVariousInitialStatesAndSubtract(decimal initialState, decimal subtractValue, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.Minus(subtractValue).Equals();
            Assert.AreEqual(expected, result);
        }

        // Subtraction with [TestCaseSource]
        [Test]
        [TestCaseSource(nameof(SubtractionTestData))]
        public void Subtraction_WithTestCaseSource(decimal initialState, decimal subtractValue, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.Minus(subtractValue).Equals();
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<TestCaseData> SubtractionTestData()
        {
            yield return new TestCaseData(100m, 20m, 80m);
            yield return new TestCaseData(50m, 25m, 25m);
            yield return new TestCaseData(0m, 0m, 0m);
            yield return new TestCaseData(-50m, 20m, -70m);
        }

        // Multiplication tests with [TestCase]
        [Test]
        [TestCase(25, 4, 100)]
        [TestCase(10, 0, 0)]
        [TestCase(-5, 3, -15)]
        public void Multiplication_WithVariousInitialStatesAndMultiply(decimal initialState, decimal multiplyBy, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.MultiplyBy(multiplyBy).Equals();
            Assert.AreEqual(expected, result);
        }

        // Multiplication with [TestCaseSource]
        [Test]
        [TestCaseSource(nameof(MultiplicationTestData))]
        public void Multiplication_WithTestCaseSource(decimal initialState, decimal multiplyBy, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.MultiplyBy(multiplyBy).Equals();
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<TestCaseData> MultiplicationTestData()
        {
            yield return new TestCaseData(25m, 4m, 100m);
            yield return new TestCaseData(10m, 0m, 0m);
            yield return new TestCaseData(-5m, 3m, -15m);
        }

        // Division tests with [TestCase]
        [Test]
        [TestCase(33, 11, 3)]
        [TestCase(20, 4, 5)]
        [TestCase(-15, 5, -3)]
        public void Division_WithVariousInitialStatesAndDivide(decimal initialState, decimal divideBy, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.DivideBy(divideBy).Equals();
            Assert.AreEqual(expected, result);
        }

        // Division with [TestCaseSource]
        [Test]
        [TestCaseSource(nameof(DivisionTestData))]
        public void Division_WithTestCaseSource(decimal initialState, decimal divideBy, decimal expected)
        {
            var calculator = calculatorFactory.CreateWithInitialStateOf(initialState);
            var result = calculator.DivideBy(divideBy).Equals();
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<TestCaseData> DivisionTestData()
        {
            yield return new TestCaseData(33m, 11m, 3m);
            yield return new TestCaseData(20m, 4m, 5m);
            yield return new TestCaseData(-15m, 5m, -3m);
        }
    }
}