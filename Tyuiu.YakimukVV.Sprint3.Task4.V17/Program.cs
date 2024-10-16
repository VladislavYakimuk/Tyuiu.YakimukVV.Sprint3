using Tyuiu.YakimukVV.Sprint3.Task4.V17.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double result = dataService.Calculate(startValue, stopValue);


            Console.WriteLine($"Значение функции: {result}");
        }
    }
}
