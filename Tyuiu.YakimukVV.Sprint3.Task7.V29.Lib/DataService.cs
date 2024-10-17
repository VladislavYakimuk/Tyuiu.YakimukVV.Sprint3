using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.YakimukVV.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;  
            double[] results = new double[size];    

            for (int i = 0; i < size; i++)
            {
                double x = startValue + i;         
                results[i] = Math.Round(CalculateFunction(x), 2);  
            }

            return results; 
        }

        private double CalculateFunction(double x)
        {
            double numerator = 2 * x - 3; 
            double denominator = Math.Cos(x) - 2 * x; 

            if (denominator == 0)
                return 0; 

            return (numerator / denominator) + 5 * x - 6; 
        }
    }
}
