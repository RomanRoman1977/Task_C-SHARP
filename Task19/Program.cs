﻿/*19 Напишите программу,
 которая принимает на вход пятизначное число
  и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 100000 || num < 10000)
{
  Console.WriteLine("Введено некорректное число");
}
else if(num / 1000 == ((num % 10 * 10) + ((num % 100 - num % 10) / 10)))
{
  Console.WriteLine("Это число палиндром");
}
else if (num / 1000 != ((num % 10 * 10) + ((num % 100 - num % 10) / 10)))
{
  Console.WriteLine("Это число не палиндром");
}