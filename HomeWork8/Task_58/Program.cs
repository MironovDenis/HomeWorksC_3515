// Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.

void Task58()
{
    int rows = 5;
    int columns = 5;

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix);
    PrintMatrix(matrix);

}

void FillMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= matrix.Length)
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < columns - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > columns - 1) j--;
        else i--;
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

Task58();