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
            // Проверяем условие: x * 2 < y + 3
            // Если истина -> первая формула
            // Если ложь  -> вторая формула

            double result;

            if (x * 2 < y + 3)
            {
                // Формула 1: (1 + 3/y^2)^x
                // Разбиваем на части для точности
                double fraction = 3.0 / Math.Pow(y, 2);   // 3 / y^2
                double baseValue = 1.0 + fraction;         // 1 + 3/y^2
                result = Math.Pow(baseValue, x);           // (...)^x
            }
            else
            {
                // Формула 2: y + 10x - (5/x)
                result = y + (10.0 * x) - (5.0 / x);
            }

            // Округляем до 3 знаков после запятой ВНУТРИ библиотеки
            return Math.Round(result, 3);
        }
    }
}