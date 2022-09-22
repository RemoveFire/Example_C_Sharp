/* Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 6 -> да
 7 -> да
 1 -> нет
 */
Console.Clear();

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine($"Под цифрой {dayNumber} - Выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine($"Под цифрой {dayNumber} - Рабочий");




    if (dayNumber > 0 && dayNumber < 8)
    {
        if (dayNumber == 7 || dayNumber == 6)
        {
            Console.Write($"Под цифрой {dayNumber} - Выходной");
        }
        else
        {
            Console.Write($"Под цифрой {dayNumber} - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    

