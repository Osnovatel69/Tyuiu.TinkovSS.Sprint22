using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task5.V10.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        [DataRow(2025, 10, 14, "13.10.2025")]
        [DataRow(2025, 5, 1, "30.04.2025")]
        [DataRow(2025, 2, 1, "31.01.2025")]
        [DataRow(2025, 3, 1, "28.02.2025")]
        [DataRow(2025, 8, 1, "31.07.2025")]
        [DataRow(2025, 12, 1, "30.11.2025")]
        [DataRow(2025, 1, 1, "31.12.2024")]
        public void Calculate_ValidDate_ReturnsPreviousDate(
         int g, int m, int n, string expected)
        {
            DataService ds = new DataService();

            string actual = ds.Calculate(g, m, n);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_InvalidMonth_ThrowsException()
        {
            DataService ds = new DataService();

            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => ds.Calculate(2025, 13, 1));
        }

        [TestMethod]
        public void Calculate_InvalidFebruaryDay_ThrowsException()
        {
            DataService ds = new DataService();

            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => ds.Calculate(2025, 2, 29));
        }

        [TestMethod]
        public void Calculate_ZeroYear_ThrowsException()
        {
            DataService ds = new DataService();

            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => ds.Calculate(0, 1, 15));
        }
    }
}