
using System;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

DataService ds = new();

Console.Title = "Спринт #2 | Выполнил: Тиньков С. С. | ПКТб-2X-X";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Операции сравнения                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Тиньков С. С. | ПКТб-2X-X                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=)         *");
Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
Console.WriteLine("* последовательность: (False, False, False, False, False, False)          *");
Console.WriteLine("* при x = 111, y = 735                                                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x = 111;
int y = 735;
bool[] res = new bool[6];

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

res = ds.GetCompareOperations(x, y);

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
