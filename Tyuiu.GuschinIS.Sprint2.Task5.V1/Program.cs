using System;                                                       
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GuschinIS.Sprint2.Task5.V1.Lib;                         

namespace Tyuiu.GuschinIS.Sprint2.Task5.V1                          
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();                     // создаём объект

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");               // просим номер
            int numMonth = Convert.ToInt32(Console.ReadLine());     // читаем число

            string res;                                             // сюда запишем ответ

            // Проверяем, что число в правильном диапазоне
            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введено неверное значение!";                 // если нет — пишем ошибку
            }
            else
            {
                // Вызываем метод и формируем строку
                res = "Количество дней в месяце: " + ds.FindMonthDaysCount(numMonth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);                                 // печатаем результат

            Console.ReadLine();                                     // ждём Enter
        }
    }
}
