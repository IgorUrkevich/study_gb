// 10
Console.Write("Введите число а=");
int a = int.Parse(Console.ReadLine());

int b = 0;

if (a > 99 && a < 1000)
{
   b = (a / 10) % 10;
   
   Console.WriteLine($"Вторая цифра числа {a}   {b}");
}
else
{
    Console.WriteLine("число не входит в диапазон трехзначных чисел");
}