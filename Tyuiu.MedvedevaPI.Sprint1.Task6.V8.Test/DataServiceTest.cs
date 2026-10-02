namespace Tyuiu.MedvedevaPI.Sprint1.Task6.V8.Test;

using Tyuiu.MedvedevaPI.Sprint1.Task6.V8.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds = new DataService();
        string input = "Привет мир";
        string expected = "риветП ирм";
        string actual = ds.MoveLetterToEnd(input);
        Assert.AreEqual(expected, actual);
    }
}
