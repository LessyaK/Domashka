//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите целое число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] array2D = CreateDoubleMatrixRndInt(m, n, -10, 10);
PrintDoubleMatrix(array2D);

//Функция создания массива вещественных чисел

double[,] CreateDoubleMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
        }
    }
    return matrix;
}

//Функция печати массива вещественных чисел

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 1, MidpointRounding.AwayFromZero),5} | ");
            else Console.Write($"{Math.Round(matrix[i, j], 1, MidpointRounding.AwayFromZero),5}");
        }
        Console.WriteLine(" |");
    }
}

