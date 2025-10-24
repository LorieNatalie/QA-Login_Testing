using Calculators;
using NUnit.Framework;

namespace Exercise2Tests;

public class Exercise2Tests
{
private SimpleCalculator calculator;

[SetUp]
public void SetUp()
{
calculator = new SimpleCalculator();
calculator.Enter(4); // Start each test with 4
}

[TearDown]
public void TearDown()
{
calculator.Reset(); // Reset calculator after each test
}

[Test]
public void AdditionTest()
{
var result = calculator.Plus(2).Equals();
Assert.That(result, Is.EqualTo(6));
}
[Test]
public void SubtractTest()
{
var result = calculator.Minus(2).Equals();
Assert.That(result, Is.EqualTo(2));
}
[Test]
public void MultiplicationTest()
{
var result = calculator.MultiplyBy(2).Equals();
Assert.That(result, Is.EqualTo(8));
}

[Test]
public void DivisionTest()
{
var result = calculator.DivideBy(2).Equals();
Assert.That(result, Is.EqualTo(2));
}
}