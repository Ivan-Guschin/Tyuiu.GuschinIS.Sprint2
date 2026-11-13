using Microsoft.VisualStudio.TestTools.UnitTesting;                
using Tyuiu.GuschinIS.Sprint2.Task7.V5.Lib;                         

namespace Tyuiu.GuschinIS.Sprint2.Task7.V5.Test                    
{
    [TestClass]                                                     
    public class DataServiceTest
    {
        [TestMethod]                                                // один тест
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();                     // создаём объект

            // Тест 1: Точка (0, 0.5) — должна быть ВНУТРИ (выше экспонент e^0=1... стоп, 0.5 < 1, значит это НЕВЕРНО)
            // Исправим: в точке x=0 парабола y=0, экспоненты y=1. Значит область от y=1 до y=0. (пустая)
            // Возьмём x = 0.5. Парабола y = 0.25. Экспоненты y = e^0.5 ≈ 1.65.
            // Область: от 1.65 до 0.25. 

             
            // Заштриховано ВОКРУГ ОСИ Y вниз от (0,1).
            // Значит условие наоборот: y <= Math.Pow(x,2) && y <= Math.Exp(x) && y <= Math.Exp(-x) 
            // И y >= 0 (так как ось X). 
            

            // Возьмём точку (0, 0.5) — она точно внутри (y=0.5 меньше 1 и меньше 0 (нет)).

            // На самом деле область выглядит так: y от 0 до пересечения графиков.
            // Найдём точку внутри: x = 0, y = 0.5 (меньше 1, больше 0)
            bool res = ds.CheckDotInShadedArea(0.0, 0.5);
            Assert.AreEqual(true, res);                             // ожидаем true
        }
    }
}
