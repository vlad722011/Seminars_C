// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Ввведите число:");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = 7;
int secondDigit = 23; 
string message1 = "Да";
string message2 = "Нет";

bool result = TwoNumbersMultiple(number, firstDigit, secondDigit);
Console.WriteLine(result? message1 : message2);

bool TwoNumbersMultiple(int num, int firstDig, int secondDig)
{
    bool res = (num % firstDigit == 0 && num % secondDigit == 0);
    return res;
}