using Tyuiu.MedvedevaPI.Sprint1.Task7.V2.Lib;
namespace Tyuiu.MedvedevaPI.Sprint1.Task7.V2.Test
{
[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void VolidExpression()
    {
        DataService ds = new DataService();
        double x = 1;
        double y = 2;
        double expected = 2.519;
        double actual = ds.Calculate(x, y);
        Assert.AreEqual(expected, actual);
    }
}
}

