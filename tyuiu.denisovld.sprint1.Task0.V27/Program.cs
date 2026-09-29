using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//lol
using tyuiu.denisovld.sprint1.task0.v27.Lib;
namespace tyuiu.denisovld.sprint1.task0.v27._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #0                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                                              *");
            Console.WriteLine("* Задание #0                                                                                    *");
            Console.WriteLine("* Вариант #27                                                                                   *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение  5*2 + 4*3                                    *");
            Console.WriteLine("* и печатает результат на экране.                                                               *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* 5*2 + 4*3                                                                                     *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();
        }
    }
}
