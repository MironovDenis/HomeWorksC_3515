/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

void Task21()
{
    Random rand = new Random();
    double x1 = rand.Next(-10, 10);
    double y1 = rand.Next(-10, 10);
    double z1 = rand.Next(-10, 10);
    Console.WriteLine($"Координаты точки А = ({x1}, {y1}, {z1})");
    double x2 = rand.Next(-10, 10);
    double y2 = rand.Next(-10, 10);
    double z2 = rand.Next(-10, 10);
    Console.WriteLine($"Координаты точки B = ({x2}, {y2}, {z2})");
    double dist = 0;

    dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {Math.Round(dist, 2)}");
}
Task21();