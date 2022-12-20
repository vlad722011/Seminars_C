// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine()); 

int result =  MultipleDigits(number1, number2);    
string message1 = "Кратно";
string message2 = $"Не кратно. Остаток от деления => {result}";

Console.WriteLine(result == 0 ? message1 : message2);

int MultipleDigits(int num1, int num2)
{
   return num1 % num2;
}