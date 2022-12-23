// Напишите программу, которая принимает на вход число (N) и выдает на выходе
// таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 1 -> 1, 4.

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Таблица квадратов чисел от 1 до {number}:");

if (number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Вы ввели не натуральное число.");

void TableSquare(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count}" + "   " + Math.Pow(count, 2) );
        count ++;
    }
}