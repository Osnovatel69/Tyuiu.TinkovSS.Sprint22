using System;
using System.Text;
using Tyuiu.TinkovSS.Sprint2.Task6.V3.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DataService ds = new DataService();

            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* Спринт #2                                                               *");
            Console.WriteLine(
                "* Тема: Сокращенная форма записи оператора switch                          *");
            Console.WriteLine(
                "* Задание #6                                                              *");
            Console.WriteLine(
                "* Вариант #3                                                              *");
            Console.WriteLine(
                "* Выполнил: Тинков С. С.                                                   *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* УСЛОВИЕ:                                                                *");
            Console.WriteLine(
                "* По порядковому номеру дня недели от 1 до 7 определить его название.      *");
            Console.WriteLine(
                "* Использовать сокращенную форму записи оператора switch.                 *");
            Console.WriteLine(
                "***************************************************************************");
            Console.WriteLine(
                "* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(
                "***************************************************************************");

            try
            {
                Console.Write("Введите номер дня недели (1–7): ");
                int value = Convert.ToInt32(Console.ReadLine());

                string result = ds.Calculate(value);

                Console.WriteLine(
                    "***************************************************************************");
                Console.WriteLine(
                    "* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine(
                    "***************************************************************************");

                Console.WriteLine("День недели: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: необходимо ввести целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введено слишком большое число.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: номер дня недели должен быть от 1 до 7.");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите Enter для завершения...");
            Console.ReadLine();
        }
    }
}