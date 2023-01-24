// Задача 46. Задайте двумерный массив, размером M x N,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1, 4, 8, 19
// 5, -2, 33, -2
// 77, 3, 8, 1

int rows = 3;
int columns = 4;
int min = -99;
int max = 99;

int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
PrintMatrix(array2D);


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
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }

}


