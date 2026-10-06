using tyuiu.denisovld.sprint1.Task6.V4.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;
DataService ds = new DataService();

Console.Title = "Спринт 1 | Выполнено by Денисов Л. Д. | АСОиУб-26-1";
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                     *");
Console.WriteLine("* Тема: Работа со строками класс String                                                         *");
Console.WriteLine("* Задание #6                                                                                    *");
Console.WriteLine("* Вариант #4                                                                                    *");
Console.WriteLine("* Выполнено by Денисов Л. Д. | АСОиУб-26-1                                                      *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать все слова, содержащие               *");
Console.WriteLine("* удвоенное н (\"нн\").                                                                         *");
Console.WriteLine("*                                                                                               *");
Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
Console.WriteLine("*************************************************************************************************");

string lol;
lol = Console.ReadLine();


Console.WriteLine("*************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
Console.WriteLine("*************************************************************************************************");

Console.WriteLine("Слова, содержащие нн: " + ds.CheckDoubleN(lol));