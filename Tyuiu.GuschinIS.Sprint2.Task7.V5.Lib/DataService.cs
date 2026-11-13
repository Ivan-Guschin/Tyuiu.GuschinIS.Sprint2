using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GuschinIS.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Точка ВЫШЕ параболы (или на ней)
            bool aboveParabola = y >= Math.Pow(x, 2);

            // Точка НИЖЕ левой экспоненты (или на ней)
            bool belowLeftExp = y <= Math.Exp(-x);

            // Точка НИЖЕ правой экспоненты (или на ней)
            bool belowRightExp = y <= Math.Exp(x);

            // Все три условия должны выполняться
            return aboveParabola && belowLeftExp && belowRightExp;
        }
    }
}
