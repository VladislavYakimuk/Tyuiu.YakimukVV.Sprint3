using Tyuiu.YakimukVV.Sprint3.Task0.V4.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task0.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();

            int startValue = 1;
            int stopValue = 7;

            double result = dataService.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine($"Произведение ряда от {startValue} до {stopValue} равно: {result}");
            int a = 4;
            int b = 2;
            int c = 1;
            int d = 9;
            int i = 1;
            while (i < 5)
            {
                a--;
                b -= a;
                c = b - a;
                d = (c + a) - i;
                i++;
            }
            Console.WriteLine(d);
        }
    }
}
