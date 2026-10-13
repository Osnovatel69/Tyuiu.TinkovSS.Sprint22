namusing System;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Тиньков С.С. | Вариант 28";

            DataService ds = new DataService();

            int x = 111;
            int y = 735;

            Console.WriteLine("**************************************************");
            Console.WriteLine("* Спринт #2                                      *");
            Console.WriteLine("* Задание #0                                     *");
            Console.WriteLine("* Вариант #28                                    *");
            Console.WriteLine("* Выполнил: Тиньков С.С.                         *");
            Console.WriteLine("**************************************************");
            Console.WriteLine();

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine();

            Console.WriteLine("Результат:");

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }
    }

}