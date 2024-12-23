﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VumaR.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((y >= (x / 2)) && (x >= -1) && (x <= 1)) && ((y >= -1) && (y <= 1))) res = true;
            else res = false;

            return res;
        }
    }
}
