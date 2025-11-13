using System;
using Tuiu.ZvyaginaNY.Sprint4.Task1.V3.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Ввод данных с клавиатуры                                                *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[12];
            Console.WriteLine("Введите 12 целых чисел в диапазоне от 2 до 9:");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

                
                if (array[i] < 2 || array[i] > 9)
                {
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 2 до 9.");
                    i--; 
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write(" Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            int result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение четных элементов: {result}");
            Console.ReadKey();
        }
    }
}