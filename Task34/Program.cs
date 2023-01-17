// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример: -> [345, 897, 568, 234] -> 2

Console.WriteLine("Введите число, длину будущего входящего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 999;

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);
int evenElementCounter = EvenElementCounter(array);
Console.Write($"Количество четных элементов в массиве  = {evenElementCounter}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int EvenElementCounter(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count += 1;
    }
    return count;
}