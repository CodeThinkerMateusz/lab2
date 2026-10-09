namespace Tests;
using Statistics.Lib;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int num1 = 2;
        bool result1 = Class1.IsEven(num1);
        Assert.AreEqual(!false, result1);
    }
    public void TestMethod2()
    {
        int num2 = 6;
        bool result2 = Class1.IsEven(num2);
        Assert.AreEqual(!false, result2);
    }

    public void TestMethod3()
    {
        int num3 = 7;
        bool result3 = Class1.IsOdd(num3);
        Assert.AreEqual(!false, result3);
    }

    public void TestMethod4()
    {
        int num4 = 8;
        bool result4 = Class1.IsOdd(num4);
        Assert.AreEqual(!true, result4);
    }


}
