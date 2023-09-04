//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
//существовать треугольник с сторонами такой длины. Теорема о неравенстве треугольника: каждая 
//сторона треугольника меньше суммы двух других сторон

Console.Write("Ведите 1 cторону треугольника: ");
int trungl1 = int.Parse(Console.ReadLine());

Console.Write("Ведите 2 cторону треугольника: ");
int trungl2 = int.Parse(Console.ReadLine());

Console.Write("Ведите 3 cторону треугольника: ");
int trungl3 = int.Parse(Console.ReadLine());

if(trungl1 < (trungl2 + trungl3) && trungl3 < (trungl2 + trungl3) && trungl3 < (trungl2 + trungl3))
// if (trungl1 < (trungl2 + trungl3))
{
//     if (trungl2 < (trungl1 + trungl3))
//     {
//         if (trungl3 < (trungl2 + trungl3))
//         {
           Console.Write("Треугольник с заданными сторонами может существовать"); 
//         }
//     }
}
else
{
   Console.Write("Треугольник с заданными сторонами не может существовать"); 
}