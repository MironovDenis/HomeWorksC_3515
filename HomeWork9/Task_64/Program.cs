/*
Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

M = 1; N = 9. -> "3, 6, 9"
M = 13; N = 20. -> "15, 18"
*/

void Task64()
{
    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int counter = 1;
    SelectNumber(numberM, numberN, counter);
}
Task64();

void SelectNumber(int numberM, int numberN, int counter)
{
    if (numberM > numberN) return;
    if (numberM % 3 == 0) Console.Write(numberM + " ");
    numberM = numberM + counter;
    SelectNumber(numberM, numberN, counter);
}