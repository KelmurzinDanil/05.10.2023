using System;

namespace Lub_5
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
        static int Max_Value(int val_1, int val_2) // Максимальное значение
        {
            return val_1 > val_2 ? val_1 : val_2;
        }
        static int Min_Value(int val_1, int val_2) // Минимальное значение
        {
            return val_1 < val_2 ? val_1 : val_2;
        }
        static uint Max_Value_uint(uint val_1, uint val_2) // Максимальное значение для типа uint
        {
            return val_1 > val_2 ? val_1 : val_2;
        }
        static uint Min_Value_uint(uint val_1, uint val_2) // Минимальное значение для типа uint
        {
            return val_1 < val_2 ? val_1 : val_2;
        }
        static void ChangeValue(ref double numberRef1, ref double numberRef2) // Смена мест значений
        {
            (numberRef1, numberRef2) = (numberRef2, numberRef1);
        }

        static double CheckNumber() // Проверка на число
        {
            bool flag = true;
            double checkNum;
            do
            {
                Console.WriteLine("Введите число:");
                bool isNumber = double.TryParse(Console.ReadLine(), out checkNum);
                if (isNumber)
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверный ввод - необходимо ввести число или поробуйте точку заменить запятой");
                }
            }
            while (flag);

            return checkNum;
        }
        static bool Factorial(ref int valFact) // Факториал
        {
            int a = valFact;
            valFact = 1;
            for (int i = 1; i <= a; i++)
            {
                try
                {
                    checked { valFact *= i; }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
        static int Factorial2(int valFact2) // Рекурсивным методом
        {
            if (valFact2 == 0)
            {
                return 1;
            }
            else
            {
                return valFact2 * Factorial2(valFact2 - 1);
            }

        }
        static uint NOD(uint nod_num_1, uint nod_num_2) // НОД
        {
            if (nod_num_1 == 0)
            {
                return nod_num_2;
            }
            else
            {
                uint max = Max_Value_uint(nod_num_1, nod_num_2);
                uint min = Min_Value_uint(nod_num_1, nod_num_2);
                return NOD(max % min, min);
            }

        }
        static uint NOD(uint nod_n_1, uint nod_n_2, uint nod_n_3) // НОД для трех чисел
        {
            if (nod_n_1 == 0)
            {
                if (nod_n_2 == 0)
                {
                    return nod_n_3;
                }
                else
                {
                    uint max = Max_Value_uint(nod_n_2, nod_n_3);
                    uint min = Min_Value_uint(nod_n_2, nod_n_3);
                    return NOD(max % min, min);
                }
            }
            else
            {
                uint max = Max_Value_uint(nod_n_1, nod_n_2);
                uint min = Min_Value_uint(nod_n_1, nod_n_2);
                return NOD(max % min, min);
            }

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
        static uint Fibonachi(uint n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Написать метод, возвращающий наибольшее из двух чисел. Входные\r\nпараметры метода – два целых числа.");
            int a = EnterNumber();
            int b = EnterNumber();
            Console.WriteLine("Наибольшое из них: " + Max_Value(a, b));

            Console.WriteLine("2. Написать метод, который меняет местами значения двух передаваемых\r\nпараметров. Параметры передавать по ссылке.");
            double x = CheckNumber();
            double y = CheckNumber();
            ChangeValue(ref x, ref y);
            Console.WriteLine($"swap: {x} - {y}");

            Console.WriteLine("3. Написать метод вычисления факториала числа, результат вычислений\r\nпередавать в выходном параметре.");

            int fact = EnterNumber();
            bool flag = Factorial(ref fact);
            if (flag)
            {
                Console.WriteLine(fact);
            }
            else
            {
                Console.WriteLine("Произошло переполнение");
            }

            Console.WriteLine("4. Написать рекурсивный метод вычисления факториала числа.");
            int fact2 = EnterNumber();
            Console.WriteLine("Факториал равен:" + Factorial2(fact2));

            Console.WriteLine("5.Написать метод, который вычисляет НОД двух натуральных чисел\r\n(алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех\r\nнатуральных чисел.");
            Console.WriteLine("Для двух чисел:");
            uint nod_num_1 = NaturalNumber();
            uint nod_num_2 = NaturalNumber();
            Console.WriteLine("НОД:" + NOD(nod_num_1, nod_num_2));
            Console.WriteLine("Для трех чисел:");
            uint nod_n_1 = NaturalNumber();
            uint nod_n_2 = NaturalNumber();
            uint nod_n_3 = NaturalNumber();
            Console.WriteLine("НОД:" + NOD(nod_n_1, nod_n_2, nod_n_3));

            Console.WriteLine("6. Написать рекурсивный метод, вычисляющий значение n-го числа\r\nряда Фибоначчи.");
            uint n = NaturalNumber();
            Console.WriteLine($"Число {n} в ряде Фибоначчи: {Fibonachi(n)}");

            Console.ReadKey();
        }
    }
}
