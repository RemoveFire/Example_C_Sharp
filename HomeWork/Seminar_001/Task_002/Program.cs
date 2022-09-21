// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите числа для проверки из этих чисел максимума.");
Console.WriteLine("Первое число = ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число = ");
int n2 = int.Parse(Console.ReadLine());
    if (n1 > n2)
        Console.WriteLine($"Максимальное число: {n1}");
    else 
        Console.WriteLine($"Максимальное число: {n2}");
