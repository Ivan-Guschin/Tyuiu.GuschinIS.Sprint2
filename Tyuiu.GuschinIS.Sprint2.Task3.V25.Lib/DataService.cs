using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GuschinIS.Sprint2.Task3.V25.Lib
{
    public class DataService : ISprint2Task3V25
    {
        public double Calculate(double x)
        {
            double y = 0;                                           // сюда будем записывать ответ

            // 1 ветка: если x > 1
            if (x > 1)
            {
                // sin(x^3) + ((x+1)/(x-1))^x
                y = Math.Sin(Math.Pow(x, 3)) + Math.Pow((x + 1) / (x - 1), x);
            }
            // 2 ветка: если x == 0
            else if (x == 0)
            {
                // x^2 - (cos(x^3) / (x-3))
                y = Math.Pow(x, 2) - (Math.Cos(Math.Pow(x, 3)) / (x - 3));
            }
            // 3 ветка: если -29 < x < 2
            else if (x > -29 && x < 2)
            {
                // (1 + 1/x^2)^x
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            // 4 ветка: если x < -29
            else if (x < -29)
            {
                // x + 15 + (12/x)^x
                y = x + 15 + Math.Pow(12 / x, x);
            }

            // Округляем до 3 знаков и возвращаем результат
            return Math.Round(y, 3);
        }
    }
}
