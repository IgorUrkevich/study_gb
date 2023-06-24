//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double pow_a(int count)
{
    double result = Math.Pow(count, 3);
    return result;
}

Console.Write("Ведите число: ");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count <= n)
{
    double result = pow_a(count);
    Console.WriteLine($"{result} ");
    count++;
}

