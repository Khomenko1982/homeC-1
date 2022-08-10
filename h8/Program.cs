// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());

N=Math.Abs(N);
int nach=0;
while (N-1>nach)
{
Console.Write(nach=nach+2);
Console.Write(" ");
}