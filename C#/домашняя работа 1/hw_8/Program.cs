Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int b = 2;

if(a > 1)
{
    while(b <= a)
    {
        Console.Write($"{b} ");
        b = b + 2;
    }
}
