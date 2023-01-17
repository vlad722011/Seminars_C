// Напищите программу, которая заменяет элементы массива: 
// положительные элементы массива замените на соответствующие
// отрицательные, и наоборот.
// Например: [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.WriteLine("Введите число, длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);
Console.Write("Измененный массив: -> ");
CreateInversArray(array);
PrintArray(array);
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void CreateInversArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
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
