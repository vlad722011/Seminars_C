// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    int temp = number1;
    number1 = number2;
    number2 = temp;
}
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Не все введеные числа натуральные.");
}
else
{
    int sum = SumNaturalElementRange(number1, number2);
    Console.WriteLine($"Сумма натуральных элементов в заданном диапазоне равна: {sum}");
    Console.WriteLine();
    SumNaturalElementRange(number1, number2);
}

int SumNaturalElementRange(int num1, int num2)
{
    if (num1 == 0 && num2 == 0) return num1;
    if (num1 == num2) return num1;
    return num1 + SumNaturalElementRange(num1 + 1, num2);
}