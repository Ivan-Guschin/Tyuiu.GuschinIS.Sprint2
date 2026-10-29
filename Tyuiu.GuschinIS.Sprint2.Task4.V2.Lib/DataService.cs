using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GuschinIS.Sprint2.Task4.V2.Lib
{
    public class DataService : ISprint2Task4V2
    {
        public double Calculate(double x, double y)
        {
            // Тернарный оператор: условие ? если_true : если_false
            // Условие: x > y + 3
            // Если да: x + (x + 1) / y
            // Если нет: (y + 5) / (y + 2)
            double z = (x > y + 3) ? (x + (x + 1) / y) : ((y + 5) / (y + 2));

            // Округляем до 3 знаков и возвращаем
            return Math.Round(z, 3);
        }
    }
}
