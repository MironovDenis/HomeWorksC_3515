/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
6, 1, -33 -> [1, 6, -33] */

void Task29()
{
    int[] NewArray()
    {
        Console.WriteLine("Задаем массив из 8 случайных чисел:");
        int n = 8;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(-100, 100);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine();

    }

    void SortArrayModule(int[] array)
    {
        Console.WriteLine("Выводим отсортированный по модулю массив чисел:");
        int temp = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] * array[i] > array[j] * array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }

    int[] arr = NewArray();
    PrintArray(arr);
    SortArrayModule(arr);
    PrintArray(arr);
}

Task29();