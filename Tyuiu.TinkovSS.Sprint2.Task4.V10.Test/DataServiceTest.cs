using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task4.V10.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateFirstBranch()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 1.41015625;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateSecondBranch()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 51;
            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}