/*Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход 
два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void Task25()
{
    Console.Write("Введите число А: ");
    int numA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int numB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine($"Число {numA} в степени {numB} = {Math.Pow(numA, numB)}");
    
}
Task25();