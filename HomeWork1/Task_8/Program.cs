/* Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

void Task8()
{
    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int value = 1;
    Console.Write("Вывод четных чисел от 1 до N: ");
    while (value <= N)
    {
        if (value % 2 == 0)
        {
            Console.Write(value + " ");
        }
        value++;
    }

}
Task8();
