using Microsoft.VisualStudio.TestTools.UnitTesting;                 
using System;                                                       
using Tyuiu.GuschinIS.Sprint2.Task5.V1.Lib;                         

namespace Tyuiu.GuschinIS.Sprint2.Task5.V1.Test                    
{
    [TestClass]                                                     
    public class DataServiceTest
    {
        [TestMethod]                                                // один тест на все месяцы
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();                     // создаём объект

            // Проверяем каждый месяц
            Assert.AreEqual(31, ds.FindMonthDaysCount(1));          // Январь
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));          // Февраль
            Assert.AreEqual(31, ds.FindMonthDaysCount(3));          // Март
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));          // Апрель
            Assert.AreEqual(31, ds.FindMonthDaysCount(5));          // Май
            Assert.AreEqual(30, ds.FindMonthDaysCount(6));          // Июнь
            Assert.AreEqual(31, ds.FindMonthDaysCount(7));          // Июль
            Assert.AreEqual(31, ds.FindMonthDaysCount(8));          // Август
            Assert.AreEqual(30, ds.FindMonthDaysCount(9));          // Сентябрь
            Assert.AreEqual(31, ds.FindMonthDaysCount(10));         // Октябрь
            Assert.AreEqual(30, ds.FindMonthDaysCount(11));         // Ноябрь
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));         // Декабрь

            // Проверяем, что при некорректном вводе выбрасывается ошибка
            Assert.ThrowsException<ArgumentException>(() => ds.FindMonthDaysCount(-1));
            Assert.ThrowsException<ArgumentException>(() => ds.FindMonthDaysCount(13));
        }
    }
}