using Tyuiu.YakimukVV.Sprint3.Task5.V26.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task5.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 13;

            double result = dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Результат: {result}");
        }
    }
}
