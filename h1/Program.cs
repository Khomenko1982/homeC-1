﻿//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
Console.WriteLine("Проверяем, является ли первое число квадратом второго.");
Console.Write("Введите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
//new Random().Next(1,10) ;

if ((a/b)==b)
{
Console.WriteLine("Да, первое число является квадратом второго ");
}
else
{
  Console.WriteLine("Нет,первое число  не является квадратом второго");  
}