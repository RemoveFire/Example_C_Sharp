//Не работает. Попытка создания класса с дальнейшим использованием длярешения 29 задачи

using System;
namespace ArrayIntOne
{
    class ArrayInt1
    {
        protected int n;    // длина массива
        protected int[] a;  // массив целых чисел

        // пустой конструктор - нужен для дочернего класса
        public ArrayInt1() { }

        // конструктор целочисленного массива длиной N. Элементы массива имеют значения по умолчанию
        public ArrayInt1(int N)
        {
            n = N;
            a = new int[n];
        }

        // конструктор с генератором случайных чисел от 0 до max
        public ArrayInt1(int N, int max)
        {
            Random rnd = new Random();
            n = N;
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(max + 1);
        }

        // конструктор с генератором случайных чисел от min до max
        public ArrayInt1(int N, int min, int max)
        {
            Random rnd = new Random();
            n = N;
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max + 1);
        }

        // Вывод элементов массива с контролем их наличия 
        public virtual void ArrayInt_Out(string info)
        {
            Console.WriteLine(info);
            if (!(a == null)) // число элементов > 0
            {
                foreach (int e in a)
                    Console.Write(e.ToString() + "\t");
                Console.WriteLine();
            }
            else     // число элементов = 0
                Console.WriteLine("Нет элементов " + info);
        }

        // Поиск минимального элемента (min) и его номера (k)
        public virtual int N_min_Array(out int min)
        {
            min = a[0];
            int k = 0;
            for (int i = 1; i < n; i++)
                if (a[i] < min)
                {
                    min = a[i];
                    k = i;
                }
            return k;
        }

        // Поиск максимального элемента (max) и его номера (k)
        public virtual int N_max_Array(out int max)
        {
            max = a[0];
            int k = 0;
            for (int i = 1; i < n; i++)
                if (a[i] > max)
                {
                    max = a[i];
                    k = i;
                }
            return k;
        }

        // Изменить a[k] на заданный elem (нумерация с 0)
        public virtual void Set_Element(int k, int elem)
        {
            if (k >= 0 && k < n)
                a[k] = elem;
        }

        // Извлечь k-й элемент массива (нумерация с 0) 
        public virtual int Get_Element(int k)
        {
            if (k >= 0 && k < n)
                return a[k];
            else
                return Int32.MinValue;
        }

        // Пузырьковая сортировка по возрастанию(U)/убыванию(D)/без нее.
        public virtual void BubbleSort(char d)
        {
            int temp;
            switch (d)
            {
                case 'U':   // по возрастанию
                    for (int i = 0; i < n; i++)
                        for (int j = n - 1; j > i; j--)
                            if (a[j - 1] > a[j])
                            {
                                temp = a[j];
                                a[j] = a[j - 1];
                                a[j - 1] = temp;
                            }
                    break;
                case 'D':   // по убыванию
                    for (int i = 0; i < n; i++)
                        for (int j = n - 1; j > i; j--)
                            if (a[j - 1] < a[j])
                            {
                                temp = a[j];
                                a[j] = a[j - 1];
                                a[j - 1] = temp;
                            }
                    break;
                default:    // без сортировки
                    break;
            }
        }
    }
}