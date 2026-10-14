using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task6.V3.Lib
{
    public class DataService : ISprint2Task6V3
    {
        public string Calculate(int value)
        {
            return value switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Номер дня недели должен быть от 1 до 7.")
            };
        }

        public string FindDayName(int value)
        {
            throw new NotImplementedException();
        }
    }
}