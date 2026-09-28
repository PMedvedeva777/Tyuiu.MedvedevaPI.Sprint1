namespace Tyuiu.MedvedevaPI.Sprint1.Task0.V26.Test;

using Tyuiu.MedvedevaPI.Sprint1.Task0.V26.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        var res = ds.Calculate();
        Assert.AreEqual(7, res);
    }
}


