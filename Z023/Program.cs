//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите число N");
Console.Write("N:  ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{

    Console.WriteLine($"  |{i,4}  |   {(Math.Pow((i), 3)),4} |");      //запутался в скобках (Math.Pow((i), 3)) равно как (i * i * i)

    i++;
}
