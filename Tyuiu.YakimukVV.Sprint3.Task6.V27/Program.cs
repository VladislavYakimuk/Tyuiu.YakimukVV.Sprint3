using Tyuiu.YakimukVV.Sprint3.Task6.V27.Lib;
namespace Tyuiu.YakimukVV.Sprint3.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int result = dataService.GetSumTheDivisors(14, 20);
            Console.WriteLine($"Сумма всех делителей больше 9 в диапазоне [14, 20]: {result}");
        }
    }
}
