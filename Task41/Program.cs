// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Примеры:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите сколько следующих чисел будет участвовать в проверке условия задачи?");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите числа:");
int [] userSeries = UserSeries(size);
int result = CountOfNumbersGreaterThanZero(userSeries);
Console.Write($"Среди введеныx чисел  -> ");
PrintArray(userSeries);
Console.WriteLine($" -> {result} чисел(числа,число) > 0.");

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

int CountOfNumbersGreaterThanZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }
    return count;
}

int[] UserSeries(int num)
{
    int[] userSeries = new int[num];
    for (int i = 0; i < num; i++)
    {
        userSeries[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userSeries;
}
