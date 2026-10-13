
using System;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib
{
    public class DataService : global::Sprint2.Task0.V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x == y,
                x != y,
                x > y,
                x < y,
                x >= y,
                x <= y
            };
        }
    }
}
