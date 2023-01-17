// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример: -> [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите число, длину будущего входящего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());



double[] array = CreateArrayRndDouble(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArrayDouble(array);
double maxElementOfArray = GetMaxElementOfArray(array);
double minElementOfArray = GetMinElementOfArray(array);
double result = maxElementOfArray - minElementOfArray;
Console.WriteLine($"Разность между максимальным и минимальным элементами массива = {result}.");


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}


void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "  ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double GetMaxElementOfArray(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i + 1] > maxElement) maxElement = arr[i + 1];
    }
    return maxElement;
}

double GetMinElementOfArray(double[] arr)
{
    double minElement = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i + 1] < minElement) minElement = arr[i + 1];
    }
    return minElement;
}