using services;

namespace services.tests;

public class SumTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [TestCase(5, 7, 12)]
    [TestCase(-5, -7, -12)]
    [TestCase(-5, 7, 2)]
    [TestCase(0, 7, 7)]
    [TestCase(0, 0, 0)]
    [TestCase(unchecked(2147483647 + 1), 1, unchecked(2147483647 + 2))]
    [TestCase(unchecked(-2147483648 - 1), 1, -2147483648)]
    [TestCase(2147483647, 1, unchecked(2147483647 + 1))]
    [TestCase(-2147483648, 1, unchecked(-2147483648 + 1))]
    // 2147483647
    public void TC01(int a, int b, int expected)
    {
        int actualValue = Operations.Add(a, b);
        Assert.That(actualValue, Is.EqualTo(expected));
    }
}