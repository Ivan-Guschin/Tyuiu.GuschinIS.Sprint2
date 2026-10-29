using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GuschinIS.Sprint2.Task1.V1.Lib
{
    public class DataService : ISprint2Task1V1
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            // Создаём массив из 6 элементов
            bool[] res = new bool[6];

            // Заполняем по порядку — используем логические операторы по одному разу
            res[0] = (a < b) | (a < b);          // оператор |  (логическое ИЛИ)
            res[1] = (b > d) & (b > d);          // оператор &  (логическое И)
            res[2] = (c < d) || (c < d);         // оператор || (условное ИЛИ)
            res[3] = (a > c) && (a > c);         // оператор && (условное И)
            res[4] = !(a > c);                   // оператор !  (НЕ)
            res[5] = (a > d) ^ (a > d);          // оператор ^  (исключающее ИЛИ)

            return res;                          // возвращаем массив
        }
    }
}
