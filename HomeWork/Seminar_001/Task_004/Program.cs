//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

Console.Clear();
int  n1, n2, n3;
Console.WriteLine("Введите три числа для нахождения максимума.");
Console.WriteLine($"Первое число = {n1 = int.Parse(Console.ReadLine())}");
Console.WriteLine($"Второе число = {n2 = int.Parse(Console.ReadLine())}");
Console.WriteLine($"Третье число = {n3 = int.Parse(Console.ReadLine())}");

int max = n1;
    if (max > n2)
       { 
            max = n1; 
            if (max > n3)
             {
                  n3 = max;
             }
        Console.WriteLine($"Максимальное число: {n3}");
        }

