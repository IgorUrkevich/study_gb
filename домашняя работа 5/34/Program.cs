//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int value = new Random().Next(0, 20);

int[] array = new int[value];

Console.WriteLine($"количество элементов массива {value}");

int evennumbers = 0;

for (int i = 0; i < array.Length; i = i + 1)
{
    array[i] = new Random().Next(99, 1000);
    
        Console.WriteLine(array[i]);
            if ((array[i] % 2) == 0)
            {
                evennumbers++;
            }
}

Console.WriteLine($"Количество чётных чисел в массиве равно {evennumbers}");


