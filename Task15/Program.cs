// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели:");
int numberOfWeekDay = Convert.ToInt32(Console.ReadLine());

int result = WorkingDayOrNot(numberOfWeekDay);
if(result == -1) Console.WriteLine("Нет такого дня недели");
if(result == 0) Console.WriteLine("День выходной");
if(result == 1) Console.WriteLine("День рабочий");

int WorkingDayOrNot(int num)
{
    if(numberOfWeekDay < 1 || numberOfWeekDay > 7) return -1;
    if(numberOfWeekDay == 6 || numberOfWeekDay == 7) return 0;
    else return 1;
}