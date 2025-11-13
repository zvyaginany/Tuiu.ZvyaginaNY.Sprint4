using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tuiu.ZvyaginaNY.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int product = 1;
            int columnIndex = 3; 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                product *= array[i, columnIndex];
            }

            return product;
        }
    }
}