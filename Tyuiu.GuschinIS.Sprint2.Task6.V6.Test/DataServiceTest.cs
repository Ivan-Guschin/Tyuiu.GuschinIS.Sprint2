using Microsoft.VisualStudio.TestTools.UnitTesting;                 
using System;                                                       
using Tyuiu.GuschinIS.Sprint2.Task6.V6.Lib;                        

namespace Tyuiu.GuschinIS.Sprint2.Task6.V6.Test                  
{
    [TestClass]                                                     // класс с тестами
    public class DataServiceTest
    {
        [TestMethod]                                                // один тест
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();                     // создаём объект

            // Проверяем разные карты
            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));    // масть=1 (пики), достоинство=12 (дама)
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(3, 6)); // масть=3 (бубны), достоинство=6
            Assert.AreEqual("Туз червей", ds.FindCardNameAndValue(4, 14));  // масть=4 (черви), достоинство=14
            Assert.AreEqual("Король треф", ds.FindCardNameAndValue(2, 13)); // масть=2 (трефы), достоинство=13

            // Проверяем, что при неверных данных выбрасывается ошибка
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(5, 10)); // масть не та
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardNameAndValue(1, 15)); // достоинство не то
        }
    }
}