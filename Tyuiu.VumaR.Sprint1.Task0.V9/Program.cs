
using Tyuiu.VumaR.Sprint1.Task0.V9.Lib;

namespace Tyuiu.VumaR.Sprint1.Task0.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 1054; int y = 375;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("- Условие: Написать программу из операций сравнений                       -");
            Console.WriteLine("- (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)-");
            Console.WriteLine("- и арифметических выражений, которая вернет логическую                   -");
            Console.WriteLine("- последовательность(массив): (True, True, True, True, True, False)       -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- Исходные данные:                                                        -");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("- x = 1054, y = 375                                                       -");
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
