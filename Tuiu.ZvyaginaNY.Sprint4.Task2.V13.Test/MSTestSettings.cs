using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint4.Task2.V13.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            
            int[] array = { 2, 4, 3, 6, 5, 8, 7, 9, 4, 2, 6, 8, 4 };
            int result = ds.Calculate(array);
            int wait = 589824; 
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateNoEven()
        {
            DataService ds = new DataService();

            
            int[] array = { 3, 5, 7, 9, 3, 5, 7, 9, 3, 5, 7, 9, 3 };
            int result = ds.Calculate(array);
            int wait = 0; 
            Assert.AreEqual(wait, result);
        }
    }
}