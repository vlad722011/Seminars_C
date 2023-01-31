// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigitsOfNumber(number);
Console.WriteLine(sumDigit);

int SumDigitsOfNumber(int num)
{
    if (num  == 0) return 0;
    else return num % 10  + SumDigitsOfNumber(num / 10);
}