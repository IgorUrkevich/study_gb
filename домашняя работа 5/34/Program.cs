//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
    collection[i] = new Random().Next(99, 1000);
    
        Console.WriteLine(collection[i]);
}
}

int evenarray(int[] collection)
{
    int evennumbers = 0;
    
    for (int i = 0; i < collection.Length; i = i + 1)
    {
    if ((collection[i] % 2) == 0)
        {
                evennumbers++;
        }
    }
    return evennumbers;
}


int[] array = new int[newarray(10)]; //newarray(10) генерирует рандомную длинну массива от 0 до 10

randomarray(array); // заполняет массив рандомными значениями и выводит все элементы массива

int evennumbers = evenarray(array); // заносит в переменную evennumbers количество нечетных элементов массива

Console.WriteLine($"Количество чётных чисел в массиве равно {evennumbers}");


// int value = new Random().Next(0, 20);

// int[] array = new int[value];

// Console.WriteLine($"количество элементов массива {value}");

// int evennumbers = 0;

// for (int i = 0; i < array.Length; i = i + 1)
// {
//     array[i] = new Random().Next(99, 1000);
    
//         Console.WriteLine(array[i]);
//             if ((array[i] % 2) == 0)
//             {
//                 evennumbers++;
//             }
// }

// Console.WriteLine($"Количество чётных чисел в массиве равно {evennumbers}");