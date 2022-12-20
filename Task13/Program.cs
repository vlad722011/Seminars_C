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
    num = Math.Abs(num);
    if (num < 100) return -1;
    if (num >= 100 && num < 1000) return num % 10;
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int res = num % 10;
        return res;
    }
}