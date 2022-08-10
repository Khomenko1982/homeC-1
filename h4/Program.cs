// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Проверяем, какое число максимальное");
Console.Write("Введите первое число: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt16(Console.ReadLine());
if (a>b) 
{
if (a>c)
{
Console.Write("max ");
Console.Write(a);
}
}
if (b>a) 
{
if (b>c)
{
Console.Write("max ");
Console.Write(b);
}
}
if (c>a) 
{
if (c>b)
{
Console.Write("max ");
Console.Write(c);
}
}