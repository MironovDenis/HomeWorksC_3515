/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void Task36()
{
    int[] NewArray()
    {
        Console.Write("Задайте размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(-100, 100);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        Console.Write("[");
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine("]");

    }

    void SumArrayOdd(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0) result += array[i];
        }
        Console.WriteLine($"Сумма чисел с нечетными индексами = {result}");
    }

    int[] arr = NewArray();
    PrintArray(arr);
    SumArrayOdd(arr);

}

Task36();