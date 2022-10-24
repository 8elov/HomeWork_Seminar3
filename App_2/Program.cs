// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.Write("Введите X 1ой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y 1ой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z 1ой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X 2ой точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y 2ой точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z 2ой точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double FindDistance(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return distance;
}

double distance = FindDistance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(distance);