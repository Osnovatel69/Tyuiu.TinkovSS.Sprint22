using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double radiusSquared = x * x + y * y;

            return y >= 0
                && radiusSquared >= 1
                && radiusSquared <= 4;
        }
    }
}