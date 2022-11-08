//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
InputArray(array);
PrintArray(array);


// Функция ввода массива
void InputArray(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}й элемент массива: ");
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
