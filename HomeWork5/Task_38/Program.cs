/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95
*/

void Task38()
{
    Console.Write("Задайте размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[n];

    void NewArray(double[] array)
    {
        for (int i = 0; i < n; i++)
        {
            array[i] = Math.Round((new Random().NextDouble() * 100), 2);
            double x = new Random().Next(-1, 2);
            if (x != 0) array[i] *= x;
        }
    }
    void PrintArray(double[] array)
    {
        Console.Write("[");
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.WriteLine("]");
    }
    double MaxElement(double[] array)
    {
        double max = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        Console.WriteLine($"Максимальный элемент массива: {max}");
        return max;
    }
    double MinElement(double[] array)
    {
        double min = array[1];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i];
            }
        }
        Console.WriteLine($"Минимальный элемент массива: {min}");
        return min;
    }
    void DiffMaxMin(double[] array)
    {
        double diff = Math.Round(MaxElement(array) - MinElement(array), 2);
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diff}");
    }

    NewArray(array);
    PrintArray(array);
    DiffMaxMin(array);
}
Task38();
