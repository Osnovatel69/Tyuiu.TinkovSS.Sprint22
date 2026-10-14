using System;

namespace Tyuiu.TinkovSS.Sprint2.Task4.V10.Lib
{
    public interface ISprint2Task4V10
    {
        double Calculate(double x, double y);
    }

    public class DataService : ISprint2Task4V10
    {
        public double Calculate(double x, double y)
        {
            return (x * 2 < y + 3)
                ? Math.Pow(1 + 3 / Math.Pow(y, 2), x)
                : y + 10 * x - 5 / x;
        }
    }
}