/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("max = " +number1+ " - Первое число "+number1+" больше второго числа "+number2);
}
else
{
    if(number1 == number2)
    {
        Console.WriteLine("Числа равны между собой");
    }
    else
    {
        Console.WriteLine("max = " +number2+ " - Второе число "+number2+" больше первого числа "+number1);
    }
}
