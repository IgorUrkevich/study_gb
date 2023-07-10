// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
Console.Write("Enter num row : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter num colmns : ");
int colmns = int.Parse(Console.ReadLine());

if (rows == colmns)
{
   Console.WriteLine("Вы ввели не прямоугольный массив"); 
   return;
}

int[,] InitMatrix(int rows, int colmns)
{
    int[,] DrowNumbersArray = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            DrowNumbersArray[i, j] = random.Next(1, 50);
        }
    }
    return DrowNumbersArray;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumRows(int[,] arr)
{
int TmpSmalestSumRow = 0;
int TmpSmallestSum = int.MaxValue;
for (int i = 0; i < rows; i++)
    {
        int TmpCurrentSum = 0;
        for (int j = 0; j < colmns; j++)
        {
            TmpCurrentSum = TmpCurrentSum + arr[i, j];
        }
        Console.WriteLine($"{i + 1} = {TmpCurrentSum}");
        if(TmpCurrentSum < TmpSmallestSum)
        {
            TmpSmallestSum = TmpCurrentSum;
            TmpSmalestSumRow = i + 1;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов : {TmpSmalestSumRow}");
}

int[,] matrix = InitMatrix(rows, colmns);
Console.WriteLine("Исходный массив");
Print(matrix);
SumRows(matrix);