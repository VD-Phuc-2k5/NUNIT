
using services;

namespace services.tests;

public class MinMaxTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [TestCase(3, 1, 2, 3, 1)] // Max a, Min b
    [TestCase(3, 2, 1, 3, 1)] // Max a, Min c
    [TestCase(1, 3, 2, 3, 1)] // Max b, Min a
    [TestCase(2, 3, 1, 3, 1)] // Max b, Min c
    [TestCase(1, 2, 3, 3, 1)] // Max c, Min a
    [TestCase(2, 1, 3, 3, 1)] // Max c, Min b
    [TestCase(1, 1, 1, -1, -1)] // a = b = c
    public void TC01(int a, int b, int c, int maxNumber, int minNumber)
    {
        MinMaxResult actualValue = Operations.MaxMin(a, b, c);
        Assert.That(actualValue.MaxNumber, Is.EqualTo(maxNumber));
        Assert.That(actualValue.MinNumber, Is.EqualTo(minNumber));
    }
}