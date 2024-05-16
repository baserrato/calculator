using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [Test]
    public void TestAddition()
    {
        Assert.AreEqual(5, calculator.Add(2, 3));
    }

    [Test]
    public void TestSubtraction()
    {
        Assert.AreEqual(1, calculator.Subtract(3, 2));
    }

    [Test]
    public void TestMultiplication()
    {
        Assert.AreEqual(6, calculator.Multiply(2, 3));
    }

    [Test]
    public void TestDivision()
    {
        Assert.AreEqual(2, calculator.Divide(6, 3));
    }

    [Test]
    public void TestDivisionByZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
    }
}
