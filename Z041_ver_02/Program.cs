//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


Console.Clear();
Console.ForegroundColor = ConsoleColor.Magenta;          //раскрасил строки Magenta
Console.Write("Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());           //определение размера массива


int[] array = new int[num];                              //формирование массива
                                                   
for (int i = 0; i < num; i++)                            
{
    Console.ForegroundColor = ConsoleColor.Green;         //раскрасил строки Green
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}




void Znacenie(int[] arr)
{
    int fix = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) fix += 1;
    }
    Console.ForegroundColor = ConsoleColor.Blue;                             //раскрасил строки Blue
    Console.Write($"Количество чисел больше 0 ввёл пользователь = {fix}");
}


void PrintArray(int[] arr)                                  //метод вывода массива со скобками (красивый массив)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;         //раскрасил строки Green
        if (i == 0) Console.Write("{ ");
        if (i < arr.Length - 1) Console.Write(arr[i] + " | ");
        else Console.Write(arr[i] + " }");

    }

}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;              //раскрасил строки Magenta
Console.WriteLine("Числа введеные пользователем");
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Znacenie(array);
