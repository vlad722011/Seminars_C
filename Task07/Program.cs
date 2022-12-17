// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра введенного числа {number} - цифра {result}.");
}
else if (number >= -999 && number <= -100)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра введенного числа {number} - цифра {-result}.");
}
else Console.WriteLine("Это не трехзначное число.");

