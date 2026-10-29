using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint2.Task2.V4.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");     // просим X
            int x = Convert.ToInt32(Console.ReadLine());            // читаем X

            Console.WriteLine("Введите значение переменной Y: ");     // просим Y
            int y = Convert.ToInt32(Console.ReadLine());            // читаем Y

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод, получаем true/false
            bool res = ds.CheckDotInShadedArea(x, y);

            // Печатаем разный текст в зависимости от ответа
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadLine();                                     // ждём Enter
        }
    }
}

