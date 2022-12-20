// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdDigitOfNumber(number);
if (result == -1) Console.WriteLine("Третьей цифры у числа нет.");
else Console.WriteLine($"Третья цифра введенного числа: {result}");

int ThirdDigitOfNumber(int num)
{
    if (Math.Abs(number) < 100) return -1;
    if (Math.Abs(number) >= 100 & Math.Abs(number) < 1000) return Math.Abs(number) % 10;
    else
    {
        while (Math.Abs(number) > 999)
        {
            number = Math.Abs(number) / 10;
        }
        int res = number % 10;
        return res;
    }
}