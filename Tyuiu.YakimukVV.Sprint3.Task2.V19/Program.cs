using Tyuiu.YakimukVV.Sprint3.Task2.V19.Lib;
namespace Tyuiu.YakimukVV.Sprint3.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            double result = dataService.GetMultiplySeries(10, 1, 10);
            Console.WriteLine($"Сумма ряда: {result}");
        }
    }
}
