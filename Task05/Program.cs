﻿// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

/*
Андрей, доброго дня. В живую присутствовать на семинарах не получается, так как у меня это ночь.
Поэтому на самом семинаре не мог задать вопрос по этой задаче.
Мне кажется, что на семинаре не корректно решили эту задачу. В решении, приведенном на семинаре,
рассматривается лишь случай, если пользователь ввел положительное число. Но пользователь
может ввести отрицательное число. И в этом случае решение, полученное на семинаре - приведет 
к ошибке. В выводе мы увидим только это число, и не увидим всего диапазона от -N до N. 
Поэтому я думаю, что код необходимо немного дополнить. Например, вот так:
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = -number;
if (number == 0) Console.Write(number);
else if (number > 0)
{
    while (start <= number)
    {
        Console.Write(start + " ");
        start = start + 1;
    }
}
else
{
start = -start;
number = -number;
while (start <= number)
    {
        Console.Write(start + " ");
        start = start + 1;
    }
}
