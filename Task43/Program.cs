//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double numB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double numB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double numK2 = Convert.ToInt32(Console.ReadLine());

double numX = StraightLineCrossX(numK1, numK2, numB1, numB2);
double numY = StraightLineCrossY(numK1, numB1, numX);
Console.WriteLine($"Точка пересечения двух прямых ({numX};{numY})");

//Функция нахождения точки пересечения двух прямых X
double StraightLineCrossX(double k1, double k2, double b1, double b2)
{
double x = (b2-b1)/(k1-k2);
return x;
}

//Функция нахождения точки пересечения двух прямых Y
double StraightLineCrossY(double k1, double b1, double x)
{
double y = k1*x+b1;
return y;
}