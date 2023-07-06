// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter num row : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter num colmns : ");
int colmns = int.Parse(Console.ReadLine());

int[,] InitMatrix(int rows, int colmns)
{
    int[,] DrowNumbersArray = new int[rows, colmns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            DrowNumbersArray[i, j] = random.Next(1, 5);
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

void AvgRows(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(1); i++) // cтолбец 
    {
        double tmp = 0;
        for (int j = 0; j < arr.GetLength(0); j++) // строка
        {  
            tmp = tmp + arr[j, i];
        }
        tmp = tmp / arr.GetLength(0);
        Console.WriteLine($"среднее арифметическое {i+1} столбца = {tmp} ");
    }
}

int[,] matrix = InitMatrix(rows, colmns);
Print(matrix);
AvgRows(matrix);