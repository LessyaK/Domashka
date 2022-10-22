// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).


Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

PalindromFive(num);




//ФУНКЦИИ------------------------------------------------------------------

//Проверка, является ли пятизначное число палиндромом
void PalindromFive(int number)
{
    if (number >= 10000 && number <= 99999)
    {

        int division1 = number / 10000;
        int remainder1 = number % 10;

        if (division1 == remainder1)
        {
            number = number / 10;
            int division2 = (number / 100) % 10;
            int remainder2 = number % 10;
            if (division2 == remainder2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");
    }

    else Console.WriteLine("Число не является пятизначным, повторите ввод");
}

