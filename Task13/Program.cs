//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(DigitLetf3(num));
}


// ФУНКЦИИ ---------------------------------------------------------------------------------------------
// Функция возвращает третью цифру слева
int DigitLetf3(int number)
{
    while (number / 100 >= 10)
    {
        number = number / 10;
    }
    int digit = number % 10;
    return digit;
}


