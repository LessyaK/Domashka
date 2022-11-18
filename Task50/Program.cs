//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите целое число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(m, n, 0, 9);
PrintMatrix(array2D);

Console.WriteLine("Введите целое значение индекса строки: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое значение индекса столбца: ");
int c = Convert.ToInt32(Console.ReadLine());

FindElement(array2D, r, c);

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

// Функция поиска элемента в двумерном массиве по заданному индексу

void FindElement(int[,] matrix, int row, int column)
{
    int element = 0;
    if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
    {
        Console.WriteLine("такого элемента в массиве нет");
        
    }
    else
    {
        for (int i = 0; i <= row; i++)
        {
            for (int j = 0; j <= column; j++)
            {
                element = matrix[i, j];
            }
        }
       Console.WriteLine($"Значение элемента с индексами ({row},{column}) = {element}");
    }
}



