// Задача 54. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task54()
{
    int rows = 3;
    int columns = 4;

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix, -50, 50);
    PrintMatrix(matrix);
    SortRowsToMin(matrix);
    PrintMatrix(matrix);
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
}

void SortRowsToMin(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int temp = 0;
        for (int j = 0; j < columns; j++)
        {
            for (int x = j + 1; x < columns; x++)
            {
                if (matrix[i, j] > matrix[i, x])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, x];
                    matrix[i, x] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

Task54();