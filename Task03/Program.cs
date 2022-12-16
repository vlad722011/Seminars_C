// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число - номер дня недели: ");
string numberOfTheDay = Console.ReadLine();
if (numberOfTheDay == "1") Console.WriteLine("Понедельник");
else if (numberOfTheDay == "2") Console.WriteLine("Вторник");
else if (numberOfTheDay == "3") Console.WriteLine("Среда");
else if (numberOfTheDay == "4") Console.WriteLine("Четверг");
else if (numberOfTheDay == "5") Console.WriteLine("Пятница");
else if (numberOfTheDay == "6") Console.WriteLine("Суббота");
else if (numberOfTheDay == "7") Console.WriteLine("Воскресенье");
else Console.WriteLine("Нет такого дня недели, либо Вы не корректно ввели данные."); 
