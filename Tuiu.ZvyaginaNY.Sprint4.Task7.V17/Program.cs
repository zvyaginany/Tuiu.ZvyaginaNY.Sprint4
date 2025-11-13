using System;
using Tyuiu.ZvyaginaNY.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна | ИСПБ-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '753159864'. Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 3;
            int m = 3;
            string value = "753159864";

            Console.WriteLine($"Количество строк (n) = {n}");
            Console.WriteLine($"Количество столбцов (m) = {m}");
            Console.WriteLine($"Исходная строка = {value}");

            Console.WriteLine();
            Console.WriteLine("Матрица 3x3:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"Количество четных чисел в матрице = {result}");
            Console.ReadKey();
        }
    }
}