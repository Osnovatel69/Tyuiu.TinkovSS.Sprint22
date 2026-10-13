using System;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib
{
    public class DataService
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = (x == y);
            result[1] = (x != y);
            result[2] = (x < y);
            result[3] = (x > y);
            result[4] = (x <= y);
            result[5] = (x >= y);

            return result;
        }
    }

}