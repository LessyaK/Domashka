//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

InputArray(array);
PrintArray(array);
Console.WriteLine($"Количество положительных элементов в массиве = {CountDigitPositive(array)} ");

// Функция ввода массива
void InputArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }
}

//Функция вывода массива на экран
void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

//Функция подсчета чисел больше нуля в массиве
int CountDigitPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count = count + 1;
    }
    return count;
}
