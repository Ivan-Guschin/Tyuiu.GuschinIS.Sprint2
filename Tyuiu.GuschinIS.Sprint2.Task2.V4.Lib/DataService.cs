using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GuschinIS.Sprint2.Task2.V4.Lib
{
    public class DataService : ISprint2Task2V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // Проверяем каждую строку Y отдельно
            // Y=3: X = 3, 4, 9, 12
            if (y == 3 && (x == 3 || x == 4 || x == 9 || x == 12)) return true;

            // Y=4: X = 3, 4, 5, 9, 12
            if (y == 4 && (x == 3 || x == 4 || x == 5 || x == 9 || x == 12)) return true;

            // Y=5: X = 5, 6, 7, 8, 9, 12, 13, 14
            if (y == 5 && (x >= 5 && x <= 9 || x >= 12 && x <= 14)) return true;

            // Y=6: X = 3..13 (почти всё)
            if (y == 6 && (x >= 3 && x <= 13)) return true;

            // Y=7: X = 4..11
            if (y == 7 && (x >= 4 && x <= 11)) return true;

            // Y=8, 9, 10: X = 5..8
            if ((y == 8 || y == 9 || y == 10) && (x >= 5 && x <= 8)) return true;

            // Y=11: X = 3..8, 10..12
            if (y == 11 && (x >= 3 && x <= 8 || x >= 10 && x <= 12)) return true;

            // Y=12: X = 4..8
            if (y == 12 && (x >= 4 && x <= 8)) return true;

            // Y=13: X = 5, 6
            if (y == 13 && (x == 5 || x == 6)) return true;

            // Y=14: X = 6, 7
            if (y == 14 && (x == 6 || x == 7)) return true;

            // Если ни одно условие не сработало — точка вне области
            return false;
        }
    }
}
