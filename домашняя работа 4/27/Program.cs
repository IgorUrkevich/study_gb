//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Ведите число: ");
int numberA = int.Parse(Console.ReadLine());

int resualt = 0;

while (numberA > 0)
{
    resualt = resualt + (numberA % 10);
    numberA = numberA / 10 ;
}

Console.WriteLine($"cумма цифр введенного числа равна {resualt} ");