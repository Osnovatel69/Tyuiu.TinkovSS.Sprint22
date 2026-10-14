using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task6.V3.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        [DataRow(1, "понедельник")]
        [DataRow(2, "вторник")]
        [DataRow(3, "среда")]
        [DataRow(4, "четверг")]
        [DataRow(5, "пятница")]
        [DataRow(6, "суббота")]
        [DataRow(7, "воскресенье")]
        public void Calculate_ValidNumber_ReturnsDayName(
            int value, string expected)
        {
            DataService ds = new DataService();

            string actual = ds.Calculate(value);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(8)]
        [DataRow(-1)]
        public void Calculate_InvalidNumber_ThrowsException(int value)
        {
            DataService ds = new DataService();

            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => ds.Calculate(value));
        }
    }
}