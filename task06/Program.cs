/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number%2;
if(result==0)
{
    Console.WriteLine("Да, число " +number+ " является четным и делится на 2 без остатка");
}
else
{
    Console.WriteLine("Нет, число " +number+ " не является четным и делится на 2 с остатком");
}
