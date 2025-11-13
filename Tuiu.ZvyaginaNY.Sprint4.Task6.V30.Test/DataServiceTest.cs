using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZvyaginaNY.Sprint4.Task6.V30.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(array);
            string[] wait = new string[] { "Береза", "Сосна", "Осина" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}