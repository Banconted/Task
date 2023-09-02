﻿/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int[] array = FillArray(4, 1, 100);
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0) count += array[i];
Console.WriteLine('[' + string.Join(", ", array) + "] -> " + count);
