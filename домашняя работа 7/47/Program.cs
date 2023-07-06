// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

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
            DrowNumbersArray[i, j] = random.Next(1, 501);
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

int[,] matrix = InitMatrix(rows, colmns);
Print(matrix);

