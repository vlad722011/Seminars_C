// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remainderOfTheDivision = number % 2;
if (remainderOfTheDivision == 0) Console.WriteLine($"Число {number} - чётное.");
else Console.WriteLine($"Число {number} - нечётное.");
