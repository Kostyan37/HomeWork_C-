//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());        //Читаем день недели

void CheckingTheDayOfTheWeek (int dayNum) {
  if (dayNum == 6 || dayNum == 7) {                   // если 6 или 7 то выхи
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNum < 1 || dayNum > 7) {                   //Если выходим из интервала >1 и 7<
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNum);
