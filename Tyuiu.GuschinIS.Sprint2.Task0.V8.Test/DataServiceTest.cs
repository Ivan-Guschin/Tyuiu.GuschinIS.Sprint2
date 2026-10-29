using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint2.Task0.V8.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task0.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();                     // создаём объект

            int x = 185;                                            // по заданию
            int y = 251;                                            // по заданию

            bool[] res = new bool[6];                               // массив под результат
            res = ds.GetCompareOperations(x, y);                    // вызываем метод

            // Ожидаемый массив из задания
            bool[] wait = new bool[6] { true, false, true, false, true, false };

            // CollectionAssert.AreEqual — сверяет МАССИВЫ поэлементно
            CollectionAssert.AreEqual(wait, res);
        }
    }
}