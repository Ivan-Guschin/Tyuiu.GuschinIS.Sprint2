using System;                                                      
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint2.Task6.V6.Lib;                         

namespace Tyuiu.GuschinIS.Sprint2.Task6.V6                          
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите масть (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите достоинство (6-14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Пытаемся получить название карты
                string res = ds.FindCardNameAndValue(m, k);
                Console.WriteLine(res);
            }
            catch (ArgumentException ex)
            {
                // Если ввели не то — ловим ошибку и пишем её
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadLine();                                     // ждём Enter
        }
    }
}
