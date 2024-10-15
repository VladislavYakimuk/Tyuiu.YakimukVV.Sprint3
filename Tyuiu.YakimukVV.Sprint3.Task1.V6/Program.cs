using Tyuiu.YakimukVV.Sprint3.Task1.V6.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task1.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();
            int a = 4;
            int startValue = 1;
            int stopValue = 10;

            double result = dataService.GetSumSeries(a, startValue, stopValue);
            Console.WriteLine($"Сумма ряда: {result}");
        }
    }
}