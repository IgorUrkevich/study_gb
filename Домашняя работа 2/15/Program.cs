Console.Write("Введите число день недели ");
int day = int.Parse(Console.ReadLine());

if (day >= 6 && day < 8)
{
Console.Write("выходной день ");
}
else if (day <= 5 && day >0)
{
Console.Write("не выходной день ");
}
else
{
Console.Write("введите день недели от 1 до 7 ");
}