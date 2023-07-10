// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowsDescending(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = 0; k < cols - j - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
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
Console.WriteLine("Исходный массив");
Print(matrix);
SortRowsDescending(matrix);
Console.WriteLine("Отсортированный массив");
Print(matrix);