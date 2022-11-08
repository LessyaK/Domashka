// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


Console.WriteLine("Введите целое число А: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numB <= 0)
{
    Console.WriteLine("Введено не натуральное число, повторите ввод");
}

int degree = Degree (a, numB);
Console.WriteLine($"число {a} в степени {numB} = {degree}");

/// функция возведение в степень
int Degree(int number1, int number2)
{
    int deg = 1;
    for (int i = 1; i <= number2; i++)
    {
        deg = deg*number1;
    }
    return deg;
}