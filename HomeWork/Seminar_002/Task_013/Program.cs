// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
string iN = Convert.ToString(N);
if(iN.Length > 2)
    {
        Console.WriteLine($"Третья цифра числа {N} равна:  {iN[2]}");
        Console.WriteLine(" ");
    }
    else
        {
            Console.WriteLine($"Третьей цифры в числе {N} нет");
            Console.WriteLine(" ");
        }


// Второе решение с помощью метода возведения числа в степень, 
// но невозможностью работы с минусовым числом, к примеру -645, получим 2147483646, 
// когда в 1 варианте получим нужный индекс.
// и перестает работать при 4х значных цифрах
int k = (int)Math.Log10(N)-2;
Console.WriteLine(k < 0 ? $"Третьей цифры в числе {N} нет" : (N % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString($"Третья цифра числа {N} равна: {k}"));
Console.WriteLine(" ");

