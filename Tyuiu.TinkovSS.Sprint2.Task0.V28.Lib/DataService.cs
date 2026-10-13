using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;          // 111 == 735 -> False
            res[1] = x + 624 != y;    // 735 != 735 -> False
            res[2] = y < x;           // 735 < 111  -> False
            res[3] = x > y;           // 111 > 735  -> False
            res[4] = y <= x;          // 735 <= 111 -> False
            res[5] = x >= y;          // 111 >= 735 -> False

            return res;
        }
    }
}