//13
Console.Write("Введите число а=");
int a = int.Parse(Console.ReadLine());

int b = 0;

if (a <100)
{
   
   Console.WriteLine("вы ввели не трехзначное число");
}
else
{
    while(a > 999)
    {
    a /= 10;
    }
    b = a % 10;
     Console.WriteLine(b);
}
