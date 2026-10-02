using Tyuiu.MedvedevaPI.Sprint1.Task3.V3.Lib;
namespace Tyuiu.MedvedevaPI.Sprint1.Task3.V3
{
      class Program
      {
            static void Main(string[] args)
            {
                DataService ds = new DataService();
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");
            double a = 10;
            double b = 5;
            double c = 7;
            Console.WriteLine("Длина параллелепипеда = " + a);
            Console.WriteLine("Ширина параллелепипеда = " + b);
            Console.WriteLine("Высота параллелепипеда = " + c);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Площадь параллелепипеда = " + ds.ParallelepipedVolume(a,b,c));
            Console.ReadKey();
        }
      }
}

