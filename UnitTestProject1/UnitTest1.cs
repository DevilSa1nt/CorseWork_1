using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Coursework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pair p = new Pair(10, Pair.DayOfWeek.Monday, "09.00 - 10.35", "ADM", "Kalitin", "B1107");

            string psn = "Monday    09.00 - 10.35    ADM    Kalitin    B1107";
            string psc = p.ToString();

            Assert.AreEqual(psn, psc, $"Battlesuite: {p}");
        }
    }
}
