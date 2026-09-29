using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.denisovld.sprint1.Task2.V3.Lib;
namespace tyuiu.denisovld.sprint1.Task2.V3
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
            Console.WriteLine("* Тема: Арифметические операторы в C#                                                           *");
            Console.WriteLine("* Задание #2                                                                                    *");
            Console.WriteLine("* Вариант #3                                                                                    *");
            Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет             *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                             *");
            Console.WriteLine("* Формулировка задания: Задано количество часов. Перевести время в минуты.                      *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            int x;
            Console.WriteLine("Введите количество часов:");
            x = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("Время в минутах: " + ds.ConvertHourToMin(x));

            Console.ReadLine();

        }
    }
}
