using System;
using Tyuiu.ZvyaginaNY.Sprint4.Task5.V26.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task5.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            Console.Title = "Спринт #4 | Выполнила: Звягина Н. Ю. |ИСПБ -25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -4 до 4. Заменить положительные   *");
            Console.WriteLine("* элементы на 1.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-4, 5);
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] result = ds.Calculate(matrix);

            Console.WriteLine("Массив после замены положительных элементов на 1:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{result[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}