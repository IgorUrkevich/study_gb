//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int value = new Random().Next(1, 20);

int[] array = new int[value];

Console.WriteLine($"количество элементов массива {value}");

int result = 0;

for (int i = 0; i < array.Length; i = i + 1)
{
    int temp = new Random().Next(-1,1);
        if (temp == 0)
        {
        temp = temp + 1;
        }
            array[i] = (new Random().Next()) * temp;
                Console.WriteLine(array[i]);
                    if ((i + 1) % 2 != 0)
                    {
                    result = result + array[i];
                    }
}

Console.WriteLine($"сумма не четных эллементов массива равна {result}");