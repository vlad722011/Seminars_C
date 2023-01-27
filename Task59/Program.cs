// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// [1  4  7  2]
// [5  9  2  3]
// [8  4  2  4]
// [5  2  6  7]
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// [9  2  3]
// [4  2  4]
// [2  6  7]

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
Console.WriteLine("Входящий двумерный массив: -> ");
PrintMatrix(matrix);
Console.WriteLine();
int[] array = FindMinElement(matrix);
Console.WriteLine("В полученном одномерном массиве: ");
PrintArray(array);
Console.WriteLine("Первый элемент соответствует индексу строки минимального элемента входящего массива.");
Console.WriteLine("Второй элемент соответствует индексу столбца минимального элемента входящего массива.");
Console.WriteLine("Третий элемент соответствует минимальному элементу входящего массива.");
Console.WriteLine();
int [,] newMatrix = RemoveRowColumnWithIndexMinElem(matrix, array[0], array[1]);
Console.WriteLine("Искомый двумерный массив: -> ");
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

int[] FindMinElement(int[,] arr2D)
{
    int indexRow = 0;
    int indexColumn = 0;
    int min = arr2D[0, 0];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (arr2D[i, j] < min)
            {
                min = arr2D[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn, min };
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

int[,] RemoveRowColumnWithIndexMinElem(int[,] arr2D, int indexRow, int indexColumn)
{
    int[,] newArray2D = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newArray2D.GetLength(0); i++)
    {
        if (i == indexRow) m++;
        for (int j = 0; j < newArray2D.GetLength(1); j++)
        {
            if (j == indexColumn) n++;
            newArray2D[i, j] = arr2D[m, n];
            n++;
        }     
        m++;
        n = 0;
    }    
    return newArray2D;
}
