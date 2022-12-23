// Напишите программу, которая принимает на вход число (N) и выдает на выходе
// таблицу увадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 1 -> 1, 4.

Console.WriteLine("Введите натуральное число: ");
Console.Write("N:- ");
int number = Convert.ToInt32(Console.ReadLine());
string outputLine = $"{number} - > 1"; //  квадрат единице равен единице, поэтому, какое бы число 
                                   //  не ввел пользователь, в нашем выводе первым значением
                                   //  всегда будет единица.

Console.Write(outputLine);   

// делаем проверку, натуральное ли число ввел пользователь.
if (number > 0)
{
    int count = 2;  // здесь значение счетчика начинается с двух, так как квадрат единицы нет
                    // смысла высчитывать, единица выведена сразу по умолчанию в строке вывода.
    while (count <= number)
    {
        double numbersSquares = NumbersSquares(count);
        Console.Write(", " + numbersSquares);    // добавляем к строке вывода квадраты чисел
        count++;
    }   
}
else Console.WriteLine("Вы ввели не натуральное число.");
Console.Write(".");    //  в конце вывода ставим точку.


// собственно сам метод, подсчитывающий квадраты чисел.

double NumbersSquares(int num)
{
    double squares;
    return squares = Math.Pow(num, 2);
}