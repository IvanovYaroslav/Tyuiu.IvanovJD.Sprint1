using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint1.Task5.V2.Lib;

namespace Tyuiu.IvanovJD.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double temp = 32;
            DataService ds = new DataService();

            var res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = 0;

            Assert.AreEqual(wait, result);



        }
    }
}
