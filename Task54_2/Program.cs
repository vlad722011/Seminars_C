// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// [1  4  7  2]
// [5  9  2  3]
// [8  4  2  4]
// В итоге получается вот такой массив:
// [7  4  2  1]
// [9  5  3  2]
// [8  4  4  2]

Console.WriteLine("Введите число строк, будущего двумерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов, будущего двумерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrixRndInt(rows, columns, min, max);
Console.WriteLine("Входящий массив: - > ");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Полученный массив с отсортированными по убыванию строками: - > ");
Console.WriteLine();
int[,] newMatrix = GetMatrixWithSortRows(matrix);
PrintMatrix(newMatrix);
Console.WriteLine();


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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("]");
    }
}

int[] SplitInToRows(int[,] arr2D, int indexRow)
{
    int[] arr = new int[arr2D.GetLength(1)];
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        arr[j] = arr2D[indexRow, j];
    }
    return arr;
}

int[] SortArray(int[] arr)
{
    int count = 0;
    int temp = 0;
    int index = 0;
    int maximum = Int32.MinValue;
    while (count < arr.Length)
    {
        for (int i = count; i < arr.Length; i++)
        {
            if (arr[i] > maximum)
            {
                maximum = arr[i];
                index = i;
            }
        }
        temp = arr[count];
        arr[count] = arr[index];
        arr[index] = temp;
        count += 1;
        maximum = Int32.MinValue;
    }
    return arr;
}

int[,] GetMatrixWithSortRows(int[,] arr2D)
{
    int[,] newArr2D = new int[arr2D.GetLength(0), arr2D.GetLength(1)];
    for (int i = 0; i < newArr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            int[] arr = SplitInToRows(arr2D, i);
            SortArray(arr);
            newArr2D[i, j] = arr[j];
        }
    }
    return newArr2D;
}