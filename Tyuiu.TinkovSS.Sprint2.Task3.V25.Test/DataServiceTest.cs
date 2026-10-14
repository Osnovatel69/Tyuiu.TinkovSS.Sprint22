using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double wait = 9.989;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -3.0;
            Assert.AreEqual(wait, res);
        }
    }
}