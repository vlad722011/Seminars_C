// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {number} в двоичном исчислении равно: ");
string decimalDigitToBinary = DecimalDigitToBinary(number);
Console.WriteLine(decimalDigitToBinary);
double binaryNumber = DecimalDigitToBinaryVersion2(number);
Console.WriteLine(binaryNumber);

string DecimalDigitToBinary(int num)
{
    string binaryDigit = string.Empty;
    while (num != 0)
    {
        binaryDigit = num % 2 + binaryDigit;
        num = num / 2;
    }
    return binaryDigit;
}

double DecimalDigitToBinaryVersion2(int num)
{
    double binNum = 0;
    int count = 0;
    while (num != 0)
    {
        binNum = (binNum + num % 2 * Math.Pow(10, count));
        count += 1;
        num = num / 2;
    }
    return binNum;
}
