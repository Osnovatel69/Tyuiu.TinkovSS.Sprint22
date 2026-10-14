nameusing Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task3.V25.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            // sin(8) + ((3/1)^2) = 0.989358 + 9 = 9.989
            double wait = 9.989;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            // 0^2 - (cos(0) / (0 - 3)) = - (1 / -3) = 0.333
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            // (1 + 1/1)^1 = 2
            double wait = 2.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            // -30 + 15 + (12 / -30) * (-30) = -30 + 15 + 12 = -3
            double wait = -3.0;
            Assert.AreEqual(wait, res);
        }
    }
}