// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
void NumberThree(int num3)
{
    string a1lenght = Convert.ToString(num3);
    int c = a1lenght.Length;
    if (c > 2) Console.WriteLine(a1lenght[2]);
    else Console.WriteLine("третьей цифры нет");
}
NumberThree(a1);
