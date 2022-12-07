// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

void Task56()
{
    Console.Write("Задайте количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix, 0, 10);
    PrintMatrix(matrix);
    FindMinSumRow(matrix);
}

void FillMatrix(int[,] matrix, int minValue, int maxValue)
{
    maxValue++;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
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
    Console.WriteLine();
}

void FindMinSumRow(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < columns; j++)
    {
        minRow += matrix[0, j];
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            sumRow += matrix[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов - {minSumRow + 1}");
}

Task56();