//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки 1");
Console.Write("Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки 2");
Console.Write("Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);

Console.Write($"расстояние равно {Math.Round(distance, 2, MidpointRounding.AwayFromZero)}");


// ФУНКЦИИ-----------------------------------------------------------
// Функция возвращает расстояние между 2мя точками в 3D пространстве
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double d = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
    return d;
}