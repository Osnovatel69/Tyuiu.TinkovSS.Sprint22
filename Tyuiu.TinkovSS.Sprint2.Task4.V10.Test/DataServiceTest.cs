using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task4.V10.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_FirstBranch_ReturnsRoundedResult()
        {
            // 1 * 2 < 9 / 3: условие истинно.
            // z = (1 + 3 / 81)^1 = 1.037 после округления.
            DataService ds = new DataService();

            double x = 1;
            double y = 9;
            double expected = 1.037;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void Calculate_SecondBranch_ReturnsCorrectResult()
        {
            // 2 * 2 < 3 / 3: условие ложно.
            // z = 3 + 10 * 2 - 5 / 2 = 20.5.
            DataService ds = new DataService();

            double x = 2;
            double y = 3;
            double expected = 20.5;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [TestMethod]
        public void Calculate_EqualBoundary_UsesSecondBranch()
        {
            // 1 * 2 == 6 / 3.
            // Поскольку сравнение строгое, выбирается вторая формула.
            // z = 6 + 10 * 1 - 5 / 1 = 11.
            DataService ds = new DataService();

            double x = 1;
            double y = 6;
            double expected = 11;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}