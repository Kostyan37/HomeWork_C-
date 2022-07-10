// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stnum = Convert.ToString(num);


if (stnum.Length > 2)
{
    Console.WriteLine("третья цифра -> " + stnum[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}