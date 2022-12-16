/*
Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
который найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Task67()
{
    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int counter = 1;
    int sum = 0;
    Console.Write($"Сумма чисел в промежутке от {numberM} до {numberN} равна");
    SegmentSum(numberM, numberN, counter, sum);
}
Task67();

void SegmentSum(int numberM, int numberN, int counter, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($" {sum}");
        return;
    }
    sum += numberM;
    numberM = numberM + counter;
    SegmentSum(numberM, numberN, counter, sum);
}