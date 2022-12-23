// Задача №20: Напишите программу, которая принимает на входкоординаты двуч точек
// и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1:- ");
int x1c = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1:- ");
int y1c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2:- ");
int x2c = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2:- ");
int y2c = Convert.ToInt32(Console.ReadLine());

double dist = SegmentLength(x1c, y1c, x2c, y2c); //расстояние между точками с высокой точностью
double distance = Math.Round(dist, 2); //результат с точностью до 2-ух знаков после запятой
string result = $"Расстояние между точками равно: -> {distance}";
Console.WriteLine(result);

double SegmentLength (int firstX, int firstY, int secondX, int secondY)
{
int distanceX = firstX - secondX;
int distanceY = firstY - secondY;
double res = Math.Sqrt(distanceX*distanceX + distanceY*distanceY);
return res;
}