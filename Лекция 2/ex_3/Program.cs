﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int [] array = {11, 23, 233, 353, 364, 768, 756, 467, 545}

array[0] = 12;


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);