Console.Write("Целое трёхзначное число=");
int number = int.Parse(Console.ReadLine());
if (number < 1000 && number > 100)
{
    int ost = number % 10;
Console.Write($"Последняя цифра числа равна={ost}");
}
else
{
  Console.Write("Не трёхзначное число");  
}
