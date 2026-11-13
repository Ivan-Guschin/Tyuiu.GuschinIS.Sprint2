using System;                                                      
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;                 

namespace Tyuiu.GuschinIS.Sprint2.Task6.V6.Lib                     
{
    public class DataService : ISprint2Task6V6
    {
        // Метод принимает масть (m) и достоинство (k), возвращает название карты
        public string FindCardNameAndValue(int m, int k)
        {
            // Проверяем корректность ввода: масть 1-4, достоинство 6-14
            if (m < 1 || m > 4 || k < 6 || k > 14)
            {
                throw new ArgumentException("Неверные значения масти или достоинства");
            }

            // Сокращённая форма записи switch (switch expression)
            // Сначала определяем масть
            string suit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new ArgumentException("Неверная масть") // _ это default
            };

            // Теперь определяем достоинство
            string rank = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => throw new ArgumentException("Неверное достоинство")
            };

            // Склеиваем в одну строку: "Дама пик"
            return $"{rank} {suit}";
        }
    }
}