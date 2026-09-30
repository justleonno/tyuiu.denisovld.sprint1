namespace tyuiu.denisovld.sprint1.Task5.V6.Test;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.denisovld.sprint1.Task5.V6.Lib;

public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            DataService ds = new DataService();
            int k = 54;
            int k2 = 56;
            var res = ds.Calculate(k);
            var res2 = ds.Calculate(k2);
            Assert.Equal(5, res);
            Assert.Equal(7, res2);

    }
    }
