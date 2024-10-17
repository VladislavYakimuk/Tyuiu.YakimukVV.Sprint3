using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakimukVV.Sprint3.Task6.V27.Lib
{
    public class DataService : ISprint3Task6V27
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int divisor = 1; divisor <= i; divisor++)
                {
                    if (i % divisor == 0 && divisor > 9)
                    {
                        totalSum += divisor;
                    }
                }
            }
            return totalSum;
        }
    }
}
