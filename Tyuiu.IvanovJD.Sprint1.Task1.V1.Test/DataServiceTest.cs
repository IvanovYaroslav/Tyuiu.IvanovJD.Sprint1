using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint1.Task1.V1.Lib;

namespace Tyuiu.IvanovJD.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double a = 4.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(res, res);
        }
    }
}
