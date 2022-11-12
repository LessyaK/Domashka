///Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0
Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = CreateArrayRndInt(size, -100, 100);
PrintArray(num);
OddNumbersSum(num);


//Функции
//создание массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//печать массива
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


//Cумма элементов на нечетных позициях

void OddNumbersSum(int[] numbers)
{
int sum = 0;

for (int z = 1; z < numbers.Length; z += 2)
    sum = sum + numbers[z];

Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sum}");
}