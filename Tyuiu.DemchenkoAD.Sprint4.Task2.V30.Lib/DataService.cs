﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DemchenkoAD.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30
    {
        public int Calculate(int[] array)
        {
            int sumArray = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumArray *= array[i];
                }
            }

            return sumArray;
        }
    }
}
