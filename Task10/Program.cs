// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
   Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
  Console.WriteLine(DigitSecond(num));
}

//ФУНКЦИИ-----------------------------------------------
//Функция возвращает вторую цифру трехзначного числа

int DigitSecond(int number)
{ 
    int result = ((number / 10) % 10);
    return result;
}
