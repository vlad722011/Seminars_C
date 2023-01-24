// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// [ 1   4   7   2 ]
// [ 5   9   2   3 ]
// [ 8   4   2   4 ]

// Пользователь вводит позицию элемента - > 1, 7 
// Получает ответ -> такого элемента в массиве нет.
// Пользователь вводит позицию элемента - > 1, 1
// Получает ответ -> Значение элемента таблицы в позиции 1, 1 ->  равно 1. 

Console.WriteLine("Ввведите позицию элемента таблицы, значение которого желаете узнать.");
Console.WriteLine("Введите номер строки.");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца.");
int column = Convert.ToInt32(Console.ReadLine());
if (row < 0 || column < 0)
{
    Console.WriteLine("У таблицы не может быть отрицательный номер строки или столбца.");
    Console.WriteLine("Введите корректные данные!");
}

else
{
    Console.WriteLine("Количество строк входящего массива будет выбрано случайно из диапазона от 1 до 10");
    Random rnd = new Random();
    int rows = rnd.Next(1, 11);
    Console.WriteLine("Количество столбцов входящего массива будет выбрано случайно из диапазона от 1 до 10");
    int columns = rnd.Next(1, 11);

    Console.WriteLine("Массив будет заполнен случайными числами из диапазона от -100 до 100");
    int min = rnd.Next(-100, 101);
    int max = rnd.Next(-100, 101);
    if (min > max)
    {
        int temp = min;
        min = max;
        max = temp;
    }

    int[,] array2D = CreateMatrixRndInt(rows, columns, min, max);
    Console.WriteLine("Входящий массив -> ");
    PrintMatrix(array2D);
    Console.WriteLine();
    int result = ElementValue(array2D);
    if (result != Int32.MinValue)
    {
        Console.WriteLine($"Значение элемента в позиции {row}, {column} равно: - > {result}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("В таблице нет элемента с такой позицией!");
        Console.WriteLine();
    }
}


int ElementValue(int[,] arr)
{
    int res;
    if ((row > 0 && row <= arr.GetLength(0)) && (column > 0 && column <= arr.GetLength(1)))
    {
        res = arr[(row - 1), (column - 1)];
        return res;
    }
    else
    {
        res = Int32.MinValue;
        return res;
    }
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
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}