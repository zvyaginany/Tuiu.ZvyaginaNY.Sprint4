using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZvyaginaNY.Sprint4.Task5.V26.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {-2, 3, 0, -1, 4},
                {1, -3, -4, 2, 0},
                {-4, 4, -1, 3, -2},
                {0, -2, 1, -3, 4},
                {-1, 2, -4, 0, 3}
            };

            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5]
            {
                {-2, 1, 0, -1, 1},
                {1, -3, -4, 1, 0},
                {-4, 1, -1, 1, -2},
                {0, -2, 1, -3, 1},
                {-1, 1, -4, 0, 1}
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}