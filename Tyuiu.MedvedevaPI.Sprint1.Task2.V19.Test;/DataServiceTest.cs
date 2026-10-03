namespace Tyuiu.MedvedevaPI.Sprint1.Task2.V19.Test;
using Tyuiu.MedvedevaPI.Sprint1.Task2.V19.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int value = 100;
        double expected = 2.54;
        double actual = ds.ConvertInchToKm(value);
        Assert.AreEqual(expected, actual);
    }
}
