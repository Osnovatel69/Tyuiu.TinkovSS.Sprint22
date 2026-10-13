namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // x = 111, y = 735
            // Все 6 выражений возвращают False, порядок операций: ==, !=, <, >, <=, >=
            bool[] res = new bool[6]
            {
                x == y,          // 111 == 735          -> False
                x + 624 != y,    // 735 != 735          -> False
                x + 700 < y,     // 811 < 735           -> False
                x > y,           // 111 > 735           -> False
                x + 700 <= y,    // 811 <= 735          -> False
                x >= y           // 111 >= 735          -> False
            };

            return res;
        }
    }
}
