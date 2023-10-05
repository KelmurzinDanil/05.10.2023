using System;
using System.Threading;

namespace _05._10._2023
{
    internal class Program
    {
        static int EnterNumber() // Проверка на целое число
        {
            bool flag = true;
            int number;
            do
            {
                Console.WriteLine("Введите целое число:");
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести целое число");
                }
            }
            while (flag);

            return number;
        }
        static uint NaturalNumber() // Проверка на натуральность
        {
            bool flag = true;
            uint number;
            do
            {
                Console.WriteLine("Введите натуральное число:");
                bool isNumber = uint.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести натуральное число");
                }
            }
            while (flag);

            return number;
        }
        static void ChangeValue(uint ind1, uint ind2, params int[] array) // Смена мест значений массива
        {
            try
            {
                (array[ind1], array[ind2]) = (array[ind2], array[ind1]);
                Console.WriteLine("Вывод массива:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Элемент индекса {i}: " + array[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Выход за границу массива");
            }

        }
        static int CalculArray(ref int multiply, out double mid, params int[] arrInt) // Задание 2
        {
            int sum = 0;
            foreach (int item in arrInt)
            {
                sum += item;
            }
            foreach (int item in arrInt)
            {
                multiply *= item;
            }
            double summ = 0;
            for (int i = 0; i < arrInt.Length; i++)
                summ += arrInt[i];
            mid = summ / arrInt.Length;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,\r\nкоторые нужно поменять местами. Вывести на экран получившийся массив.");
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next();
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Элемент индекса {i}: " + array[i]);
            }
            Console.WriteLine("Введите индексы элементов, которых нужно поменять местами.");
            uint ind1 = NaturalNumber();
            uint ind2 = NaturalNumber();
            ChangeValue(ind1, ind2, array);

            Console.WriteLine("2. Написать метод, где в качества аргумента будет передан массив (ключевое слово\r\nparams). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение\r\nмассива. Вывести (out) среднее арифметическое в массиве.");
            Console.WriteLine("Введите кол-во элементов массива.");
            uint size = NaturalNumber();
            int[] arrInt;
            arrInt = new int[size];
            Console.WriteLine($"Введите элементы массива в количестве {size}:");
            for (int i = 0; i < arrInt.Length; i++)
                arrInt[i] = EnterNumber();
            Console.WriteLine("Вывод массива:");
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }
            int multiply = 1;
            double mid;
            Console.WriteLine("Сумма массива: " + CalculArray(ref multiply, out mid, arrInt));
            Console.WriteLine("Произведение массива: " + multiply);
            Console.WriteLine("Ср. арифметическое массива: " + mid);

            Console.WriteLine("Задание 3...");
            Console.WriteLine("Введите:");
            string s = Console.ReadLine();
            if (s == "exit" || s == "закрыть")
            {
                Environment.Exit(0);
            }
            else
            {
                int n;
                bool check = int.TryParse(s, out n);
                while (check == false)
                {
                    Console.WriteLine("Вы вели не число. Введите число:");
                    s = Console.ReadLine();
                    check = int.TryParse(s, out n);
                }
                if (n >= 0 && n <= 9)
                {
                    switch (n) // нет шаблона для рисования
                    {
                        case 0:
                            Console.WriteLine("ноль");
                            break;
                        case 1:
                            Console.WriteLine("#");
                            break;
                        case 2:
                            Console.WriteLine("##");
                            break;
                        case 3:
                            Console.WriteLine("###");
                            break;
                        case 4:
                            Console.WriteLine("####");
                            break;
                        case 5:
                            Console.WriteLine("#####");
                            break;
                        case 6:
                            Console.WriteLine("######");
                            break;
                        case 7:
                            Console.WriteLine("#######");
                            break;
                        case 8:
                            Console.WriteLine("########");
                            break;
                        case 9:
                            Console.WriteLine("#########");
                            break;
                    }
                }
                else
                {

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Error");
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
            Console.WriteLine("Заданеи 5.");

            Console.ReadKey();
        }
    }
}
