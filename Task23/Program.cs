// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

TableCube(num);


//ФУНКЦИИ---------------------------------------------------------------------------
//Функция формирует таблицу кубов от 1 до заданного числа N

void TableCube(int number)
{
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count,4} | {count * count*count,4}"); 
        count++;
    }
}