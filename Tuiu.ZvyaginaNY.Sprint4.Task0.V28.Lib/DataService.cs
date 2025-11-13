using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tuiu.ZvyaginaNY.Sprint4.Task0.V28.Lib
{
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] array)
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
