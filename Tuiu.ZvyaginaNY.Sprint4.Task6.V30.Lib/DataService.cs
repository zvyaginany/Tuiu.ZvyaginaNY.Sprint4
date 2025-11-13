using tyuiu.cources.programming.interfaces.Sprint4;
using System;

namespace Tyuiu.ZvyaginaNY.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, element => element.Length > 5);
            return result;
        }
    }
}