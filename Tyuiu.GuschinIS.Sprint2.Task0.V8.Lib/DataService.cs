using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.GuschinIS.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Создаём массив из 6 элементов — все пока false
            bool[] res = new bool[6];

            // Заполняем по порядку. Проверка на примере x=185, y=251:
            res[0] = x != y;            // 185 != 251 → True
            res[1] = x == y;            // 185 == 251 → False
            res[2] = x < y;             // 185 <  251 → True
            res[3] = x > y;             // 185 >  251 → False
            res[4] = x <= y;            // 185 <= 251 → True
            res[5] = x >= y;            // 185 >= 251 → False

            return res;                 // возвращаем массив
        }
    }
}