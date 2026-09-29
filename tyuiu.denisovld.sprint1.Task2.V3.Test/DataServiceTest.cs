using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tyuiu.denisovld.sprint1.Task2.V3.Lib;

namespace tyuiu.denisovld.sprint1.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExp()
        {
            //ISprint1Task2V3.ConvertHourToMin(int)
            DataService ds = new DataService();
            int x = 120;
            var res = ds.ConvertHourToMin(2);
            Assert.AreEqual(x, res);
        }
    }
}
