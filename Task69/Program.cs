// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 < 0) Console.WriteLine("Это не натуральное число");
else
{
    int result = Exponentione(number1, number2);
    Console.WriteLine(result);

    int Exponentione(int num1, int num2)
    {
        if (num2 == 0) return 1;
        return num1 * Exponentione(num1, num2 - 1);
    }
}