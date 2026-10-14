using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string Calculate(int g, int m, int n)
        {
            if (g < 1)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(g), "Год должен быть натуральным числом.");
            }

            int daysInMonth = GetDaysInMonth(m);

            if (n < 1 || n > daysInMonth)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(n), "Такого числа нет в указанном месяце.");
            }

            // В рамках натуральных номеров лет предыдущая дата отсутствует.
            if (g == 1 && m == 1 && n == 1)
            {
                throw new ArgumentException(
                    "Нельзя определить предыдущую дату в пределах натуральных лет.");
            }

            if (n > 1)
            {
                n--;
            }
            else
            {
                // Первое число месяца: переходим к предыдущему месяцу.
                if (m == 1)
                {
                    g--;
                    m = 12;
                }
                else
                {
                    m--;
                }

                n = GetDaysInMonth(m);
            }

            return $"{n:D2}.{m:D2}.{g:D4}";
        }

        string ISprint2Task5V10.FindDateOfPreviousDay(int g, int m, int n)
        {
            throw new NotImplementedException();
        }

        private int GetDaysInMonth(int m)
        {
            // По условию год невисокосный.
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;

                case 2:
                    return 28;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(m), "Номер месяца должен быть от 1 до 12.");
            }
        }
    }
}