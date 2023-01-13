//  Задача 29: Напишите программу, которая задаёт массив
//  из 8 элементов и выводит их на экран.
//  Сделать красивый вывод вконсоль созданного массива, например вот так:
//  1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите число, длину будущего массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, начало диапазона случайных чисел, которыми будет заполнен массив: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, конец диапазона случайных чисел, которыми будет заполнен массив: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int[] array = new int[size];
CreateArray(array, size, x, y);

Console.WriteLine($"Ваш массив, состоит из {size} элементов. Заполнен случайными числами");
Console.WriteLine($"из диапазона чисел от {x} включительно, до {y}.");
Console.WriteLine();

PrintArray(array);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Или вот в таком виде: ");
PrintArrayOption2(array);
Console.WriteLine();

Console.WriteLine("Или  может вот в таком: ");
PrintArrayOption3(array);
Console.WriteLine();


// метод, заполняющий массив случайными числами из диапазона (x <= number < y).
void CreateArray(int[] arr, int size, int x, int y)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(x, y);
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

//  вариант вывода массива в консоль через строку.

void PrintArrayOption2(int[] arr)
{
    String str = "";

//  Для того, чтобы сделать вывод массива в консоль красивым, в теле цикла в строку через 
//  запятую добавляю элементы массива. Чтобы после последнего элемента массива не добавлялась 
//  запятая, последний элемент массива добавил в строку вне тела цикла. 
  
    for (int i = 0; i < arr.Length - 1; i++)
    {
        str += arr [i] + ", ";
    }
    str = str + arr[arr.Length-1];
    Console.WriteLine($"[{str}]");
}

// Или еще чуть более красивый вывод. Это в качестве дополнительного "набивания руки" при 
// работе со строками.

void PrintArrayOption3(int[] arr)
{
    String str = "";
    for (int i = 0; i < arr.Length - 1; i++)
    {
        str += arr [i] + ", ";
    }
    str = str + arr[arr.Length-1];
    Console.WriteLine("{" + $"{str}" + "} " + $"--> [{str}]");
}