/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

void Task34()
{
    int[] NewArray()
    {
        Console.Write("Задайте размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = new Random().Next(100, 1000);
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

    void CountArrayEven(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) result++;
        }
        Console.WriteLine($"Колличество четных чисел в массиве - {result}");
    }

    int[] arr = NewArray();
    PrintArray(arr);
    CountArrayEven(arr);

}

Task34();
