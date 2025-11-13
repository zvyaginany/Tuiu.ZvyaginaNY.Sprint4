using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ZvyaginaNY.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "753159864";

            int res = ds.Calculate(n, m, value);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}