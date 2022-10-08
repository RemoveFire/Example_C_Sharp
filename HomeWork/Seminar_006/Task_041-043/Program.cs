/* Блок выполнения домашнего задания №6, состоящий из 2 основных задач и одной дополнительной */
Console.Clear();
Console.WriteLine("Домашние задание №6");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 41, 43: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "41":
            Console.Clear();
            Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
            Console.WriteLine("Примеры для проверки: " + "\n" + "0, 7, 8, -2, -2 -> 2" + "\n" + "1, -7, 567, 89, 223-> 4" + "\n");
            Console.WriteLine();
            Task41();
            break;

        case "43":
            Console.Clear();
            Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
            Console.Write("Примеры для проверки: " + "\n" + "b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)" + "\n");
            Console.WriteLine();
            Task43();
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
/* Функция вывода сообщения для массива */
void PrintArray(int[] arr)
{
    Console.WriteLine("\n [" + String.Join(",", arr) + "]");
}
void PrintArrayDouble(double[] arr)
{
    Console.WriteLine("\n [" + String.Join(",", arr) + "]");
}

/* 
Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/
void Task41()
{

    Console.Write("Введите числа через запятую: ");
    string? input = Console.ReadLine();
    int[] numbers = ParseStringToArray(input);
    Console.WriteLine("\nИсходные данные: ");
    PrintArray(numbers);


    int Comparison(int[] arrayNumbers)
    {
        int count = 0;
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            if (arrayNumbers[i] > 0) count += 1;
        }
        return count;
    }

    Console.WriteLine("\nВведено чисел больше нуля >> " + Comparison(numbers));

    int[] ParseStringToArray(string input)
    {
        int countNumbers = GetCountNumbersInString(input);
        int[] numbers = new int[countNumbers];
        int indexNumber = 0;
        string substring = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ',')
            {
                substring += input[i];
            }
            else
            {
                numbers[indexNumber] = Convert.ToInt32(substring);
                indexNumber++;
                substring = string.Empty;
            }
        }
        if (input[input.Length - 1] != ',')
            numbers[indexNumber] = Convert.ToInt32(substring);
        return numbers;
    }
    int GetCountNumbersInString(string input)
    {
        int count;
        if (input[input.Length - 1] == ',')
            count = 0;
        else
            count = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
                count++;
        }
        return count;
    }
}
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void Task43()
{
    double b1 = OutputsEnters("\nВведите значение B1: ");
    double k1 = OutputsEnters("\nВведите значение K1: ");
    double b2 = OutputsEnters("\nВведите значение B2: ");
    double k2 = OutputsEnters("\nВведите значение K2: ");

    double numberX = (b2 - b1) / (k1 - k2);
    double numberY = k2 * numberX + b2;
    Console.WriteLine("\n");
    Console.WriteLine($"Точка пересечения двух прямых: ({numberX} ; {numberY})");

    Console.WriteLine("\n" + "*** Еще одно решение через var ***" + "\n");
    
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}
