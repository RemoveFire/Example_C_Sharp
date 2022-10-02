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
/* Функция вывода сообщения для массива */
void PrintArray(int[] arr)
{
    Console.WriteLine("\n [" + String.Join(",", arr) + "]");
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
    ToDegree(A, B);

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
    int Number = OutputsEnters("Введите число: ");
    int Len = Numbers(Number);

    //Вывод
    Console.Write($"\nСумма цифр в числе {Number} равно: ");
    SumNumbers(Number, Len);
    Console.Write("\n");

    // Функция подсчета цифр в числе
    int Numbers(int x)
    {
        int result = 0;
        if (x == 0 || x == 1) result = 1;
        for (int i = 1; i < x; i++)
        {
            if (x % i >= 0)
            {
                result += 1;
                i = i * 10;
            }
        }
        return result;
    }
    Console.WriteLine($"В веденном числе {Numbers(Number)} цифр(а)");
    // Функция вывода суммы цифр в числе
    void SumNumbers(int n, int l)
    {
        int sum = 0;
        for (int i = 1; i <= Len; i++)
        {
            sum += n % 10;
            n /= 10;
        }
        Console.WriteLine(sum);
    }
}
/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void Task29()
{
    int size = OutputsEnters("Введите размер массива: \n");
    Console.WriteLine("\nВведите каждую цифру массива в отдельной строке по одному значению, через enter: \n");
    int[] ESCArray = Array(size);
    Console.WriteLine("\nВы задали массив: ");
    PrintArray(ESCArray);
    Console.WriteLine("\nДалее ниже решение через рандом, в зависимости от введенного размера массива." + "\nРанее вы ввели число(длину массива): " + size + "\n");
    RndArray(size); //решение через рандом
    Console.WriteLine("\n");
    Console.WriteLine("\nПробуем с использованием foreach \n");
    whileFor(size);//решение с использованием foreach

    int[] Array(int arr)
    {
        int[] endArray = new int[arr];

        for (int i = 0; i < endArray.Length; i++)
        {
            endArray[i] = int.Parse(Console.ReadLine());
        }

        return endArray;
    }
    // Наполнение масива через рандом, задав только размер массива
    void RndArray(int size)
    {
        int[] randomArray = new int[size];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = new Random().Next(1, 9);
            Console.Write(randomArray[i] + " ");
        }
    }

    //Попытка использования цикла в массиве foreach
    void whileFor(int arrfor)
    {
        int N;
        N = OutputsEnters("Введите количество элементов в массиве: \n");
        var edArray = new int[N];
        for (var i = 0; i < N; i++)
        {
            edArray[i] = OutputsEnters("Ввод элемента: \n");
        }
        foreach (int i in edArray)
        Console.WriteLine("\n [" + String.Join(",", i) + "]");
    }
}
/*
MainArrayIntOne();
static void MainArrayIntOne(string[] args)
{
    Console.Write("Введите в одну строку 10 целых чисел через пробел");
    string s = Console.ReadLine();
    ArrayIntOne X1 = new ArrayIntOne(10, s);
    X1.ArrayInt_Out("Исходные данные: ");
}
*/
