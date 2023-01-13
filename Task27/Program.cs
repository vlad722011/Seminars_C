// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ввведите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вы ввели число {number}");
Console.WriteLine();

// переменной sum - присваиваем результат работы метода SumDigit().
int sum = SumDigit(number);

// Вывод результата в консоль без написания метода для вывода результата на печать.
Console.WriteLine($"Сумма цифр, составляющих число {number} равна - {sum}.");
Console.WriteLine();

// Вывод результатов в консоль, с использованием метода. 
// В данном примере - это не имеет особого смысла, и тем не менее.

PrintSum(sum);

//  метод подсчитывающий сумму цифр.

int SumDigit(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

// Метод, отвечающий за вывод результата в консоль.

void PrintSum(int num)
{
    Console.WriteLine($"Сумма цифр, составляющих число {number} равна - {sum}.");
    Console.WriteLine();
}