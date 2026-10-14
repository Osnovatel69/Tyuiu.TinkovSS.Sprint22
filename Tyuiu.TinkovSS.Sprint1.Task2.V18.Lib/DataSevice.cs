using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Проверка попадания точки (x, y) в заштрихованную область
            if ((x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
                (x >= 6 && x <= 9 && y >= 5 && y <= 8) ||
                (x >= 9 && x <= 12 && y >= 3 && y <= 4) ||
                (x >= 10 && x <= 12 && y >= 7 && y <= 11) ||
                (x >= 6 && x <= 9 && y >= 9 && y <= 12) ||
                (x >= 3 && x <= 5 && y >= 11 && y <= 12))
            {
                return true;
            }

            return false;
        }
    }
}