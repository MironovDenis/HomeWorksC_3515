/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

void Task68()
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Значение функции Аккермана для чисел М={m} и N={n} равно {Akkerman(m, n)}");
}
Task68();

int Akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if ((m > 0) && (n == 0)) return Akkerman(m - 1, 1);
else if ((m > 0) && (n > 0)) return Akkerman(m - 1, Akkerman(m, n - 1));
else return n + 1;
}
