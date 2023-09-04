//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int newarray(int numberarray) 
{
int value = new Random().Next(0, numberarray);
Console.WriteLine($"количество элементов массива {value}");
return value;
}

void randomarray(int[] collection)
{
for (int i = 0; i < collection.Length; i = i + 1)
{
    int temp = new Random().Next(-1,1);
        if (temp == 0)
        {
        temp = temp + 1;
        }
           collection[i] = (new Random().Next()) * temp;
                Console.WriteLine(collection[i]);
}
}

int sumevenarray(int[] collection)
{
    int result = 0;
    for (int i = 0; i < collection.Length; i = i + 1)
    {
       if ((i + 1) % 2 != 0)
       {
       result = result + collection[i];
       }
    }
    return result;
}

int[] array = new int[newarray(10)]; //newarray(10) генерирует рандомную длинну массива от 0 до 10

randomarray(array); // заполняет массив рандомными значениями (рандомные элементы массива делает 
                    // отрицательнными) и выводит все элементы массива

int numbers = sumevenarray(array); // заносит в переменную numbers сумму элементов стоящих на нечет позиции

Console.WriteLine($"Сумма не четных эллементов массива равна {numbers}");

// int value = new Random().Next(1, 20);

// int[] array = new int[value];

// Console.WriteLine($"количество элементов массива {value}");

// int result = 0;

// for (int i = 0; i < array.Length; i = i + 1)
// {
//     int temp = new Random().Next(-1,1);
//         if (temp == 0)
//         {
//         temp = temp + 1;
//         }
//             array[i] = (new Random().Next()) * temp;
//                 Console.WriteLine(array[i]);
//                     if ((i + 1) % 2 != 0)
//                     {
//                     result = result + array[i];
//                     }
// }

// Console.WriteLine($"сумма не четных эллементов массива равна {result}");