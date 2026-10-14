using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task3.V25.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void ValidCheckDotOutsideShadedArea()
        {
            DataService ds = new DataService();

            int x = 1;
            int y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);

            Assert.IsFalse(res);
        }
    }
}