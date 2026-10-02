namespace Tyuiu.MedvedevaPI.Sprint1.Task3.V3.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task3V3
{
    public double ParallelepipedVolume(double length, double width, double height)
    {
        return length * width * height;
    }
}
