﻿using System;
using Tyuiu.DemchenkoAD.Sprint4.Task2.V30.Lib;
namespace Tyuiu.DemchenkoAD.Sprint4.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Демченко А. Д. | ИСПб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Демченко Александра | ИСПб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов                     *");
            Console.WriteLine("* заполненный случайными в диапазоне от 2 до 8                            *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rnd.Next(2, 8);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);
            Console.WriteLine("Произведение нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
