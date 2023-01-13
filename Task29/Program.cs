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

Console.WriteLine($"Ваш массив, состоит из {size} элементов. Заполнен случайными числами");
Console.WriteLine($"из диапазона чисел от {x} включительно, до {y}.");
Console.WriteLine();


int [] arr = CreateArray(size, x, y);
Console.WriteLine(PrintArray(arr));
Console.WriteLine();

// второй вариант метода для вывода результата программы в консоль.

PrintArrayOption2(arr);
Console.WriteLine();

// Универсальный метод создания массива любой длины, заполняемого рандомными числами из любых
// диапазонов чисел, выбираемых пользователем. Все операции (в том числе создание массива)
// производятся внутри метода. Метод не void,  метод типа int [], возвращающий сам массив.

int[] CreateArray(int size, int x, int y)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(x, y);
    }
    return array;
}

// метод вывода на печать в красивом виде. Метод не void, метод типа String - возвращает строку.

String PrintArray(int[]array)
{
string s = String.Join(", ", array);
string result = s + " -->  " + $"[{s}]";
return result; 
}

// метод типа void. Ничего не возвращает. Печать происходит внутри метода.
// такой же, как делали на семинаре.

void PrintArrayOption2(int[] array)
{
    string str = "";
    for (int i = 0; i < array.Length - 1; i++)
    {
        str += array[i] + ", ";
    }
    str += array[array.Length-1];
    Console.WriteLine(str + " -->  " + $"[{str}]");
}