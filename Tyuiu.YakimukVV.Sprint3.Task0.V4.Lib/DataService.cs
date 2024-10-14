﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YakimukVV.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1;
            for (int k = startValue; k <= stopValue; k++)
            {
                product *= Math.Sin(1) + k;
            }
            return product;
        }
    }
}
