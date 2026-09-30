using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using tyuiu.denisovld.sprint1.Task3.V18.Lib;
namespace tyuiu.denisovld.sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExp()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 4;
            double c = 2;
            var res = ds.HowManySquares(x, y, c);
            Assert.AreEqual(5, res);
        }
    }
}
