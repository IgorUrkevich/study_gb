// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Enter num row : ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter num colmns : ");
int colmns = int.Parse(Console.ReadLine());

Console.Write("Enter number : ");
int Number = int.Parse(Console.ReadLine());

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

void SearchNumber(int[,] arr, int Numbers)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == Numbers)
            {
               Console.WriteLine($"[{i}, {j}]"); 
            }
        }
    }
}

int[,] matrix = InitMatrix(rows, colmns);
Print(matrix);
SearchNumber(matrix, Number);

