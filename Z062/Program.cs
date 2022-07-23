
//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

//  01 02 03 04
//  12 13 14 05
//  11 16 15 06
//  10 09 08 07


Console.Clear();

int n = InNum("Введите размерность матрицы: ");
int InNum(string input)                                                //метод для ввода
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void Printarray(int[,] array)                                  // метод печати матрицы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < array.GetLength(1) - 1)
                Console.Write($"{array[i, j],3} | ");
            else
                Console.Write($"{array[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

Printarray(sqareMatrix);
