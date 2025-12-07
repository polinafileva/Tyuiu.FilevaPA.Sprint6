namespace Tyuiu.FilevaPA.Sprint6.Task0.V1.Test;
using Tyuiu.FilevaPA.Sprint6.Task0.V1.Lib;
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCalculateAtThree()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(3);
        // s(3) = 3 / (27 + 2) = 3 / 29 = 0.103448...
        double wait = 0.103;
        Assert.AreEqual(wait, res, 0.001);
    }

    [TestMethod]
    public void ValidCalculateAtTwo()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(2);
        // s(2) = 2 / (8 + 2) = 2 / 10 = 0.2
        double wait = 0.2;
        Assert.AreEqual(wait, res, 0.001);
    }

    [TestMethod]
    public void ValidCalculateAtZero()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(0);
        // s(0) = 0 / (0 + 2) = 0
        double wait = 0;
        Assert.AreEqual(wait, res, 0.001);
    }

    [TestMethod]
    public void ValidCalculateAtOne()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(1);
        // s(1) = 1 / (1 + 2) = 1 / 3 = 0.333...
        double wait = 0.333;
        Assert.AreEqual(wait, res, 0.001);
    }

    [TestMethod]
    public void ValidCalculateAtNegative()
    {
        DataService ds = new DataService();
        double res = ds.Calculate(-2);
        // s(-2) = -2 / (-8 + 2) = -2 / (-6) = 0.333...
        double wait = 0.333;
        Assert.AreEqual(wait, res, 0.001);
    }
}
