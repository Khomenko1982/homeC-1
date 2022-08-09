// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Проверяем, какое число большее, а какое меньшее");
Console.Write("Введите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
if (a>b) 
{

Console.Write("max ");
Console.Write(a);
}
else
{
   
  Console.Write("max ");
Console.Write(b);  
}