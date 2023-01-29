// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// [ 01  02  03  04 ]
// [ 12  13  14  05 ]
// [ 11  16  15  06 ]
// [ 10  09  08  07 ]

int number = 100; //стартовое значение первого элемента матрицы
int width = 4; // ширина рисуемого прямоугольника
int height = 4; // высота рисуемого квадрата
int countDigits = width * height; // количество элементов, которыми будет заполнена матрица
int rows = 6; // количество строк исходной матрицы
int columns = 6; // количество столбцов исходной матрицы
int rowFirst = 1;  // индекс строки стартового элемента
int colFirst = 1; //индекс столбца стартогвого элемента

int[,] matrix = new int[rows, columns];   //  матрица нужного размера

// создаю массив для передачи данных в метод
int[] arrStart = new int[6] { number, width, height, rowFirst, colFirst, countDigits };

// промежуточные массивы, для передачи в метод, если матрица не заполнена полностью
int[] arrayNext = DrawSquare(arrStart, matrix);
matrix = DrawSquareN2(arrStart, matrix);
// в вернувшемся массиве смотрим сколько элементов еще не заполнено
countDigits = arrayNext[5];

// до тех пор, пока задача не будет выполнена полностью, будем вызывать метод
// заполняющий матрицу 

while (countDigits!=0)
{
    arrayNext = DrawSquare(arrayNext, matrix);
    countDigits = arrayNext[5];
    matrix = DrawSquareN2(arrayNext, matrix);
}

Console.WriteLine("Заполненная матрица: -> ");
PrintMatrix(matrix);


int[] DrawSquare(int[] arr, int[,] matrix)
{
    int count = arr[5];
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    // рисуем верх квадрата
    for (int j = indexCol; j < (indexCol + arr[1]); j++)
    {
        matrix[indexRow, j] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем правый край квадрата
    indexCol = arr[4] + arr[1] - 1;
    for (indexRow = arr[3] + 1; indexRow < arr[3] + arr[2] - 1; indexRow++)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем низ квадрата
    indexCol = arr[4] + arr[1] - 1;
    indexRow = arr[3] + arr[2] - 1;
    for (int k = indexCol; k >= arr[4]; k--)
    {
        matrix[indexRow, k] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем левый край квадрата

    indexCol = arr[4];
    for (indexRow = arr[3] + arr[2] - 2; indexRow > arr[3]; indexRow--)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }

    width = width - 2;
    height = height - 2;
    indexCol += 1;
    colFirst = indexCol;
    indexRow += 1;
    rowFirst = indexRow;
    number = num;
    countDigits = count;

    // промежуточный массив, который возвращается, чтобы его снова передать в метод 
    // заполняющий матрицу кругами, внутрь матрицы.

    arr = new int[6] { number, width, height, rowFirst, colFirst, countDigits };
    return arr;
}

int[,] DrawSquareN2(int[] arr, int[,] matrix)
{
    int count = arr[5];
    int num = arr[0];
    int indexRow = arr[3];
    int indexCol = arr[4];
    // рисуем верх квадрата
    for (int j = indexCol; j < (indexCol + arr[1]); j++)
    {
        matrix[indexRow, j] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем правый край квадрата
    indexCol = arr[4] + arr[1] - 1;
    for (indexRow = arr[3] + 1; indexRow < arr[3] + arr[2] - 1; indexRow++)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем низ квадрата
    indexCol = arr[4] + arr[1] - 1;
    indexRow = arr[3] + arr[2] - 1;
    for (int k = indexCol; k >= arr[4]; k--)
    {
        matrix[indexRow, k] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }
    // рисуем левый край квадрата

    indexCol = arr[4];
    for (indexRow = arr[3] + arr[2] - 2; indexRow > arr[3]; indexRow--)
    {
        matrix[indexRow, indexCol] = num;
        num += 1;
        count -= 1;
        if(count == 0) break;
    }

    width = width - 2;
    height = height - 2;
    indexCol += 1;
    colFirst = indexCol;
    indexRow += 1;
    rowFirst = indexRow;
    number = num;
    countDigits = count;

    arr = new int[6] { number, width, height, rowFirst, colFirst, countDigits };
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
