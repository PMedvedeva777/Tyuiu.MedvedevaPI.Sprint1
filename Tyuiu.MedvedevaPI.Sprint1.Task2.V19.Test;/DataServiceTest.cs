namespace Tyuiu.MedvedevaPI.Sprint1.Task2.V19.Test;
using Tyuiu.MedvedevaPI.Sprint1.Task2.V19.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        int x = 1;
        var res = ds.ConvertInchToKm(x);
        Assert.AreEqual(0.0000254, res);
    }
}
