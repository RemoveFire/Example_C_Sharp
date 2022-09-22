// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трёхзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
int m = ((N /10) % 10); 
Console.WriteLine($"В трехзначном числе {N}, второй цифрой этого числа является:   {m}");
Console.WriteLine(" ");
//Ниже попытка сделать через индекс, но есть пробелема при вводе отрицательного значения:

string iN = Convert.ToString(N);
Console.WriteLine($"Вторая цифра этого числа: {iN[1]}");
Console.WriteLine(" ");