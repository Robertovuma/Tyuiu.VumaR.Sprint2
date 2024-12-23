
using Tyuiu.VumaR.Sprint1.Task1.V22.Lib;

namespace Tyuiu.VumaR.Sprint1.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 247, b = 654, c = 671, d = 671; 
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,             *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций             *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), *");
            Console.WriteLine("* а также арифметических выражений,                                       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, True, False),                                *");
            Console.WriteLine("* при a = 247, b = 654, c = 671, d = 671                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
