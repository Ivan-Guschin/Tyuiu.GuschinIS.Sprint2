using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GuschinIS.Sprint2.Task2.V4.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task2.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]                                                // один тест
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();                     // создаём объект

            int x = 6;                                              // берём точку внутри (Y=8, X=6)
            int y = 8;

            bool res = ds.CheckDotInShadedArea(x, y);               // вызываем метод
            bool wait = true;                                       // ожидаем true

            Assert.AreEqual(wait, res);                             // сверяем
        }
    }
}