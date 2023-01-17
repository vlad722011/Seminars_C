// Задача 31. 
// 1. Задайте массив, состоящий из 12 элементов. 
// 2. Заполненнить случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму положительных элементов массива.
// 4. Найдите сумму отрицательных элементов массива.
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных числе равна 29, сумма отрицательных чисел равна -20.


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumPositive = GetSumPositiveElements(array);
int sumNegative = GetSumNegativeElements(array);
Console.WriteLine($"Сумма положительных элементов массива равна = {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива равна = {sumNegative}");

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

int GetSumPositiveElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) sum += arr[i];
    }
    return sum;
}

int GetSumNegativeElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
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