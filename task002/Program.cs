﻿/*
03. # Напишите программу, 
которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("понедельник");
}
else if (number == 2)
{
   Console.WriteLine("вторник");
}
else if (number == 3)
{
   Console.WriteLine("среда");
}
else if (number == 4)
{
   Console.WriteLine("четверг");
}
else if (number == 5)
{
   Console.WriteLine("пятница");
}
else if (number == 6)
{
   Console.WriteLine("суббота");
}
else if (number == 7)
{
   Console.WriteLine("воскрсенье");
}
else
{
    Console.WriteLine("Такого дня нет");
}