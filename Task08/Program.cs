// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.


Console.Write("Введите число: ");
int finiteNumber = Convert.ToInt32(Console.ReadLine());

int remainderOfTheDivision = finiteNumber % 2;

if (remainderOfTheDivision != 0) finiteNumber = finiteNumber-1;

int initialNumber = 2;
while(initialNumber <= finiteNumber)
{
    Console.Write(initialNumber + " ");
    initialNumber +=2;
}