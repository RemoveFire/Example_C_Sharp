/* Блок выполнения итогового домашнего задания №9, состоящий из 3 основных задач */
Console.Clear();
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("\n\n\t\tДомашние задание №9\n");
    Console.Write("Введите номер задачи, выбрав из следующих - 64, 66, 68: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "64":
            Console.Clear();
            Console.WriteLine("Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");
            Console.WriteLine("Например: " + "\n" + "M = 1; N = 5 -> 2, 4" + "\n" + "M = 4; N = 8 -> 4, 6, 8" + "\n");
            Console.WriteLine();
            Task64();
            Console.WriteLine();
            Console.ReadKey();
            break;

        case "66":
            Console.Clear();
            Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.");
            Console.Write("Например: " + "\n" + "M = 1; N = 15 -> 120" + "\n" + "M = 4; N = 8 -> 30" + "\n");
            Console.WriteLine();
            Task66();
            Console.WriteLine();
            Console.ReadKey();
            break;

        case "68":
            Console.Clear();
            Console.WriteLine("Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");
            Console.Write("Например: " + "\n" + "M = 28; N = 7 -> 7" + "\n");
            Console.WriteLine();
            Task68();
            Console.WriteLine();
            Console.ReadKey();
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
int UserInput(string input)
{
    Console.Write(input);
    int output = int.Parse(Console.ReadLine());
    return output;
}
string OutputsEntersString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
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
void PrintArrayRowColumn_Double(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
void PrintArrayRowColumn_Int(int[,] inputArray)
{
    // Console.WriteLine("\n Исходный сгенерированный массив: \n");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("{0, 5}", inputArray[i, j]);
        }
        Console.WriteLine();
    }
}
/* Вывод сообщения */
void WriteArray(int[,] array)
{
    // Console.WriteLine("\nИтоговый массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 5}", array[i, j]);
        }
        Console.WriteLine();
    }
}

/* Создание двумерного массива рандомным образом */
void CreateArray(int[,] array, int arrayRangeMin, int arrayRangeMax)
{
    //Console.WriteLine("\n Массив чисел: \n\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(arrayRangeMin, arrayRangeMax);
        }
    }
}
void CreateArray10(int[,] array, int arrayRangeMin, int arrayRangeMax)
{
    Console.WriteLine("\n Массив чисел: \n\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(arrayRangeMin, arrayRangeMax) / 10;
        }
    }
}
void FillArrayRandomNumbers(double[,] array, int arrayRangeMin, int arrayRangeMax)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(arrayRangeMin, arrayRangeMax)) / 10;
        }
    }
}

///////////////////////////////////////// ЗАДАЧИ /////////////////////////////////////////

/* 
Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8
*/
void Task64()
{
n1: int N = OutputsEnters("\nВведите число M: ");
    int M = OutputsEnters("\nВведите число N: ");
    if (M < N)
    {
        Console.WriteLine("Введено некорректное значение N, введите  значение больше M");
        goto n1;
    }
    void PrintMN(int M, int N)
    {
        if (N <= M)
        {
            if (N % 2 == 0)
            {
                Console.Write($"{N}" + ", ");
                N++;
                PrintMN(M, N);

            }
            else
            {
                N++;
                PrintMN(M, N);
            }
        }
    }
    Console.Write($"\nВ промежутке от {N} до {M} все четные числа = ");
    PrintMN(M, N);
}
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/
void Task66()
{
    int M = OutputsEnters("\nВведите число M: ");
    int N = OutputsEnters("\nВведите число N: ");
    int Recurs(int M, int N)
    {
        if (M == N)
            return N;
        return N + Recurs(M, N - 1);
    }
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} c помощью рекурсии = {Recurs(M, N)}");
}

/*
Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7
*/
void Task68()
{
    Console.WriteLine("Введите два положительных числа: ");//Можно задавать числа в любом порядке, как (28 и 7), так и (7 и 28)
    int M = UserInput("Введите 1 число: ");
    int N = UserInput("Введите 2 число: ");
    Console.WriteLine($"\nA({M}, {N}) = {NOD(M, N)}");


    int NOD(int M, int N)
    {
        if (M == 0)
        {
            return N;
        }

        return N == 0 ? M : NOD(N, M % N);
        return M > N ? NOD(M % N, N) : NOD(M, N % M);
    }
}
