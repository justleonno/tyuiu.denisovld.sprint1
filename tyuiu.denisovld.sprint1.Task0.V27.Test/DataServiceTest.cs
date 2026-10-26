using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint1.Task0.V27.Lib;
namespace tyuiu.denisovld.sprint1.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double exp = 22;
            double res = ds.Calculate();
            Assert.AreEqual(exp, res);
        }
    }
}
