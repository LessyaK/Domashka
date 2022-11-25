//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите целое число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2D = CreateMatrixRndInt(m, n, 0, 99);
PrintMatrix(array2D);
Console.WriteLine();

int minSumLine = 0;
int sumLine = SumLineElements(array2D, 0);
for (int i = 1; i < array2D.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2D, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");

//Функция создания целого двумерного массива

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}  ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" ");
    }
}

//Функция подсчета элементов строки
int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}


