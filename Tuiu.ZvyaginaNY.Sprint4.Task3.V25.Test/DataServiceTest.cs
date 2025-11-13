using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint4.Task3.V25.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 7, 3, 5, 3, 6 },
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 }
            };

            int result = ds.Calculate(array);
            int wait = 270; 
            Assert.AreEqual(wait, result);
        }
    }
}