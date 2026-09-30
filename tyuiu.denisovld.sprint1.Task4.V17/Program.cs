using tyuiu.denisovld.sprint1.Task4.V17.Lib;

DataService ds = new DataService();

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                     *");
Console.WriteLine("* Тема: Class Math                                                                              *");
Console.WriteLine("* Задание #4                                                                                    *");
Console.WriteLine("* Вариант #17                                                                                   *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет             *");
Console.WriteLine("* указанные расчёты и печатает результат на экране.                                             *");
Console.WriteLine("* ФОРМУЛА:                                                                                      *");
Console.WriteLine("* 1/(x-5y)^(0.5)                                                                                *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

double x;
double y;
Console.WriteLine("Введите значение x:");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

double res = Math.Round(ds.Calculate(x, y), 3);
Console.WriteLine("Результат формулы = " + res);