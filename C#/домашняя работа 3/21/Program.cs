//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
//между ними в 3D пространстве.

double ab(double x1, double x2, double y1, double y2, double z1, double z2)
{ 
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Write("Ведите координату Х1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату x2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату Y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Ведите координату z2: ");
double z2 = double.Parse(Console.ReadLine());

double result = ab(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояниен между координатами {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");