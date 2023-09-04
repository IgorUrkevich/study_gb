//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int newarray(int numberarray) 
{
int value = new Random().Next(0, numberarray);
Console.WriteLine($"количество элементов массива {value}");
return value;
}

void randomarray(double[] collection)
{
for (int i = 0; i < collection.Length; i = i + 1)
{
    collection[i] = Math.Round((new Random().NextDouble()) + (new Random().Next(0, 10)), 2);
    
        Console.WriteLine(collection[i]);
}
}

double diffmaxminarray(double[] collection)
{
    double max = collection[0];
    double min = collection[0];
    for (int i = 0; i < collection.Length; i = i + 1)
    {
        if (collection[i] > max)
        {
        max = collection[i];
        }
    
            if (collection[i] < min)
            {
            min = collection [i];
            }
    }

    double result = max - min;
    return result;
}

double[] array = new double[newarray(10)]; //newarray(10) генерирует рандомную длинну массива от 0 до 10

randomarray(array); // заполняет массив рандомными дробными значениями с двумя знаками после запятой
                    //и выводит все элементы массива

double evennumbers = diffmaxminarray(array); // заносит в переменную evennumbers разницу между наименьшим
                                            // и наибольшим значением массива

Console.WriteLine($"Разница наибольшего и наименьшего значения массива  {evennumbers}");



// int value = new Random().Next(0, 20);

// double[] array = new double[value];

// Console.WriteLine($"количество элементов массива {value}");


// for (int i = 0; i < array.Length; i = i + 1)
// {
//     array[i] = Math.Round((new Random().NextDouble()) + (new Random().Next()), 2);
//     Console.WriteLine(array[i]);
// }

// double max = array[0];
// double min = array[0];

// for (int i = 0; i < array.Length; i = i + 1)
// {
//     if (array[i] > max)
//     {
//         max = array [i];
//     }
    
//     if (array[i] < min)
//     {
//         min = array [i];
//     }
// }

// double result = max - min;

// Console.WriteLine($"Наибольшее число в массиве {max}, наименьшее {min} их разница {result}");


