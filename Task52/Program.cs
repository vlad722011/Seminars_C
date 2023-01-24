// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
//  [ 1   4   7   2 ]
//  [ 5   9   2   3 ]
//  [ 8   4   2   4 ]
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк, будущего двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов, будущего двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows < 0 || columns < 0)
{
    Console.WriteLine("У таблицы не может быть отрицательное количество строк или столбцов.");
    Console.WriteLine("Введите корректные данные!");
}
else 
{
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
Console.WriteLine();
Console.WriteLine("Входящий массив: -> ");
Console.WriteLine();
PrintMatrix(array2D);
Console.WriteLine();
double[] array = FindArithmeticAverageOfArrayColumns(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца входящего массива: - > ");
PrintArray(array);
Console.WriteLine();
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

double[] FindArithmeticAverageOfArrayColumns(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            arr[i] += matrix[j, i];
        }
    }
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = Math.Round((arr[k] / matrix.GetLength(0)), 2);
    }
    return arr;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}    ", 4);
        else Console.Write($"{arr[i]} ", 4);
    }
    Console.WriteLine("]");
}