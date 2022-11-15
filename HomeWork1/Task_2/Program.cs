/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

void Task2()
{
    Console.WriteLine("Введите число а: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.WriteLine("Число a = " + a + " больше числа b = " + b);
    }
    else if (a < b)
    {
        Console.WriteLine("Число a = " + a + " меньше числа b = " + b);
    }
}
Task2();