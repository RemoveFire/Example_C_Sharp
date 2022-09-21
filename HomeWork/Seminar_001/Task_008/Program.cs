// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
int N, m;
Console.WriteLine("Введите число, ОТ которого необходимо показать четные числа:");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ДО какого числа:");
N =  int.Parse(Console.ReadLine());
Console.WriteLine($"Все четные числа ОТ {m} ДО {N}: ");
for(int i = m; i <= N; i++)
{
    if(i % 2 == 0)
    {
        
        Console.Write(i + " ");
    }
}
