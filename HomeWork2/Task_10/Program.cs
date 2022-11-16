/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

void Task10()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Принимается случайное трехзначное число: " + number);
    Console.WriteLine();
    int a = number / 10;
    int b = a % 10;
    Console.WriteLine("Вторая цифра числа: " + b);
}
Task10();