namespace tyuiu.denisovld.sprint1.Task4.V17.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

    public class DataService : ISprint1Task4V17
{
    public double Calculate(double x, double y)
    {
        return 1 / (Math.Pow((x - 5 * y), 0.5));
    }
}

