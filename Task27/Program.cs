//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = SumNumber(num);
Console.WriteLine($"сумма цифр в числе {num} = {num1}");



//Функция принимает число и возвращает сумму цифр в числе
int SumNumber(int number)
{
    int count = 0;
    int number1 = Math.Abs(number); 
    while (number1 >= 1)
    {
        int number2= number1 % 10;
        count= count+number2;
        number1=number1/10;
    }
    return count;
}

