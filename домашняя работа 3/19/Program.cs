Console.WriteLine("Введите пятизначное число ");
int numberfive = int.Parse(Console.ReadLine());

int temp1 = numberfive % 100;
int temp2 = numberfive / 1000;

if (numberfive > 9999 && numberfive < 100000)
{

int lastnumber = (temp1 / 10) + ((temp1 % 10)*10); //25

if (temp2 == lastnumber)
{
Console.WriteLine("Число полиндром");
}
else
{
   Console.WriteLine("Число не полиндром"); 
}
}
else
{
    Console.Write("Число не пятизначное");
}