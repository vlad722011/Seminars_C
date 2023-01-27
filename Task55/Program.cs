// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
PrintMatrix(matrix);
Console.WriteLine();
if(rows == columns)
{
//int [,] replacingRowsWithColumns = ReplacingRowsWithColumns(matrix);
//PrintMatrix(replacingRowsWithColumns);

ReplacingRowsWithColumns(matrix);
PrintMatrix(matrix);

}
else
{
Console.WriteLine("Невозможно поменять строки со стлобцами.");
Console.WriteLine("Количество строк во входящем массиве не равно количеству столбцов");
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("]");
    }
}

/*
int [,] ReplacingRowsWithColumns(int [,] matrix)
{
    int [,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix [j, i];
        }
    }
return newMatrix;
}
*/

void ReplacingRowsWithColumns(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix [i, j];
            matrix [i, j] = matrix [j, i];
            matrix [j, i] = temp;
        }
    }
}