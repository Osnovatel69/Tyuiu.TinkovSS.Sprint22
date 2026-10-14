using System;
using System.Globalization;
using Tyuiu.TinkovSS.Sprint2.Task4.V10.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 2 | Task4 | Вариант 10";

            DataService ds = new DataService();

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                               *");
            Console.WriteLine(
                "* Тема: Тернарный оператор                                                *");
            Console.WriteLine(
                "* Задание #4                                                              *");
            Console.WriteLine(
                "* Вариант #10                                                             *");
            Console.WriteLine(
                "* Выполнил: TinkovSS                                                      *");
            Console.WriteLine(
                "***************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Пользователь вводит значения x и y с клавиатуры.");
            Console.WriteLine("* Если x * 2 < y / 3, то z = (1 + 3 / (y * y)) ^ x.");
            Console.WriteLine("* Иначе z = y + 10 * x - 5 / x.");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.");

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine(
                "***************************************************************************");

            Console.Write("Введите x: ");
            double x = ReadNumber();

            Console.Write("Введите y: ");
            double y = ReadNumber();

            // Проверяем деление на ноль только в выбранной ветви.
            bool firstBranch = x * 2 < y / 3;

            if ((firstBranch && y == 0) || (!firstBranch && x == 0))
            {
                Console.WriteLine("Ошибка: в выбранной формуле деление на ноль.");
                Console.ReadKey();
                return;
            }

            double result = ds.Calculate(x, y);

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine(
                "***************************************************************************");

            Console.WriteLine("Значение z = " + result.ToString("F3"));

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }

        private static double ReadNumber()
        {
            while (true)
            {
                string input = (Console.ReadLine() ?? "")
                    .Trim()
                    .Replace(',', '.');

                if (double.TryParse(
                    input,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out double value)
                    && !double.IsNaN(value)
                    && !double.IsInfinity(value))
                {
                    return value;
                }

                Console.Write("Некорректное число. Повторите ввод: ");
            }
        }
    }
}