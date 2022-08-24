// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 0) Console.WriteLine("Это не день недели, введите число от одного до семи");
else if (day == 6) Console.WriteLine("Да, это выходной");
else if (day == 7) Console.WriteLine("Да, это выходной");
else if (day <= 5) Console.WriteLine("Нет, это не выходной");
else if (day > 7) Console.WriteLine("Это не день недели, введите число от одного до семи");