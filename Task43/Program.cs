// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Примеры:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значение коэффициента b1.");
double b1 = (double) Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента b2.");
double b2 = (double) Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента k1.");
double k1 = (double) Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение коэффициента k2.");
double k2 = (double) Convert.ToInt32(Console.ReadLine());

if(k1==k2) Console.WriteLine("Прямые параллельны. Они не пересекаются.");
else
{
Console.WriteLine("Две прямые, заданные уравнениями:-> y = k1 * x + b1 и y = k2 * x + b2, пересекаются в точке с координатами: ");
double [] pointСoordinates = PointCoordinates(b1, b2, k1, k2);
PrintCoordinates(pointСoordinates);
}



// Чтобы не запутаться самому где какие коэффициенты, и чтобы в то же время не путать параметры, 
// передаваемые в метод с глобальными переменными - имена переменных-параметров метода 
// назвал максимально похожими именами на имена глобальных переменных. Так - глобальной 
// переменной b1 - соответствует перменная-параметр метода bb1. И так далее...

double[] PointCoordinates(double bb1, double bb2, double kk1, double kk2)
{
    // метод вернет в результате работы массив из 2 элементов, с координатами точки.
    // точка на плоскости имеет 2 координаты, поэтому размер массива size = 2.

    int size = 2; 
    double [] point = new double [size];
    point[0] = (bb2 - bb1) / (kk1 - kk2);
    point[1] = kk1 * point[0] + bb1;
    return point;
}

void PrintCoordinates(double[] arr)
{
    double x = Math.Round(arr[0], 1);
    double y = Math.Round(arr[1], 1);
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
}
