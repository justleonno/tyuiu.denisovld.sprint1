namespace tyuiu.denisovld.sprint1.Task6.V4.Test;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint1.Task6.V4.Lib;

    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test1()
        {
            DataService ds = new DataService();
        string lol = "Попробуй мой изумительнный вкус! Аннанас! Аннаннас! Ананас! Абриннкос!";
        string exp = "изумительнный Аннанас Аннаннас Абриннкос";
        //string lol = "annanas ananas anannas ananananan anananann";
        //string exp = "annanas anannas anananann";
        string res = ds.CheckDoubleN(lol);
        Assert.AreEqual(exp, res);

        }
    }
