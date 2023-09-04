//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void SumRows(int[,] arr, int[,] arrsecond)
{
int[,] TmpSumArray = new int[rows, colmns];
for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colmns; j++)
        {
            TmpSumArray[i, j] = arr[i, j] + arrsecond[i, j];
        }
    }
    Print(TmpSumArray);
}

int[,] matrix = InitMatrix(rows, colmns);
int[,] matrixSecond = InitMatrix(rows, colmns);
Console.WriteLine("Первая матрица");
Print(matrix);
Console.WriteLine("Вторая матрица");
Print(matrixSecond);
Console.WriteLine("Сумма двух матриц");
SumRows(matrix, matrixSecond);