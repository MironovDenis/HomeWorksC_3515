/*Задача 47. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
округлёнными до одного знака.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void Task47()
{
    int rows = 3;
    int columns = 4;

    double[,] matrix = new double[rows, columns];
    FillMatrix(matrix);
    PrintMatrix(matrix);
}

void FillMatrix(double[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()*10, 1);
            double x = new Random().Next(-1, 2);
            if (x != 0) matrix[i, j] *= x;
        }
    }
}

void PrintMatrix(double[,] matrix)
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

Task47();