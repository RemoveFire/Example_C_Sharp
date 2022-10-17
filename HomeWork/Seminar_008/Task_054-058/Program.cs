/* Блок выполнения домашнего задания №8, состоящий из 3 основных задач */
Console.Clear();
Console.WriteLine("Домашние задание №8");
string HomeWork = "n";

while (HomeWork == "n")
{
    Console.WriteLine("  ");
    Console.Write("Введите номер задачи, выбрав из следующих - 54, 56, 58: ");
    string task = Console.ReadLine();
    Console.WriteLine();
    switch (task)
    {
        case "54":
            Console.Clear();
            Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
            Console.WriteLine("Например, задан массив:" + "\n" + "1 4 7 2" + "\n" + "5 9 2 3" + "\n" + "8 4 2 4" + "\n" + "\nВ итоге получается вот такой массив:" + "\n" + "7 4 2 1" + "\n" + "9 5 3 2" + "\n" + "8 4 4 2" + "\n");
            Console.WriteLine();
            Task54();
            break;

        case "56":
            Console.Clear();
            Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
            Console.Write("Например, задан массив:" + "\n" + "1 4 7 2" + "\n" + "5 9 2 3" + "\n" + "8 4 2 4" + "\n" + "5 2 6 7" + "\n" + "Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка" + "\n");
            Console.WriteLine();
            Task56();
            break;

        case "58":
            Console.Clear();
            Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
            Console.Write("Например, даны 2 матрицы:" + "\n" + "2 4 | 3 4" + "\n" + "3 2 | 3 3" + "\n" + "Результирующая матрица будет:" + "\n" + "18 20" + "\n" + "15 18" + "\n");
            Console.WriteLine();
            Task58();
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
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Task54()
{
    int rows = OutputsEnters("\n\nЗадайте количиство строк в создаваемом массиве: ");
    int columns = OutputsEnters("\nЗадайте количиство столбцов в создаваемом массиве: ");
    int[,] numbers = new int[rows, columns];
    string znak = OutputsEntersString("\nВведите знак '>' или '<', для сортировки соответсвенно(на убывание или на возрастание): ");
    CreateArray(numbers, -100, 100);
    PrintArrayRowColumn_Int(numbers);
    DisplayMeasurement(znak);

    void DisplayMeasurement(string measurement)
    {
        switch (measurement)
        {
            case ">":
                znakminys();
                break;

            case "<":
                znakplus();
                break;
            default:
                Console.WriteLine("\nТакого значения нет. Выберите, пожалуйста, из списка предложеноого варианта.");
                break;

        }
    }

    void znakminys()
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                {
                    if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак > на противоположный
                    {
                        int temp = 0;
                        temp = numbers[i, z];
                        numbers[i, z] = numbers[i, z + 1];
                        numbers[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine("\nМассив с упорядоченными значениями. Сортировка на убывание: ");
        WriteArray(numbers);
    }

    void znakplus()
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1) - 1; j++)
            {
                for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                {
                    if (numbers[i, z] > numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                    {
                        int temp = 0;
                        temp = numbers[i, z];
                        numbers[i, z] = numbers[i, z + 1];
                        numbers[i, z + 1] = temp;
                    }
                }
            }
        }
        Console.WriteLine("\nМассив с упорядоченными значениями. Сортировка на увеличение: ");
        WriteArray(numbers);
    }
}
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
void Task56()
{
    int rows = OutputsEnters("\n\nЗадайте количиство строк в создаваемом массиве: ");
    int columns = OutputsEnters("\nЗадайте количиство столбцов в создаваемом массиве: ");
    int[,] numbers = new int[rows, columns];
    CreateArray(numbers, -100, 100);
    Console.WriteLine("\n Исходный сгенерированный массив: \n");
    PrintArrayRowColumn_Int(numbers);
    SumMinRowElements(numbers);

    void SumMinRowElements(int[,] array)    // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
    {
        int minRows = 0;
        int minSumRows = 0;
        int sumRows = 0;
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            minRows += numbers[0, i];
        }
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++) sumRows += numbers[i, j];
            if (sumRows < minRows)
            {
                minRows = sumRows;
                minSumRows = i;
            }
            sumRows = 0;
        }
        Console.Write($"\nПрограмма считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minSumRows + 1} строка\n");
    }
}

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
void Task58()
{
    int rows = OutputsEnters("\nЗадайте количиство строк в создаваемом массиве: ");
    int columns = OutputsEnters("\nЗадайте количиство столбцов в создаваемом массиве: ");
    int[,] numbers = new int[rows, columns];
    int[,] seconds = new int[rows, columns];
    int[,] results = new int[rows, columns];
    Console.WriteLine("\n************** Матрица - А : **************");
    CreateArray(numbers, 0, 5);
    PrintArrayRowColumn_Int(numbers);
    Console.WriteLine("\n************** Матрица - B : **************");
    CreateArray(seconds, 0, 5);
    PrintArrayRowColumn_Int(seconds);

    if (numbers.GetLength(0) != seconds.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
        return;
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < seconds.GetLength(1); j++)
        {
            results[i, j] = 0;
            for (int k = 0; k < numbers.GetLength(1); k++)
            {
                results[i, j] += numbers[i, k] * seconds[k, j];
            }
        }
    }
    Console.WriteLine("\n************** Произведение матриц А х В = **************");
    PrintArrayRowColumn_Int(results);

    Console.WriteLine("\n----------------------- ВТОРОЕ РЕШЕНИЕ -----------------------\n");
}


