// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// [1  4  7  2]
// [5  9  2  3]
// [8  4  2  4]
// [5  2  6  7]
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

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
int numberRowMinSum = FindRowWithMinSumOfElements(matrix);
Console.WriteLine($"Строка массива c наименьшей суммой элементов -> строка с индексом [{numberRowMinSum}]");
Console.WriteLine($"Это строка номер {numberRowMinSum + 1} во входящем массиве");
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

int FindRowWithMinSumOfElements(int[,] arr2D)
{
    int indexRowMinSum = 0;
    int minSum = Int32.MaxValue;
    int sumElemRow = 0;
    int indexRow = 0;
    while (indexRow < arr2D.GetLength(0))
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sumElemRow += arr2D[indexRow, j];  
        }
        if (sumElemRow < minSum)
        {
            minSum = sumElemRow;
            indexRowMinSum = indexRow;
        }
        indexRow ++;
        sumElemRow = 0;
    }
    return indexRowMinSum;
}