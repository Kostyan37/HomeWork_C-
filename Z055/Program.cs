

Console.Clear();
double[] CreateArrayRndInt(int size, int min, int max)    //метод создания массива
{
    double[] arr = new double[size];
    //double[] arr = Math.Round(new double[size]);
    Random rnd = new Random();
    

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max) + rnd.NextDouble();
    }
    return arr;
}


void PrintArray(double[] arr)                                  //метод вывода массива со скобками (красивый массив)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(Math.Round(arr[i], 2) + ",  ");
        else Console.Write(Math.Round(arr[i], 2) + "]");

    }

}

double[] array = CreateArrayRndInt(4, -99, 99);              //интервал  от -99 до 99
PrintArray(array);





