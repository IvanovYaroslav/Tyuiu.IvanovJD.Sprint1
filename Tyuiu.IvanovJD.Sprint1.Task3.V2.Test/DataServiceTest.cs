using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint1.Task3.V2.Lib;

namespace Tyuiu.IvanovJD.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void PurchaseAmount()
        {
            DataService ds = new DataService();
            double cena = 3.50;
            double cena2 = 5.50;
            int k = 5;
            int t = 5;

            double res = ds.PurchaseAmount((double)cena,(int)k,(double)cena2,(int)t);
            Assert.AreEqual(res, 45);


        }
    }
}
