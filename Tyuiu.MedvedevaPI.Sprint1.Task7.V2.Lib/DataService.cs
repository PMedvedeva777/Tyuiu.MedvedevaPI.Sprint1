namespace Tyuiu.MedvedevaPI.Sprint1.Task7.V2.Lib;

using System.Data;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task7V2
{
    public double Calculate(double x, double y)
    {
        double numerator = Math.Sin(x) + Math.Cos(y);
        double denominator = Math.Cos(x) - Math.Sin(y);
        if (denominator ==0)
        {
            throw new DivideByZeroException();
        }
        double tanPart = Math.Tan(x * y);
        double result = (numerator / denominator) * tanPart;
        return Math.Round(result, 3);
    }
}


