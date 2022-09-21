// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
//  -3 -> нет
//  7 -> нет

Console.Clear();
int num;
Console.WriteLine("Введите число, чтобы узнать является ли число чётным.");
Console.WriteLine($"Число = {num = int.Parse(Console.ReadLine())}");
if(num % 2 == 0)
    {
        Console.WriteLine($"Число {num} является четным");
    }
    else
    {
        Console.WriteLine($"Число {num} НЕ четное");
    }

