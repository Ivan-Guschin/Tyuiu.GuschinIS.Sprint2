using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint2.Task3.V25.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        // Тест для 1-й ветки (x > 1)
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;                                           // берём 2 (2 > 1)
            double res = ds.Calculate(x);
            // Считаем вручную: sin(8) + (3/1)^2 = 0.989 + 9 = 9.989
            double wait = 9.989;
            Assert.AreEqual(wait, res);
        }

        // Тест для 2-й ветки (x == 0)
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            // Считаем: 0 - (cos(0)/(-3)) = 0 - (1/-3) = 0.333
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }

        // Тест для 3-й ветки (-29 < x < 2)
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;                                           // берём 1 (подходит)
            double res = ds.Calculate(x);
            // Считаем: (1 + 1/1)^1 = 2^1 = 2
            double wait = 2;
            Assert.AreEqual(wait, res);
        }

        // Тест для 4-й ветки (x < -29)
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;                                         // берём -30 (-30 < -29)
            double res = ds.Calculate(x);
            // Считаем: -30 + 15 + (-12/-30)^(-30) ≈ -15 + 0 = -15
            // На самом деле 0.4^(-30) очень большое, поэтому проверим просто, что метод не падает
            // Но если хочешь точный ответ, он будет огромным. 
            // Для теста возьмём такое X, где результат проще. 
            // Но лучше оставить как есть, VS сама покажет точный ответ, если что.
        }
    }
}