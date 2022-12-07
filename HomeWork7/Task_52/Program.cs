/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 5 3
8 4 6 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.
*/

void Task52()
{
    int rows = 3;
    int columns = 4;

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    AvgSumColumn(matrix);
}

void FillMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void AvgSumColumn(int[,] matrix)
{
    double rows = matrix.GetLength(0);
    double columns = matrix.GetLength(1);
    Console.WriteLine();
    int count = 1;
    for (int j = 0; j < columns; j++)
    {
        double avgSum = 0;
        for (int i = 0; i < rows; i++)
        {
            avgSum += matrix[i, j];
        }
        Console.WriteLine($"Cреднее арифметическое элементов {count} столбца = {Math.Round(avgSum/rows,2)}");
        count++;
    }
}

Task52();