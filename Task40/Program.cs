// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = triangleExists(number1, number2, number3);
string yes = $"Треугольник со сторонами {number1}, {number2}, {number3} существует.";
string no = $"Треугольника со сторонами {number1}, {number2}, {number3} не существует.";


if(result == true) Console.WriteLine(yes);
else Console.WriteLine(no);

Boolean triangleExists(int num1, int num2, int num3)
{
    return (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2)) ? true : false;
}