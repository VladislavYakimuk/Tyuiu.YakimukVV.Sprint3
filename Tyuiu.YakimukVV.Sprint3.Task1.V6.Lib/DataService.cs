using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YakimukVV.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = Math.Pow(value, k) + 1;
                sum += term * Math.Sin(k);
                k++;
            }

            return Math.Round(sum, 3);
        }
    }
}
