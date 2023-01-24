// Задача 48. Задайте двумерный массив размера m на n,
// где каждый элемент в массиве находится по формуле
// Amn = m + n.
// Выведете полученный массив на экран.
// m = 3, n = 4.
// [0, 1, 2, 3]
// [1, 2, 3, 4]
// [2, 3, 4, 5].

int rows = 3;
int columns = 4;
int[,] array2D = CreateMatrixSumIndex(rows, columns);
PrintMatrix(array2D);

int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i + j;
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

