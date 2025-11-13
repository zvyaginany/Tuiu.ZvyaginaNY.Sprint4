using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tuiu.ZvyaginaNY.Sprint4.Task0.V28.Lib;

namespace Tuiu.ZvyaginaNY.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int result = ds.GetMultEvenArrEl(array);
            int wait = 9216; 
            Assert.AreEqual(wait, result);
        }
    }
}