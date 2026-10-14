using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task7.V15.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        [DataRow(0.0, 1.5, true)]
        [DataRow(1.0, 1.0, true)]
        [DataRow(-1.0, 1.0, true)]

        // Точки на границах области.
        [DataRow(0.0, 1.0, true)]
        [DataRow(0.0, 2.0, true)]
        [DataRow(-2.0, 0.0, true)]
        [DataRow(2.0, 0.0, true)]
        [DataRow(1.0, 0.0, true)]

        // Точки вне заштрихованной области.
        [DataRow(0.0, 0.0, false)]
        [DataRow(0.0, 0.5, false)]
        [DataRow(0.0, 2.5, false)]
        [DataRow(0.0, -1.5, false)]
        [DataRow(2.0, 1.0, false)]
        public void CheckDotInShadedArea_ReturnsExpectedResult(
            double x, double y, bool expected)
        {
            DataService ds = new DataService();

            bool actual = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}