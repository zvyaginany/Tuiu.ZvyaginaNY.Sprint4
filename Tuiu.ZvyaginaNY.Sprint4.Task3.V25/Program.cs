using System;
using Tuiu.ZvyaginaNY.Sprint4.Task3.V25.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 7, 3, 5, 3, 6 },
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 }
            };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Массив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение элементов в четвертом столбце: {result}");
            Console.ReadKey();
        }
    }
}