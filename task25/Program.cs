﻿/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
 и возводит число A в натуральную степень B.
 3, 5 -> 243 (3⁵)
 2, 4 -> 16
 */
Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
int result = numA;
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
Console.Write(result);
