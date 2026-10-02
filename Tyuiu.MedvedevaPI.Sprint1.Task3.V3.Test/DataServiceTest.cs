namespace Tyuiu.MedvedevaPI.Sprint1.Task3.V3.Test;
using  Tyuiu.MedvedevaPI.Sprint1.Task3.V3.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        double x = 9;
        double y = 5;
        double z = 7.5;
        var res = ds.ParallelepipedVolume(x, y, z);
        Assert.AreEqual(337.5, res);
    }
}
