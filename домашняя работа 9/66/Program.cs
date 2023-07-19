// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
int sum = SumOfNaturalNumbers(m, n);

Console.WriteLine("The sum of natural numbers from " + m + " to " + n + " is: " + sum);

int SumOfNaturalNumbers(int m, int n)
    {
        if (m > n)
            return 0;

        return m + SumOfNaturalNumbers(m + 1, n);
    }