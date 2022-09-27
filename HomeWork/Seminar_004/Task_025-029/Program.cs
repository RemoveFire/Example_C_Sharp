/* Блок выполнения домашнего задания №4, состоящий из 3 основных задач и одной дополнительной */
Console.Clear();
Console.WriteLine("Домашние задание №4");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 25, 27, 29: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "25":
            Console.Clear();
            Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
            Console.WriteLine("Примеры для проверки: " + "\n" + "3, 5 -> 243 (3^5)" + "\n" + "2, 4 -> 16 " + "\n");
            Console.WriteLine();
            Task25();
            break;

        case "27":
            Console.Clear();
            Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
            Console.Write("Примеры для проверки: " + "\n" + "452 -> 11" + "\n" + "82 -> 10" + "\n" + "9012 -> 12" + "\n");
            Console.WriteLine();
            Task27();
            break;

        case "29":
            Console.Clear();
            Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
            Console.WriteLine("Примеры для проверки:" + "\n" + "1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]" + "\n" + "6, 1, 33 -> [6, 1, 33]" + "\n");
            Console.WriteLine();
            Task29();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Такого значения нет. Выберите, пожалуйста из списка ниже.");
            break;
    }
}
/* Функция ввода сообщения */
    int OutputsEnters(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void Task25()
{
    int A = OutputsEnters("Введите число A: ");
    int B = OutputsEnters("Введите число B: ");
    Console.WriteLine();
    Console.Write($"Число {A} возведенное в степень {B} равно: ");
    ToDegree(A,B);

    // Функция возведения в степень
    void ToDegree(int A1, int B1)
    {
        int answer = 1;
        for (int i = 1; i <= B1; i++)
        {
            answer *= A1;
        }
        Console.WriteLine(answer);
    }
}
/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
void Task27()
{
    Console.WriteLine("Пока что тут пусто");
}
/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void Task29()
{
    int mass = OutputsEnters("Введите длинну массива: ");

    Console.WriteLine("Пока что тут пусто и вы зачем-то ввели сообщение: " + mass);
}

