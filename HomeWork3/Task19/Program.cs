/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

void Task19()
{
    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int num1 = number % 10;
    int num2 = (number % 100 - num1) / 10;
    int num3 = (number % 1000 - num2) / 100;
    int num4 = (number % 10000 - num3) / 1000;
    int num5 = number / 10000;

    if (number < 10000 | number > 99999)
    {
        Console.WriteLine("Введенное число некорректное число");
    }
    else if (num1 == num5 & num2 == num4)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else if (num1 != num5 || num2 != num4)
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
}
Task19();