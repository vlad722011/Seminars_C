// Задача 37. Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний, и так далее элементы.
// Результат запишите в новом массиве.
// Примеры:
// [1, 2, 3, 4, 5] -> [5, 8, 3]
// [6, 7, 3, 6] -> [36, 21]

Console.WriteLine("Введите число, длину будущего входящего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(size, min, max);
Console.Write("Входящий массив: -> ");
PrintArray(array);
Console.Write("Полученный массив: -> ");
int[] newArray = MultiplicationOfAPairOfNumbers(array);
PrintArray(newArray);


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


int[] MultiplicationOfAPairOfNumbers(int[] arr)
{
    int size;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if(i != arr.Length - 1 -i)
        {
            newArr[i] = arr[i] * arr[arr.Length - 1 - i];
        }
        else newArr[i] = arr[i];
    }
    return newArr;
}
