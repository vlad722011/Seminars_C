// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
// В случае, есди пользователь введет отрицательное число, будем проверять на полиндром
// только цифровую часть числа, игнорируя его знак.

Console.Write("Введите пятизначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number <= -100000) || (number >= -9999 && number <= 9999) || (number >= 100000))
{
    Console.WriteLine($"Вы ввели число: {number}");
    Console.WriteLine("Это не пятизначное число.");
}
if (number > -100000 && number < -9999)
{
    number = -number; 
}
if(number > 9999 && number < 100000)
{
    CheckingNumberForAPalindrome(number);
}

// собственно сам метод - определяющий палиндром введеное число или нет
void CheckingNumberForAPalindrome(int num)
{
    if (num < 0) num = -num;
    string str = num.ToString();
    int[] array = new int[str.Length];
    // получаю массив состоящий из цифр введенного числа
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
    }
    // получаю перевернутый массив из полученного массива
    int[] reverceArray = new int[array.Length];
    for (int i = 0; i < reverceArray.Length; i++)
    {
        int temp = array[i];
        reverceArray[i] = array[array.Length - i - 1];
        reverceArray[array.Length - i - 1] = temp;
    }
    // получаю из перевернутого массива число,чтобы сравнить его с исходным
    double numberFromArray = 0;
    int count = 0;
    while (count < reverceArray.Length)
    {
        numberFromArray += reverceArray[reverceArray.Length - count - 1] * Math.Pow(10, count);
        count++;
    }
    if (num == numberFromArray) Console.WriteLine($"Введенное число - ПАЛИНДРОМ");
    else Console.WriteLine($"Введенное число - НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ");
}