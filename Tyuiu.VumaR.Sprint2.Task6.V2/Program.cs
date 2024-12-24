using Tyuiu.VumaR.Sprint2.Task6.V2.Lib;
namespace Tyuiu.VumaR.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMonthSeason = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMonthSeason < 1) || (numMonthSeason > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Это пора года: " + ds.FindMonthSeason(numMonthSeason);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
