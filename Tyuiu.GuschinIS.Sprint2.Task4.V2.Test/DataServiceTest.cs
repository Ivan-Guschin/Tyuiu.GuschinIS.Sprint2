using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint2.Task4.V2.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]                                                // Тест 1: условие ИСТИННО
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;                                          // 10 > 5 + 3 (8) -> true
            double y = 5;
            double res = ds.Calculate(x, y);
            // Считаем: 10 + (11 / 5) = 10 + 2.2 = 12.2
            double wait = 12.2;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]                                                // Тест 2: условие ЛОЖНО
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;                                           // 1 > 2 + 3 (5) -> false
            double y = 2;
            double res = ds.Calculate(x, y);
            // Считаем: (2 + 5) / (2 + 2) = 7 / 4 = 1.75
            double wait = 1.75;
            Assert.AreEqual(wait, res);
        }
    }
}
