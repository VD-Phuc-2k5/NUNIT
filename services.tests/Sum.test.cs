using services;

namespace services.tests;

public class SumTests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    [Description("Tính tổng 2 số: 5+7=12 dùng areEqual. Passed")]
    public void TC01()
    {
        int actualValue = Operations.Add(5, 7);
        int expectedValue = 12;
        Assert.That(actualValue, Is.EqualTo(expectedValue));
    }
    
    [Test]
    [Description("Tính tổng 2: 2+7=12 dùng areEqual. Failed")]
    public void TC02() {
        int actualValue = Operations.Add(2, 7);
        int expectedValue = 9;
        Assert.That(actualValue, Is.EqualTo(expectedValue));
    }
}