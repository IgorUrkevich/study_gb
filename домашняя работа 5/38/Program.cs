//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int value = new Random().Next(0, 20);

double[] array = new double[value];

Console.WriteLine($"количество элементов массива {value}");


for (int i = 0; i < array.Length; i = i + 1)
{
    array[i] = Math.Round((new Random().NextDouble()) + (new Random().Next()), 2);
    Console.WriteLine(array[i]);
}

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i = i + 1)
{
    if (array[i] > max)
    {
        max = array [i];
    }
    
    if (array[i] < min)
    {
        min = array [i];
    }
}

double result = max - min;

Console.WriteLine($"Наибольшее число в массиве {max}, наименьшее {min} их разница {result}");


