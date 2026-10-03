using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MedvedevaPI.Sprint1.Task2.V19.Lib
{
    public class DataService : ISprint1Task2V19
    {
        public double ConvertInchToKm(int value)
        {
            double meters = value * 0.0254;
            return (int)(meters * 1000 + 0.5) / 1000;
        }
    }
}
