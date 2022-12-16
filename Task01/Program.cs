// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.

// a = 25; b = 5 -> да
// a = 10; b = 2 -> нет
// a = -3; b = -3 -> нет
// a = -3; b = 9 -> да


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number2 * number2;

if (square == number1)
{
    Console.WriteLine("Да, первое число является квадратом второго числа.");
}
else
{
    Console.WriteLine("Нет, первое число не является квадратом второго числа.");
}


