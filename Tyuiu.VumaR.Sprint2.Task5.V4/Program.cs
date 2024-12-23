

using Tyuiu.VumaR.Sprint2.Task5.V4.Lib;
namespace Tyuiu.VumaR.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("Введите номер масти: ");
            int m = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((m < 1) || (m > 4))
            {
                Console.WriteLine("Запись некорректна!");
            }
            else
            {
                res = ds.FindCardSuit(m);
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine($"Название масти :  {res}"); ;
            }

            Console.ReadLine();
        }
    }
}
