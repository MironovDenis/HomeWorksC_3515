/*Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 3 -> 3
*/

void Task50()
{
    Console.Write("Задайте количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix, 0, 100);
    PrintMatrix(matrix);
    MatrixElement(matrix);
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

void MatrixElement(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Console.WriteLine();
    Console.Write("Введите номер строки: ");
    int i = Convert.ToInt32(Console.ReadLine()) - 1; // Для тех, кто не знает про нулевую строку и нулевой столбец
    Console.Write("Введите номер столбца: ");
    int j = Convert.ToInt32(Console.ReadLine()) - 1;
    if (i <= 0 || j <= 0 || i >= rows || j >= columns) Console.WriteLine("Такого элемента нет");
    else Console.Write($"Значение элемента матрицы: {matrix[i, j]}");
}

Task50();