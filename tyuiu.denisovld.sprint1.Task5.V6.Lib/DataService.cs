namespace tyuiu.denisovld.sprint1.Task5.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task5V6
{
    public int Calculate(int k)
    {
        
            if ((k >= 1) && (k <= 365))
            {
                int lol = k % 7;
                if (lol == 0)
                {
                    int n = 7;
                    return n;
                }
                else
                {
                    int n = lol;
                    return n;
                }
            }
            else
            {
                int n = -1;
                return n;
            }
        
    }
}
