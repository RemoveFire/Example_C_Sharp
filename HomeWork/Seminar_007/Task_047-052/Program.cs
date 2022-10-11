/* Блок выполнения домашнего задания №7, состоящий из 3 основных задач */
Console.Clear();
Console.WriteLine("Домашние задание №7");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 47, 50, 52: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "47":
            Console.Clear();
            Console.WriteLine("Задача 47. Задайте двумерный массив размером MхN, заполненный случайными вещественными числами.");
            Console.WriteLine("Примеры для проверки: m = 3, n = 4." + "\n" + "0,5 7 -2 -0,2" + "\n" + "1 -3,3 8 -9,9" + "\n" + "8 7,8 -7,1 9" + "\n");
            Console.WriteLine();
            Task47();
            break;

        case "50":
            Console.Clear();
            Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
            Console.Write("Примеры для проверки: Например, задан массив:" + "\n" + "1 4 7 2" + "\n" + "5 9 2 3" + "\n" + "8 4 2 4" + "\n" + "17 -> такого числа в массиве нет" + "\n");
            Console.WriteLine();
            Task50();
            break;

        case "52":
            Console.Clear();
            Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
            Console.Write("Примеры для проверки: Например, задан массив:" + "\n" + "1 4 7 2" + "\n" + "5 9 2 3" + "\n" + "8 4 2 4" + "\n" + "Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3." + "\n");
            Console.WriteLine();
            Task52();
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
    Console.WriteLine("\n Исходный сгенерированный массив: ");
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
    Console.WriteLine("\nИтоговый массив: ");
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
    Console.WriteLine("\n Массив чисел: \n\t");
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
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
void Task47()
{
    int rows = OutputsEnters("\nВведите количество строк");
    int columns = OutputsEnters("\nВведите количество столбцов");
    double[,] numbers = new double[rows, columns];
    FillArrayRandomNumbers(numbers, -100, 100);
    PrintArrayRowColumn_Double(numbers);
}
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
void Task50()
{
    int R = OutputsEnters("\nЗадайте количиство строк в создаваемом массиве: ");
    int C = OutputsEnters("\nЗадайте количиство столбцов в создаваемом массиве: ");
    int rows = OutputsEnters("\nВведите искомое значение относительно строки: ");
    int columns = OutputsEnters("\nВведите искомое значение относительно столбцов: ");
    int[,] numbers = new int[R, C];

    CreateArray10(numbers, -100, 100);
    PrintArrayRowColumn_Int(numbers);

    if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
    {
        Console.WriteLine("\nТакого числа в массиве -> нет");
    }
    else
    {
        WriteArray(numbers);
        Console.WriteLine($"\nЗначение элемента {rows} строки и {columns} столбца равно: {numbers[rows - 1, columns - 1]}");
    }

}

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
void Task52()
{

    int R = OutputsEnters("\nЗадайте количиство строк в создаваемом массиве: ");
    int C = OutputsEnters("\nЗадайте количиство столбцов в создаваемом массиве: ");
    int[,] numbers = new int[R, C];
    CreateArray(numbers, -100, 100);
    PrintArrayRowColumn_Int(numbers);

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double ArithmeticMean = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            ArithmeticMean +=  numbers[i, j];
        }
        ArithmeticMean = Math.Round(ArithmeticMean / R, 1);
        Console.WriteLine($"\n Значение среднее арифметическое столбца № {j+1} = {ArithmeticMean}");
    }
}

