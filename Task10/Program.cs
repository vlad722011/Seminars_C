// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigitOfNumber(number);
if(Math.Abs(number) > 99 && Math.Abs(number) < 1000) 
{
Console.WriteLine($"Вторая цифра введенного числа: - {result}");
}
else Console.WriteLine("Это не трехзначное число");

int SecondDigitOfNumber(int num)
{
    num = Math.Abs(number);
    int res = (num / 10) % 10;
    return res;
}