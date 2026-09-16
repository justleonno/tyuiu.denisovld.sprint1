using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.denisovld.sprint1.task0.v0.Lib;
namespace tyuiu.denisovld.sprint1.task0.v0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
