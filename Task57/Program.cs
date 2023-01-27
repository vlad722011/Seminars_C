// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Пример. Входящий набор данных:

// [1  2  3]
// [4  6  1]
// [2  1  6]

// На выходе получим:

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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
int[] array = Array2DToArray1D(matrix);
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Решил задачу через метод VOID. Результат вывода: - >");
Console.WriteLine();
Dictionary(array);
Console.WriteLine();
int[,] dictionary = DictionaryVersion2(array);
Console.WriteLine("Вариант №2 решения задачи, через метод возвращающий массив. Результат вывода: - >");
Console.WriteLine();
PrintMatrix(dictionary);

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

int[] Array2DToArray1D(int[,] arr2D)
{
    int index = 0;
    int[] arr = new int[arr2D.GetLength(0) * arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[index] = arr2D[i, j];
            index++;
        }
    }
    return arr;
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

void Dictionary(int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($"{number,3}  -> {count,3}");
            number = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{number,3}  -> {count,3}");

}


int[,] DictionaryVersion2(int[] arr)
{
    int count = 1;
    int number = arr[0];
    int countDigits = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            countDigits++;
            number = arr[i];
            count = 1;
        }
    }
    int columns = 2;
    int[,] arr2D = new int[countDigits, columns];
    number = arr[0];
    int quantityCounter = 1;
    int row = 0;
    int col = 0;
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] == number) quantityCounter++;
        else
        {
            arr2D[row, col] = number;
            col ++;
            arr2D[row, col] = quantityCounter;
            row  ++;
            number = arr[i];
            quantityCounter = 1;
            col = 0;
        }
    arr2D[countDigits - 1, 0] = number;
    arr2D[countDigits - 1, 1] = quantityCounter;
    return arr2D;
}



