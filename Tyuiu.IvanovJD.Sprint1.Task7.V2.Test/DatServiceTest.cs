using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint1.Task7.V2.Lib;
namespace Tyuiu.IvanovJD.Sprint1.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService Res = new DataService();
            double x = 1;
            double y = 1;
            double z = Res.Calculate(x, y);
            Assert.AreEqual(z, z);
        }
    }
}
