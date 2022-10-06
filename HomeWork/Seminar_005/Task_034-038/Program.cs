/* Блок выполнения домашнего задания №5, состоящий из 3 основных задач и одной дополнительной */
Console.Clear();
Console.WriteLine("Домашние задание №5");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 34, 36, 38: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "34":
            Console.Clear();
            Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
            Console.WriteLine("Примеры для проверки: " + "\n" + "[345, 897, 568, 234] -> 2" + "\n");
            Console.WriteLine();
            Task34();
            break;

        case "36":
            Console.Clear();
            Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
            Console.Write("Примеры для проверки: " + "\n" + "[3, 7, 23, 12] -> 19" + "\n" + "[-4, -6, 89, 6] -> 0" + "\n");
            Console.WriteLine();
            Task36();
            break;

        case "38":
            Console.Clear();
            Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
            Console.WriteLine("Примеры для проверки:" + "\n" + "[3 7 22 2 78] -> 76" + "\n");
            Console.WriteLine();
            Task38();
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
// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void Task34()
{
    int[] numbers = new int[OutputsEnters("Введите размер массива: ")];
    FillArray(numbers, 100, 1000);

    Console.WriteLine("\nИсходный массив: ");
    PrintArray(numbers);
    int isEven = EvenNumber(numbers);
    Console.WriteLine($"\nКоличество чётных чисел в массиве: {isEven}");
    Console.WriteLine();

    void FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    int EvenNumber(int[] array)
    {
        int isEven = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                isEven++;
            }
        }
        return isEven;
    }

}
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void Task36()
{
    int size = OutputsEnters("Введите размер массива: ");
    int[] numbers = new int[size];
    FillArray(numbers, 1, 10);
    Console.Write("\nИсходный массив: ");
    PrintArray(numbers);
    Console.Write("\nСумма: " + Sum(numbers) + "\n");
    Console.WriteLine(" ");

    void FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                sum += array[i];
            }
        }
        return sum;
    }
//Проверка вне метода
    int sumNumbersEvenIndex = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumNumbersEvenIndex += numbers[i];
        }
    }
    Console.Write("Проверка : " + sumNumbersEvenIndex + "\n");

//Еще один из способов решения задачи в одном методе
    int randomNumbers2 = RandomNumbers2(size, 1, 10);
    Console.WriteLine("\n2) Сумма элементов, стоящих на нечётных позициях: " + randomNumbers2);

    int RandomNumbers2(int numberElements2, int min2, int max2)
    {
        int[] randomNumbers2 = new int[numberElements2];
        int sumElements2 = 0;
        Console.Write("\n *** Решение другим методом с подстановкой такого же размера массива, который был введен ранее *** " + "\n");
        Console.Write("2) Исходный массив: ");
        for (int i = 0; i < randomNumbers2.Length; i++)
        {
            randomNumbers2[i] = new Random().Next(min2, max2);
            Console.Write(" " + String.Join(" ,", randomNumbers2[i]) + " ");
            if (i % 2 == 1)
            {
                sumElements2 += randomNumbers2[i];
            }
        }
        return sumElements2;
    }
}
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
void Task38()
{


    double[] array = new double[OutputsEnters("\nВведите размер массива: ")];
    FillArray(array, 0, 100);
    Console.WriteLine("\nИсходный массив: ");
    PrintArrayDouble(array);



    void FillArray(double[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }

    double maxNumber = array[0];
    double minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }

    double decision = maxNumber - minNumber;

    Console.WriteLine($"\nРазница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
}
