using System;
using Tuiu.ZvyaginaNY.Sprint4.Task2.V13.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            int[] array = new int[13];

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            Console.Write(" Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(2, 10); 
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