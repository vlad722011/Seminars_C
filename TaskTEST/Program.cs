// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// [ 01  02  03  04 ]
// [ 12  13  14  05 ]
// [ 11  16  15  06 ]
// [ 10  09  08  07 ]

int number = 1; //стартовое значение первого элемента матрицы
int width = 4; // ширина рисуемого прямоугольника
int height = 8; // высота рисуемого квадрата
int rows = 12; // количество строк исходной матрицы
int columns = 12; // количество столбцов исходной матрицы
int rowFirst = 0;  // индекс строки стартового элемента
int colFirst = 0; //индекс столбца стартогвого элемента

int counter = Counter(width, height);
Console.WriteLine($"{counter}");
int[,] matrix = new int[rows, columns];
int[] arrStart = new int[5] { number, width, height, rowFirst, colFirst };
for (int i = 0; i < counter; i++)
{
    if (height % 2 == 0 && width % 2 == 0 && height == width)
    {
        matrix = DrawSquare(arrStart, matrix);
        arrStart = TempArray(arrStart);
    }
    if (height % 2 == 0 && width % 2 == 0 && height > width)
    {
        if (i != counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
        }
        else if (i == counter - 1)
        {
            DrawSquare1(arrStart, matrix);
        }
    }
    else if (height % 2 == 0 && width % 2 == 0 && height < width)
    {
        if (i != counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
        }
        if (i == counter - 1)
        {
            matrix = DrawSquareLastRow(arrStart, matrix);
            matrix = DrawSquareLastRowDown(arrStart, matrix);
        }
    }
    else if (height % 2 == 1 && width % 2 == 0)
    {
        if (i != counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
        }
        if (i == counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
            matrix = DrawSquareLastRow(arrStart, matrix);
        }
    }
    else if (height % 2 == 0 && width % 2 == 1)
    {
        if (i != counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
        }
        if (i == counter - 1)
        {
            matrix = DrawSquareLastCol(arrStart, matrix);
        }
    }
    else if (height % 2 == 1 && width % 2 == 1)
        if (i != counter - 1)
        {
            matrix = DrawSquare(arrStart, matrix);
            arrStart = TempArray(arrStart);
        }
    if (i == counter - 1)
    {
        if (height % 2 == 1 && width % 2 == 1 && width >= height)
        {
            matrix = DrawSquareLastRow(arrStart, matrix);
        }
        else if (height % 2 == 1 && width % 2 == 1 && width < height)
        {
            matrix = DrawSquareLastCol(arrStart, matrix);
        }
    }
}
Console.WriteLine("Заполненная матрица: -> ");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();

int[,] DrawSquare(int[] arr, int[,] matrix)
{
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    // рисуем верх квадрата
    for (int j = indexCol; j < (indexCol + arr[1]); j++)
    {
        matrix[indexRow, j] = num;
        num += 1;
    }
    // рисуем правый край квадрата
    indexCol = arr[4] + arr[1] - 1;
    for (indexRow = arr[3] + 1; indexRow < arr[3] + arr[2] - 1; indexRow++)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
    }
    // рисуем низ квадрата
    indexCol = arr[4] + arr[1] - 1;
    indexRow = arr[3] + arr[2] - 1;
    for (int k = indexCol; k >= arr[4]; k--)
    {
        matrix[indexRow, k] = num;
        num += 1;
    }
    // рисуем левый край квадрата
    indexCol = arr[4];
    for (indexRow = arr[3] + arr[2] - 2; indexRow > arr[3]; indexRow--)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
    }
    return matrix;
}

int[,] DrawSquareLastRow(int[] arr, int[,] matrix)
{
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    for (int j = indexCol; j < (indexCol + arr[1]); j++)
    {
        matrix[indexRow, j] = num;
        num += 1;
    }
    return matrix;
}

int[,] DrawSquareLastCol(int[] arr, int[,] matrix)
{
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    for (indexRow = arr[3]; indexRow < arr[3] + arr[2]; indexRow++)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
    }
    return matrix;
}

int[,] DrawSquareLastRowDown(int[] arr, int[,] matrix)
{
    int num = arr[0] + arr[1];
    int indexRow = arr[3] + 1;
    int indexCol = arr[4] + arr[1] - 1;
    for (int k = indexCol; k >= arr[4]; k--)
    {
        matrix[indexRow, k] = num;
        num += 1;
    }
    return matrix;
}

int[,] DrawSquare1(int[] arr, int[,] matrix)
{
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    // рисуем верх квадрата
    for (int j = indexCol; j < (indexCol + arr[1]); j++)
    {
        matrix[indexRow, j] = num;
        num += 1;
    }
    // рисуем правый край квадрата
    indexCol = arr[4] + arr[1] - 1;
    for (indexRow = arr[3] + 1; indexRow < arr[3] + arr[2]; indexRow++)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
    }
    //рисуем левый край
    num = arr[0] + arr[2] + 1;
    indexCol = arr[4];
    for (indexRow = arr[3] + arr[2] - 1; indexRow > arr[3]; indexRow--)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
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

int Counter(int width, int height)
{
    int countWidth = 0;
    if (width % 2 == 0) countWidth = width / 2;
    else countWidth = width / 2 + 1;
    int countHeight = 0;
    if (width % 2 == 0) countHeight = height / 2;
    else countHeight = height / 2 + 1;
    int count = 0;
    if (countHeight < countWidth) count = countHeight;
    else count = countWidth;
    return count;
}

int[] TempArray(int[] arr)
{
    number = number + (2 * width) + (2 * (height - 2));
    width = width - 2;
    height = height - 2;
    colFirst += 1;
    rowFirst += 1;
    arr = new int[5] { number, width, height, rowFirst, colFirst };
    return arr;
}
