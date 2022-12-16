// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max > number2)  max = max;
else if (number2 >= max)  max = number2;
else;

if (max > number3)  max = max;
else  if (number3 >= max)  max = number3;
else;

Console.WriteLine($"Максимальное из введенных чисел равно {max}");