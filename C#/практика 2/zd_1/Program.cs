int number = new Random().Next(10, 100);

Console.WriteLine($"Рандомное число= {number}");

int firstnumber = number/10;
int seconnumber = number % 10;

Console.WriteLine($"Первая цифра числа {firstnumber} Вторая цифра числа {seconnumber}");

if (firstnumber > seconnumber)   
{
    Console.WriteLine("Первая цифра числа больше");
}
else
{
    Console.WriteLine("Вторая цифра числа больше");
}
