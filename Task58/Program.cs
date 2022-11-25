//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите целое число строк первой матрицы m1: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов первой метрицы n1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int[,] array2D1 = CreateMatrixRndInt(m1, n1, 0, 9);
Console.WriteLine("Первая матрица");
PrintMatrix(array2D1);

Console.WriteLine("Введите целое число строк второй матрицы m2: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число столбцов второй мaтрицы n2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int[,] array2D2 = CreateMatrixRndInt(m2, n2, 0, 9);
Console.WriteLine("Вторая матрица");
PrintMatrix(array2D2);
if (m1 != n2) Console.WriteLine($"Перемножить матрицы невозможно");
else
{
int[,] resMatrix = new int[m1,n2];
 MultiplyMatrix(array2D1, array2D2, resMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resMatrix);
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
 
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}













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


