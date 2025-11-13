using System;
using Tuiu.ZvyaginaNY.Sprint4.Task0.V28.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = new int[] { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Массив: { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 }");

            int result = ds.GetMultEvenArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение четных элементов: {result}");
            Console.ReadKey();
        }
    }
}