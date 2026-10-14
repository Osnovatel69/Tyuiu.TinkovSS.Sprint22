using System;
using System.Text;
using Tyuiu.TinkovSS.Sprint2.Task5.V10.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task5.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                               *");
            Console.WriteLine(
                "* Тема: Оператор switch                                                   *");
            Console.WriteLine(
                "* Задание #5                                                              *");
            Console.WriteLine(
                "* Вариант #10                                                             *");
            Console.WriteLine(
                "* Выполнил: Тинков С. С.                                                   *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:");
            Console.WriteLine("* Дата задаётся годом g, месяцем m и числом n.");
            Console.WriteLine("* Определить дату предыдущего дня.");
            Console.WriteLine("* Заданный год не является високосным.");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
            Console.WriteLine(
                "***************************************************************************");

            try
            {
                Console.Write("Введите год g: ");
                int g = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите номер месяца m: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите число n: ");
                int n = Convert.ToInt32(Console.ReadLine());

                DataService ds = new DataService();
                string result = ds.Calculate(g, m, n);

                Console.WriteLine(
                    "***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:");
                Console.WriteLine(
                    "***************************************************************************");

                Console.WriteLine($"Заданная дата: {n:D2}.{m:D2}.{g:D4}");
                Console.WriteLine($"Дата предыдущего дня: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: необходимо вводить целые числа.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введено слишком большое число.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для завершения...");
            Console.ReadLine();
        }
    }
}