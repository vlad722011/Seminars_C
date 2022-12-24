// Напишите программу, которая принимает на вход число (N) и выдает 
// таблицу кубов чисел от 1 до N.

Console.Write("Введите натуральное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Вы ввели не натуральное число.");
else
{
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
    TableCubing(number);
}


void TableCubing(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,6} {Math.Pow(count, 3),6}");
        count++;
    }
}