/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

void Task13()
{
    Console.Write("Вводим число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры в числе нет");
    }
    else if (number >= 100)
    {
        while (number > 1000) number = number / 10;        
        Console.Write("Выводим третью цифру числа: ");
        int a = number % 10;
        System.Console.WriteLine(a);
    }
}
Task13();
