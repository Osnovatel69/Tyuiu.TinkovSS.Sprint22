using System;

namespace Tyuiu.TinkovSS.Sprint2.Task4.V10.Lib
{
    // Объявляем интерфейс прямо здесь, чтобы не создавать отдельный файл
    public interface ISprint2Task3V25
    {
        double Calculate(double x, double y);
    }

    // Наследуем класс от интерфейса
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x, double y)
        {
            // Условие: если x * 2 < y + 3
            // Формула 1: (1 + 3/y^2)^x
            // Формула 2: y + 10x - (5/x)

            double result = (x * 2 < y + 3)
                ? Math.Pow(1 + (3 / Math.Pow(y, 2)), x)
                : y + (10 * x) - (5 / x);

            // Округление до 3 знаков после запятой
            return Math.Round(result, 3);
        }
    }
}