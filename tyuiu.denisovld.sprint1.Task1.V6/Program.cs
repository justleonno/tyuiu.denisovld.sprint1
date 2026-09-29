using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint1.Task1.V6.Lib;
namespace tyuiu.denisovld.sprint1.Task1.V6
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
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
            Console.WriteLine("* Задание #1                                                                                    *");
            Console.WriteLine("* Вариант #6                                                                                    *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет             *");
            Console.WriteLine("* результат по формуле (x+y)/(3*y) и печатает его на экране.                                    *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            double x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
