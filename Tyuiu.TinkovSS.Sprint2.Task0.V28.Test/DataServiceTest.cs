using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private readonly DataService ds = new DataService();

        [TestMethod]
        public void GetCompareOperations_ReturnsSixFalseValues()
        {
            int x = 111;
            int y = 735;

            bool[] result = ds.GetCompareOperations(x, y);

            Assert.AreEqual(6, result.Length);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.IsFalse(result[i]);
            }
        }
    }

}