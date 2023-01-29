// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите число строк, будущего трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов, будущего трехмерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, глубину будущего трехмерного массива: ");
int depths = Convert.ToInt32(Console.ReadLine());
int min = 10;
int max = 99;

if (rows * columns * depths > 90)
{
    Console.WriteLine("Невозможно заполнить матрицу таких размеров неповторяющимися двузначными числами.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Полученный трехмерный массив: - > ");
    Console.WriteLine();
    int[,,] matrix3D = CreateArray3D(rows, columns, depths, min);
    Print3DMatrix(matrix3D);
}


int[,,] CreateArray3D(int row, int column, int dep, int minimum)
{
    int number = minimum;
    int[,,] array3D = new int[rows, columns, dep];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = number;
                number += 1;
            }
        }
    }
    return array3D;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(1) - 1)
                {
                    Console.Write($"{matrix[i, j, k],2} ({i} {j} {k}), ");
                } 
                else Console.Write($"{matrix[i, j, k],2} ({i} {j} {k})  ");
            }

        }
        Console.WriteLine("]");
    }
}
