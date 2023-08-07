/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int numberС = Convert.ToInt32(Console.ReadLine());

int Max(int numberA, int numberB, int numberC)
{
    int result = numberA;
    if(numberB>result) result = numberB;
    if(numberC>result) result = numberC;
    return result;
}

int max = Max(numberA, numberB, numberС);


Console.WriteLine("Максимальным числом является: "+max);