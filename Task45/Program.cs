// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите число, длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);

Console.Write("копия входящего массива: -> ");
int [] copyArray = CopyOFArray(array);
PrintArray(copyArray);

// Чтобы убедиться, что у нас в консоль выводятся два разных массива выведем в консоль
// результат сравнения ссылок на массивы - и убедимся, что ссылки не равны, а значит, мы имеем
// дело с двумя разными массивами.

Console.Write(copyArray == array);


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

int [] CopyOFArray(int [] arr)
{
    int [] copyArr = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr [i] = arr[i];
    } 
    return copyArr;
}