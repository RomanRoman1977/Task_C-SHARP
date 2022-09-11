﻿// 32. Напишите программу замены элементов массива:
// положительные элементы заменить на соответствующие отрицательные и наоборот
// [-4, -8, 8, 2] - [4, 8, -8, -2]

int[] GreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] ChangePosNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1; // или можно так - array[i] = - array[i];
    }
    return array;
}
int[] arr = GreateArrayRndInt(10, -10, 10);
PrintArr(arr);
Console.WriteLine();
int[] posNeg = ChangePosNeg(arr);
PrintArr(posNeg);


