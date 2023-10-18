using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint3.Task2.V11.Lib;

namespace Tyuiu.CherepanovVS.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries1()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.292;
            Assert.AreEqual(res, wait);

        }
    }
}
