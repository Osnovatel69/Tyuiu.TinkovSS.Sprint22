using System;
using Tyuiu.TinkovSS.Sprint2.Task1.V13.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-2X-X                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
            Console.WriteLine("* (|, &, ||, &&, !, ^), которая вернет логическую последовательность:     *");
            Console.WriteLine("* (True, True, True, True, True, False)                                   *");
            Console.WriteLine("* при a = 145, b = 916, c = 164, d = 137                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}