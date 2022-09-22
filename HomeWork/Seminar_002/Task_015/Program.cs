/* Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
 6 -> да
 7 -> да
 1 -> нет
 */
Console.Clear();

Console.Write("Введите число, обозначающее день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());


if (dayNumber == 6 || dayNumber == 7) 
  {
        Console.WriteLine($"Под числом {dayNumber} - Выходной");
  }
else if (dayNumber < 1 || dayNumber > 7) 
  {
        Console.WriteLine($"Число {dayNumber} выходит за значение дня недели. Повтороите попытку и введите корректные данные");
  }
else Console.WriteLine($"Под числом {dayNumber} - Рабочий");




if (dayNumber > 0 && dayNumber < 8)
{
    if (dayNumber == 7 || dayNumber == 6)
    {
        Console.Write($"Под числом {dayNumber} - Выходной");
    }
    else
    {
        Console.Write($"Под числом {dayNumber} - Рабочий");
    }
}
else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    

//Другой способ решения
Console.WriteLine("   ");

Console.WriteLine("  **Другой способ решения***  ");

Console.WriteLine("   ");
Console.Write("Введите число, обозначающее день недели: ");
dayNumber = int.Parse(Console.ReadLine()!);

if(dayNumber <= 0)
{
    Console.WriteLine("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}
else if(dayNumber > 7)
{
    Console.WriteLine("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}
else if(dayNumber <= 5)
{
    Console.WriteLine("Будний день");
}
else
Console.WriteLine("Выходной");