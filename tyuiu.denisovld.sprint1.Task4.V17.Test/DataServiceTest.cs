namespace tyuiu.denisovld.sprint1.Task4.V17.Test;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint1.Task4.V17.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LOL()
        {
            DataService ds = new DataService();
            double x = 9;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }

