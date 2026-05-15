namespace test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    [TestCase(1, 2, 3)]
    [TestCase(3, 4, 7)]
    public void TestSum(int a, int b, int sum)
    {
        Assert.That(a + b, Is.EqualTo(sum));
    }
}