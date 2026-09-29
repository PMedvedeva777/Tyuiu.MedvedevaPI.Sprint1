namespace Tyuiu.MedvedevaPI.Sprint1.Task1.V25.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task1V25
{
    public double Calculate(double x, double y)
    {
        return (x*y)/(1+x);
    }
}
