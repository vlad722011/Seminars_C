// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

string message1 = "Да";
string message2 = "Нет";
bool result = SquareNumber(number1, number2);
Console.WriteLine(result ? message1 : message2);

bool SquareNumber(int num1, int num2)
{
    bool res =  number1 * number1 == number2 ||  number2 * number2 == number1;
    return res;
}