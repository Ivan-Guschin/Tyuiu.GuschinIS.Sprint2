using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint2.Task3.V25.Lib;

namespace Tyuiu.GuschinIS.Sprint2.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());        // читаем число

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод и выводим результат
            Console.WriteLine("Значение функции = " + ds.Calculate(x));

            Console.ReadLine();                                     // ждём Enter
        }
    }
}