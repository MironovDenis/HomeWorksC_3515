/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

void Task13()
{
    Console.Write("Введите номер дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (day == 1)
    {
        Console.WriteLine("Понедельник. Будний день. :( ");
    }
    else if (day == 2)
    {
        Console.WriteLine("Вторник. Будний день. :( ");
    }
    else if (day == 3)
    {
        Console.WriteLine("Среда. Будний день. :( ");
    }
    else if (day == 4)
    {
        Console.WriteLine("Четверг. Будний день. :( ");
    }
    else if (day == 5)
    {
        Console.WriteLine("Пятница. Будний день. Завтра выходной! :) ");
    }
    else if (day == 6)
    {
        Console.WriteLine("Суббота. Выходной день. :) ");
    }
    else if (day == 7)
    {
        Console.WriteLine("Воскресенье. Выходной день! Но завтра на работу... :( ");
    }
    else if (day < 1 | day > 7)
    {
        Console.WriteLine("Введено некорректное значение");
    }
}
Task13();