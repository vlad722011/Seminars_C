// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number  = Convert.ToInt32(Console.ReadLine());

int result = SecondDigitOfNumber(number);
Console.WriteLine($"Вторая цифра введенного числа: - {result}");

int SecondDigitOfNumber(int num)
{
    int res = (number/10)%10;
    return res;
}