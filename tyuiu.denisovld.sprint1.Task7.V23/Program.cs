using tyuiu.denisovld.sprint1.Task7.V23.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                     *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                       *");
Console.WriteLine("* Задание #7                                                                                    *");
Console.WriteLine("* Вариант #23                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,  *");
Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                            *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

Console.WriteLine("Введите значение x");
double x;
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение y");
double y;
y = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

double res = Math.Round(ds.Calculate(x, y), 3);
Console.WriteLine("Результат формулы: " + res);