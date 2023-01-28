// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// [2  4] | [3  4]
// [3  2] | [3  3]
// Результирующая матрица будет:
// [18  20]
// [15  18]

Console.WriteLine("Введите число строк, первого входящего двумерного массива: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов, первого входящего двумерного массива: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = CreateMatrixRndInt(rows1, columns1, min1, max1);
Console.WriteLine("Входящий массив номер 1: - > ");
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();

Console.WriteLine("Введите число строк, второго входящего двумерного массива: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов, второго входящего двумерного массива: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt(rows1, columns1, min1, max1);
Console.WriteLine("Входящий массив номер 2: - > ");
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();

if (columns1 == rows2)
{
    Console.WriteLine("Входящие матрицы можно умножить.");
    Console.WriteLine("Результат перемножения входящих матриц: - > ");
    Console.WriteLine();
    int[,] matrixMultiplication = MatrixMultiplication(matrix1, matrix2);
    PrintMatrix(matrixMultiplication);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Входящие матрицы нельзя  перемножить.");
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}   ");
        }
        Console.WriteLine("]");
    }
}

int[] SplitInToColumns(int[,] arr2D, int indexCol)
{
    int[] arr = new int[arr2D.GetLength(0)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        arr[i] = arr2D[i, indexCol];
    }
    return arr;
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

int RowMultipliedByColumn(int[] arr1, int[] arr2)
{
    int sum = 0;
    //int [] squareRowCol = new int [arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
        sum += arr1[i] * arr2[i];
    }
    return sum;
}

int[,] MatrixMultiplication(int[,] arr2D1, int[,] arr2D2)
{
    int[,] newMatrix = new int[arr2D1.GetLength(0), arr2D2.GetLength(1)];

    int indexRow = 0;
    while (indexRow < newMatrix.GetLength(0))
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int[] rowMatrix1 = SplitInToRows(arr2D1, indexRow);
            int[] colMatrix2 = SplitInToColumns(arr2D2, j);
            newMatrix[indexRow, j] = RowMultipliedByColumn(rowMatrix1, colMatrix2);
        }
        indexRow++;
    }
    return newMatrix;
}