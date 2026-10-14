using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = Math.Sin(Math.Pow(x, 3)) + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - (Math.Cos(Math.Pow(x, 3)) / (x - 3));
            }
            else if (x > -29 && x < 2)
            {
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x < -29)
            {
                y = x + 15 + ((12 / x) * x);
            }

            return Math.Round(y, 3);
        }
    }
}