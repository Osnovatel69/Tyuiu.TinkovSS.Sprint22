using Tyuiu.TinkovSS.Sprint2.Task7.V15.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task7.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new Lib.DataService();

            Console.Title = "Спринт 2 | Задание 7 | Вариант 15";

            Console.WriteLine("****************************************");
            Console.WriteLine("* Спринт 2. Задание 7. Вариант 15       *");
            Console.WriteLine("* Проверка принадлежности точки области *");
            Console.WriteLine("****************************************");

            Console.WriteLine();
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine(
                "Определить, находится ли точка (X, Y)");
            Console.WriteLine(
                "в верхнем полукольце с радиусами 1 и 2.");

            Console.WriteLine();
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ:");

            Console.WriteLine(result
                ? "Точка находится в заштрихованной области."
                : "Точка не находится в заштрихованной области.");

            Console.ReadKey();
        }
    }
}