
using Tyuiu.VumaR.Sprint2.Task3.V17.Lib;

namespace Tyuiu.VumaR.Sprint2.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y     *");
            Console.WriteLine("* с использованием вложенных операторов if-else, где пользователь        *");
            Console.WriteLine("* вводит значение переменной X с клавиатуры.                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            var res = ds.Calculate(x);

            Console.WriteLine($"Значение Y = {res}");
            Console.ReadKey();
        }
    }
}
