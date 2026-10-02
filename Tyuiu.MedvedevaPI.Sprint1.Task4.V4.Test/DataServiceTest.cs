namespace Tyuiu.MedvedevaPI.Sprint1.Task4.V4.Test;

using Tyuiu.MedvedevaPI.Sprint1.Task4.V4.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 2;
        double y = 3;
        var res = ds.Calculate(x, y);
        Assert.AreEqual(1.75, res);
    }
}
