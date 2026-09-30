using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace tyuiu.denisovld.sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double AB = a * b; //4*5 = 20
            double CC = c * c; //2*2 = 4
            return AB / CC;
            
        }
    }
}
