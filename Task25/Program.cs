// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое целое число, которое будем возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число (натуральное), в какую степень будем возводить первое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b <= 0) Console.WriteLine("Вы ввели не натуральное число.");
else PrintExponentiation();


// метод возводящий число А в степень B.

int Exponentiation(int x, int y)
{
    int result = 1;
    while(y > 0)
    {
        result = result * x;
        y = y - 1;
    }
    return result;
}

// Метод, отвечающий за вывод результата в консоль.

void PrintExponentiation()
{
    int result = Exponentiation(a, b);
    Console.WriteLine($"Результат возведения числа {a} в степень {b} равен - {result}.");
    Console.WriteLine();
}
