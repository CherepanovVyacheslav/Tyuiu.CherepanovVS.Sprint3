using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint3.Task6.V25.Lib;

namespace Tyuiu.CherepanovVS.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 89;
            Assert.AreEqual(res,wait);
        }
    }
}
