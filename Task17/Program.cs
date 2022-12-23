// Задача №17. Напишите программу, которая на вход принимает координаты точки (X и Y),
// причем, X != 0, и Y != 0, и выдает номер четверти плоскости, в которой находится
// эта точка.

Console.WriteLine("Введите координаты точки.");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки.");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);
string result = quarter > 0 
                ? $"Указанные координаты соответсвуют четверти {quarter}" 
                : "Введены некорректные координаты точки";

Console.WriteLine(result);                             

int Quarter(int xc, int yc)
{
    if (x > 0 && yc > 0) return 1;
    if (x < 0 && yc > 0) return 2;
    if (x < 0 && yc > 0) return 3;
    if (x > 0 && yc < 0) return 4;
    return 0;
}