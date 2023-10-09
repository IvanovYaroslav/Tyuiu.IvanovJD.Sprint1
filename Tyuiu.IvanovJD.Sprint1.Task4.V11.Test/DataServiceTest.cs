using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint1.Task4.V11.Lib;


namespace Tyuiu.IvanovJD.Sprint1.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            double res = 0;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}

