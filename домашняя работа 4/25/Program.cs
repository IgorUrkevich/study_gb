//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Ведите число: ");
double numberA = double.Parse(Console.ReadLine());

Console.Write("Ведите натуральную степень: ");
double numberB = double.Parse(Console.ReadLine());

double result = Math.Pow(numberA, numberB);

Console.WriteLine($"число {numberA} в натуральной степени {numberB} равно {result} ");