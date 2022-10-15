// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.Write("max=a");
}
else
{
    Console.Write("max=b");
}