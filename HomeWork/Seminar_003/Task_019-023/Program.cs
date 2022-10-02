/* В данном блоке предоставлено решение на 3 основные задачи и 1 полную выполненную дополнительно и начатую выполнения второй дополнительной задачи */

Console.Clear();
Console.WriteLine("Домашние задание №3");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 19, 21, 23, add1: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "19":
            Console.Clear();
            Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
            Console.WriteLine("Примеры для проверки: 14212 -> нет, 12821 -> да, 23432 -> да");
            Console.WriteLine();
            Task19();
            break;

        case "21":
            Console.Clear();
            Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
            Console.WriteLine("Примеры для проверки: A (3,6,8); B (2,1,-7), -> 15.84 ИЛИ A (7,-5, 0); B (1,-1,9) -> 11.53");
            Console.WriteLine();
            Task21();
            break;

        case "23":
            Console.Clear();
            Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
            Console.WriteLine("Примеры для проверки: 3 -> 1, 8, 27 ИЛИ 5 -> 1, 8, 27, 64, 125");
            Console.WriteLine();
            Task23();
            break;

        case "add1":
            Console.Clear();
            Console.WriteLine("Дополнительная задача (задача со звёздочкой): Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, необходимо вывести максимальную цифру в полученном округлённом значении площади круга.");
            Console.WriteLine("Примеры для проверки: (10 -> 4) ИЛИ (20 -> 7) ИЛИ (30 -> 8)");
            Console.WriteLine();
            TaskAdd1();
            break;

        default:
            Console.Clear();
            Console.WriteLine("Такого значения нет. Выберите, пожалуйста из списка ниже.");
            break;
    }
}

/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void Task19()
{
    bool isPalUtil(int n)
    {
        int r = 0, n1 = n;
        while (n > 0)
        {
            r = r * 10 + n % 10;
            n = n / 10;
        }
        return r == n1;
    }
    Console.Write("Введите число: ");

    int n = int.Parse(Console.ReadLine());
    if (isPalUtil(n))
    {
        Console.WriteLine();
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Не палиндром");
    }
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
void Task21()
{
    Console.WriteLine("Введите координаты точки А:");
    Console.WriteLine();
    Console.Write("Введите координаты X: ");
    int x_A = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y: ");
    int y_A = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты Z: ");
    int z_A = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Введите координаты точки B:");
    Console.WriteLine();
    Console.Write("Введите координаты X: ");
    int x_B = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты Y: ");
    int y_B = int.Parse(Console.ReadLine());
    Console.Write("Введите координаты Z: ");
    int z_B = int.Parse(Console.ReadLine());
    Console.WriteLine();

    double Line = Math.Sqrt(Math.Pow((x_A - x_B), 2) + Math.Pow((y_A - y_B), 2) + Math.Pow((z_A - z_B), 2));

    Console.WriteLine($"Расстояние между координатами A, B и C в 3D пространстве:  {Math.Round(Line, 2)}");

}
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/
void Task23()
{
    Console.Write("Введите N: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("  ");
    Console.Write("Итого, таблица кубов выглядит следующим образом: ");
    for (int i = 1; i <= num; i++)
        Console.Write(Math.Pow(i, 3) + ", ");
    Console.WriteLine("  ");
}
/*
Дополнительная задача (задача со звёздочкой):
Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
10 -> 4
20 -> 7
30 -> 8
*/
void TaskAdd1()
{
    Console.Write("Радиус: ");
    double r = Convert.ToDouble(Console.ReadLine());
    double d = 2 * Math.PI * r;
    double s = Math.PI * Math.Pow(r, 2);
    double Sum = Math.Round(s);
    int SumMax = 0;
    do SumMax = Math.Max(SumMax, (int)Sum % 10);
    while ((Sum /= 10) != 0);

    Console.Write("Длина = " + Math.Round(d, 1) + "\n" + "Площадь = " + Math.Round(s, 1) + "\n" + "Максимальная цифра округленного значения = " + SumMax);
    Console.WriteLine("  ");
}
/*
Дополнительная задача 2 (задача со звёздочкой):
Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, 
и вывести на экран те (тот), где чаще всего встречается введённая буква.
Введённая буква: "о", массив ("Москва", "Тюмень", "Новосибирск") -> "Новосибирск"
*/
void TaskAdd2()
{
    string name = "Alex";

    switch (name)
    {
        case "Москва":
            Console.WriteLine("Ваше имя - Bob");
            break;
        case "Тюмень":
            Console.WriteLine("Нет такой буквы");
            break;
        case "Новосибирск":
            Console.WriteLine("Тут 2 буквы ");
            break;
        default:
            Console.WriteLine("Такой буквы нет");
            break;
    }
}

