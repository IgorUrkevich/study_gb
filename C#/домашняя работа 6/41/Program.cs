// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int evenarray(int[] collection)
// {
//     int evennumbers = 0;
    
//     for (int i = 0; i < collection.Length; i = i + 1)
//     {
//     if (collection[i] > 0)
//         {
//                 evennumbers++;
//         }
//     }
//     return evennumbers;
// }

// Console.WriteLine("Введите количество желаемых цифр: ");
// int numbers = int.Parse(Console.ReadLine());

// int[] arraynumbers = new int[numbers];

// for (int i = 0; i < numbers; i++)
// {
// Console.WriteLine($"Введите число {i + 1}: ");
// arraynumbers[i] = int.Parse(Console.ReadLine());
// }

// int positivnumbers = evenarray(arraynumbers);

// Console.WriteLine($"Вы ввели {positivnumbers} положительных чисел");


Console.Write("Введите количество чисел: ");
        int M = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число {0}: ", i + 1);
            double num = double.Parse(Console.ReadLine());
            if (num > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество чисел, больших 0: " + count);