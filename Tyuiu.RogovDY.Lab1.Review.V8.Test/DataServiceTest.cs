using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RogovDY.Lab1.Review.V8.Lib;

namespace Tyuiu.RogovDY.Lab1.Review.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            double x = 0.9;
            double y = 0.6;

            DataService ds = new DataService();

            double result = ds.Calc(x, y);

            double true_val = 0.762;

            Assert.AreEqual(true_val, result);
        }
    }
}
