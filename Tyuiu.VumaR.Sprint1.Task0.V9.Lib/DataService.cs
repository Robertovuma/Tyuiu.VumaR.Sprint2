
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.VumaR.Sprint1.Task0.V9.Lib
{
    public class DataService : ISprint2Task0V9
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] array = new bool[6];

            array[0] = x == y + 679;
            array[1] = x != y + 1000;
            array[2] = x < y + 1000;
            array[3] = x > y;
            array[4] = x <= y + 1000;
            array[5] = x >= y + 1000;

            return array;
        }
    }
}
