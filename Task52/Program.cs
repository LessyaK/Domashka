//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.}


Console.WriteLine("Введите целое число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(array2D);
double[] arr = ArithmeticMeanMatrix(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(arr);

//Функция создания целого двумерного массива

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//Функция печати целого двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

//Функция нахождения среднего арифметического по столбцам матрицы

double[] ArithmeticMeanMatrix(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)

    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        array[j] = sum / matrix.GetLength(0);
        sum = 0;
    }
    return array;
}


//Функция печать массива вещественных чисел
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{Math.Round(numbers[i], 1, MidpointRounding.AwayFromZero)}    ");
    }
    Console.Write("]");
    Console.WriteLine();
}

