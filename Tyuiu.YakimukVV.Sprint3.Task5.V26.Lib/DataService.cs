using tyuiu.cources.programming.interfaces.Sprint3;
using System;

namespace Tyuiu.YakimukVV.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double result = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    result += Math.Pow(x, k) + Math.Sin(k);
                }
            }

            return Math.Round(result, 3);
        }
    }
}
