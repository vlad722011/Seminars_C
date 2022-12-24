// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A(3,6,8)  B(2,1,-7) -> 15,84
// A(7,-5,0) B(1,-1,9) -> 11,53

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1:- ");
int x1c = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:- ");
int y1c = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1:- ");
int z1c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2:- ");
int x2c = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:- ");
int y2c = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2:- ");
int z2c = Convert.ToInt32(Console.ReadLine());

double dist = SegmentLength(x1c, y1c, z1c, x2c, y2c, z2c); //расстояние между точками с высокой точностью
double distance = Math.Round(dist, 2, MidpointRounding.ToZero); //результат с точностью до 2-ух знаков после запятой
string result = $"Расстояние между точками равно: -> {distance}";
Console.WriteLine(result);

double SegmentLength (int x1, int y1, int z1, int x2, int y2, int z2)
{
int distanceX = x1 - x2;
int distanceY = y1 - y2;
int distanceZ = z1 - z2;
double res = Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2) + Math.Pow(distanceZ, 2));
return res;
}