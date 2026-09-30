namespace tyuiu.denisovld.sprint1.Task4.V17.Test;

using tyuiu.denisovld.sprint1.Task4.V17.Lib;

    public class DataServiceTest
{
    [Fact]
    public void LOL()
    {
        DataService ds = new DataService();
        double x = 9;
        double y = 1;
        var res = ds.Calculate(x, y);
        Assert.Equal(0.5, res);
    }
}

