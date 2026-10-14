using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((y == 3 || y == 4) && ((x >= 3 && x <= 5) || x == 12))
            {
                return true;
            }
            if (y == 5 && ((x >= 3 && x <= 8) || x == 12))
            {
                return true;
            }
            if ((y == 6 || y == 7) && ((x >= 2 && x <= 8) || (x >= 12 && x <= 13)))
            {
                return true;
            }
            if (y == 8 && (x >= 6 && x <= 13))
            {
                return true;
            }
            if (y == 9 && (x >= 6 && x <= 12))
            {
                return true;
            }
            if (y == 10 && ((x >= 6 && x <= 7) || (x >= 11 && x <= 12)))
            {
                return true;
            }
            if (y == 11 && ((x >= 3 && x <= 7) || (x >= 11 && x <= 12)))
            {
                return true;
            }
            if (y == 12 && x == 7)
            {
                return true;
            }

            return false;
        }
    }
}