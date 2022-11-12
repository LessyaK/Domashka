//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива  ");

int size = Convert.ToInt32(Console.ReadLine());
double[] num = CreateArrayRndDouble(size, -100, 100);
PrintArray(num);
double maxNum = MaxNumber(num);
double minNum = MinNumber(num);

Console.WriteLine($"Максимальное значение = {maxNum}, минимальное значение = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round((maxNum - minNum),2,MidpointRounding.AwayFromZero)}");



//Функция создание массива вещественных чисел
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

//Функция печать массива вещественных чисел
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Функция нахождения минимума в массиве вещественных чисел
double MinNumber(double[] numbers)
{
    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}

//Функция нахожения максимума в массиве вещественных чисел

double MaxNumber(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }

    }
    return max;
}
