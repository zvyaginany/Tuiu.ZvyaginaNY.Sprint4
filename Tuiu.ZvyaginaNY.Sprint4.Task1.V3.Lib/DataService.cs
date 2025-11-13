using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tuiu.ZvyaginaNY.Sprint4.Task1.V3.Lib
{
    public class DataService : ISprint4Task1V3
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}