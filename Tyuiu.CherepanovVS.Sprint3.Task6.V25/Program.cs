﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.CherepanovVS.Sprint3.Task6.V25.Lib;

namespace Tyuiu.CherepanovVS.Sprint3.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт 3                                                                  *");
            Console.WriteLine("*Тема: Обработка целочисленной информации                                  *");
            Console.WriteLine("*Задание #6                                                                *");
            Console.WriteLine("*Вариант #25                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих        *");
            Console.WriteLine("* числовому отрезку [16, 24] сумму всех делителей меньше 10                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            int startValue = 16;
            int stopValue = 24;
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadLine();
        }
    }
}
