using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TinkovSS.Sprint2.Task1.V13.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}