// Задача 33. Задайте массив. Напишите программу, которая определяет
// присутствует ли заданное число в массиве.
// Например. Имеем массив [6, 7, 19, 345, 3]. Ищем число 4 в массиве. Получаем ответ -> 
// "Числа 4 нет в массиве -> [6, 7, 19, 345, 3]".
// Ищем число 19 в массиве. Получаем ответ -> "Число 19 есть в массиве -> [6, 7, 19, 345, 3]".

Console.WriteLine("Введите число, длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);
Console.WriteLine("Введите число, которое ищете в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isExist = IsExist(array, number);
if (isExist)
{
    Console.Write($"Число {number} есть в массиве: -> ");

}
else Console.Write($"Числа {number} нет в массиве: -> ");
PrintArray(array);

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

bool IsExist(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}
