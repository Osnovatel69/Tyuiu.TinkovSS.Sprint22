using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task1.V13.Lib
{
    public class DataService : ISprint2Task1V13
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // a = 145, b = 916, c = 164, d = 137
            // Логические операции: |, &, ||, &&, !, ^
            // Операции сравнения: ==, !=, <, >, <=, >=
            // Результат: True, True, True, True, True, False
            bool[] res = new bool[6];

            res[0] = (a == b) | (c > d);             // False | True  -> True (==, >)
            res[1] = (a != b) & (c > d);             // True  & True  -> True (!=)
            res[2] = (a < b) || (c < d);             // True  || False -> True (<)
            res[3] = (a + 771 == b) && (c >= d);     // True  && True  -> True (>=)
            res[4] = !(a <= d);                      // !(False)       -> True (<=, !)
            res[5] = (a > b) ^ (c < d);              // False ^ False  -> False (^)

            return res;
        }
    }
}