using System;                                                       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;                 

namespace Tyuiu.GuschinIS.Sprint2.Task5.V1.Lib                      
{
    public class DataService : ISprint2Task5V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res;                                                // сюда запишем ответ

            // Используем оператор switch для выбора месяца
            switch (value)
            {
                // Месяцы, в которых 31 день: 1, 3, 5, 7, 8, 10, 12
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    res = 31;
                    break;

                // Месяцы, в которых 30 дней: 4, 6, 9, 11
                case 4:
                case 6:
                case 9:
                case 11:
                    res = 30;
                    break;

                // Февраль — 28 дней (если не високосный)
                case 2:
                    res = 28;
                    break;

                // Если ввели число не от 1 до 12 — выбрасываем ошибку
                default:
                    throw new ArgumentException("Номер месяца должен быть от 1 до 12. Значение: " + value);
            }

            return res;                                             // возвращаем результат
        }
    }
}
        
    
