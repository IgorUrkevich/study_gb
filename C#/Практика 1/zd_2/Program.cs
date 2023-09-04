Console.Write("Введите число a=");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите квадрат числа а=");
int avg = int.Parse(Console.ReadLine());
    if (avg == number * number)
    {
    Console.WriteLine($"Число {avg} является квадратом числа {number}");
    }
    else
{
    Console.WriteLine($"Число {avg} не является квадратом числа {number}");
}