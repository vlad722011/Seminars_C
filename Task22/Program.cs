// Напишите программу, которая принимает на вход число (N) и выдает на выходе
// таблицу увадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 1 -> 1, 4.

Console.WriteLine("Введите натуральное число: ");
Console.Write("N:- ");
int number = Convert.ToInt32(Console.ReadLine());
string outputLine = $"{number} - > ";

Console.Write(outputLine);


/*
В цикле, в котором мы в строку вывода поочереди добавляем значения квадратов чисел
через  запятую, чтобы  после  крайнего числа поставить точку, пока ничего лучше не 
придумал, кроме  как  вынести  вычисление последнего значения за цикл, чтобы иметь 
возможность в  конце строки вывода поставить точку. Если все полностью вычислять в 
цикле, то  не придумал  как  убрать запятую, после карйнего значения, перед точкой. 
В такой реализации - получаю красивый вывод. 
*/

if (number <= 0) Console.WriteLine("Вы ввели не натуральное число.");
else 
{
    int count = 1;
    while (count < number)
    {
        double numbersSquares = NumbersSquares(count);
        Console.Write(numbersSquares + ", ");
        count++;
    }
    Console.Write(NumbersSquares(number) + ".");
}

double NumbersSquares(int num)
{
    double squares;
    return squares = Math.Pow(num, 2);
}