namespace tyuiu.denisovld.sprint1.Task5.V6.Test;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint1.Task5.V6.Lib;

[TestClass]
public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
            int k = 54;
            int k2 = 56;
            var res = ds.Calculate(k);
            var res2 = ds.Calculate(k2);
            Assert.AreEqual(5, res);
            Assert.AreEqual(7, res2);

    }
    }
