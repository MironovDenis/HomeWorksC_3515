/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

void Task41()
{
    Console.Write("Задайте размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];

    void NewArray(int[] array)
    {
        Console.WriteLine("Введите элеметы массива: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    void SumPositive(int[] array)
    {
        int count = array.Length;
        int sum = 0;
        for (int i = 0; i < count; i++)
        {
            if (array[i] > 0) sum+=1;
        }
        Console.WriteLine($"Количество чисел больше 0 = {sum}");
    }
    NewArray(array);
    SumPositive(array);
}
Task41();