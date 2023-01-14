// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите число, длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[] array = new int[size];
CreateArray(array, size);

Console.WriteLine($"Ваш массив, состоит из {size} элементов. Заполнен случайными числами");
Console.WriteLine($"из диапазона чисел от 0 включительно, до 1.");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Или вот в таком виде: ");
PrintArrayOption2(array);
Console.WriteLine();
Console.WriteLine();

// метод, заполняющий массив случайными числами из диапазона от 0 до 1.

void CreateArray(int[] arr, int size)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}

// метод, отвечающий за вывод полученного массива в консоль.

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// Или еще чуть более красивый вывод.
void PrintArrayOption2(int[] arr)

{
    String str = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        str += arr [i] + ", ";
    }
    str = str + arr[arr.Length-1];
    Console.WriteLine($"[{str}]");
}