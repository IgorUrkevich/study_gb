// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int[,] Spiral(int n) 
// {
//     int[,] result = new int[n, n];

//     int pos = 0;
//     int count = n;
//     int value = -n;
//     int sum = -1;

//     do {
//         value = -1 * value / n;
//         for (int i = 0; i < count; i++) {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//         value *= n;
//         count--;
//         for (int i = 0; i < count; i++) {
//             sum += value;
//             result[sum / n, sum % n] = pos++;
//         }
//     } while (count > 0);

//     return result;
// }

