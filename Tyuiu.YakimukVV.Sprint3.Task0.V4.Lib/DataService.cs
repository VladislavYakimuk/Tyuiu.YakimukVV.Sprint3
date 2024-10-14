using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.YakimukVV.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1;
            double sinValue = Math.Sin(0.1);

            for (int k = startValue; k <= stopValue; k++)
            {
                product *= sinValue + k;
            }

            return Math.Round(product, 3);
        }
    }
}
