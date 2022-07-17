//Задача 50. 
// 1 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,  
// 2 Возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int colum = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int m, int n)        //метод двумерного массива 
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)                                            //метод печати двумерного массива 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],4}  |  ");
            else Console.Write($"{arr[i, j],4}  |  ");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] arr)                                      // поиск элемента по заданным позициям строки и столбца
{
    int i = (line - 1);
    int j = (colum - 1);

    if (i < arr.GetLength(0) && i >= 0 && j < arr.GetLength(1) && j >= 0)
    {
        Console.WriteLine($"Указанный элемент имеет значение: {arr[i, j]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}

int[,] arrayResult = CreateMatrixRndInt(3, 4);
Console.WriteLine("___________________________________");
PrintMatrix(arrayResult);
Console.WriteLine("-----------------------------------");

FindElementArray(arrayResult);
