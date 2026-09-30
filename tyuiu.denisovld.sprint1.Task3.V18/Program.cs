using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint1.Task3.V18.Lib;
namespace tyuiu.denisovld.sprint1.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                     *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                                           *");
            Console.WriteLine("* Задание #3                                                                                    *");
            Console.WriteLine("* Вариант #18                                                                                    *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет             *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                             *");
            Console.WriteLine("* РАСЧЕТЫ:                                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C можно разместить       *");
            Console.WriteLine("* внутри прямоугольника с размерами A x B без наложений.                                        *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            double a;
            double b;
            double c;
            Console.WriteLine("Длина стороны А прямоугольника:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны B прямоугольника:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны C квадрата:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");
            
            double res = Math.Round(ds.HowManySquares(a, b, c), 3);
            Console.WriteLine("В прямоугольнике может поместиться " + res + " квадратов.");


        }
    }
}
