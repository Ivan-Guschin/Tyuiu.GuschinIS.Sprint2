using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint2.Task1.V1.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]                                                // один тест
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();                     // создаём объект

            // Числа из задания
            int a = 119;
            int b = 196;
            int c = 134;
            int d = 327;

            bool[] res = new bool[6];                               // массив под результат
            res = ds.GetLogicOperations(a, b, c, d);                // вызываем метод

            // Ожидаемый массив из задания
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            // CollectionAssert.AreEqual — сверяет МАССИВЫ поэлементно
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
