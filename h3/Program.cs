// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

//Console.WriteLine("Проверяем, является ли первое число квадратом второго.");
Console.Write("Введите  число дня недели: ");
int DayNum = Convert.ToInt16(Console.ReadLine());
//Console.Write("Введите Второе число: ");
//int b = Convert.ToInt16(Console.ReadLine());
//new Random().Next(1,10) ;

if (DayNum==1)
{
Console.Write(" -> Понедельник");
}
if (DayNum==2)
{
Console.Write(" -> Вторник");
}
if (DayNum==3)
{
Console.Write(" -> Среда");
}
if (DayNum==4)
{
Console.Write(" -> Четверг");
}
if (DayNum==5)
{
Console.Write(" -> Пятница");
}
if (DayNum==6)
{
Console.Write(" -> Суббота");
}
if (DayNum==7)
{
Console.Write(" -> Воскресенье");
}
if (DayNum<1)
{
Console.Write(" -> Нет такого дня недели");
}
if (DayNum>7)
{
Console.Write(" -> Нет такого дня недели");
}