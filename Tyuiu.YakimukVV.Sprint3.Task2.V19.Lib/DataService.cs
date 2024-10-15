using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakimukVV.Sprint3.Task2.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            do
            {
                sum += Math.Cos(i) * 0.5;
                i++;
            } while (i <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