namespace ConsoleApp2
{
  // Класс Integer - ссылочный тип
  class Integer
  {
    public int value;
  }

  class Program
  {
    // Статическая функция GetArray2D() генерирует (формирует) массив случайных чисел.
    // Массив передается как ref-параметр, можно изменять саму ссылку A.
    // Параметры Rows, Columns возвращают количество столбцов и строк массива.
    static void GetArray2D(ref Integer[,] A, ref int Rows, ref int Columns)
    {
      // 1. Инициализировать генератор случайных чисел
      Random rnd_num = new Random();

      // 2. Сформировать размер массива
      Rows = 3; // количество строк
      Columns = 4; // количество столбцов

      // 3. Выделить память для двумерного массива в целом
      A = new Integer[Rows, Columns];

      // 4. Выделить память для каждого экземпляра отдельно
      for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++)
        {
          A[i, j] = new Integer();
        }

      // 5. Заполнить массив случайными целыми числами в пределах [0; 10]
      for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++)
        {
          // Все изменения в массиве будут отображаться за пределами данной функции
          A[i, j].value = rnd_num.Next(0, 10);
        }

      // 6. Возврат из функции
      return;
    }

    // Статическая функция, которая вычисляет сумму элементов двумерного массива.
    // Массив передается по ссылке (с модификатором ref).
    // Параметры Rows, Columns передаются по значению.
    static int SumIntegers2D(ref Integer[,] A, int Rows, int Columns)
    {
      int sum = 0;
      for (int i = 0; i < Rows; i++)
        for (int j = 0; j < Columns; j++)
        {
          sum += A[i, j].value;
        }
      return sum;
    }

    // Статическая функция PringArray2D(), которая выводит двумерный массив на экран.
    // Функция получает массив A, размеры массива m, n. Параметры передаются по значению
    static void PrintArray2D(Integer[,] A, int m, int n)
    {
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write("{0}\t", A[i, j].value);
        }
        Console.WriteLine();
      }
    }

    static void Main(string[] args)
    {
      // Передача двумерного ref-массива экземпляров класса в метод

      // 1. Объявить ссылку на двумерный массив типа Integer
      Integer[,] Array2D = null;
      // 2. Установить количество строк и стобцов в массиве
      int m, n;
      m = 2;
      n = 3;

      // 3. Сформировать массив с помощью функции GetArray2D()
      GetArray2D(ref Array2D, ref m, ref n);

      // 4. Вывести сформированный массив на экран
      Console.WriteLine("Array2D:");
      PrintArray2D(Array2D, m, n);

      // 5. Вычислить сумму элементов массива и вывести ее на экран
      int summ = SumIntegers2D(ref Array2D, m, n);
      Console.WriteLine($"summ = {summ}");
    }
  }
}