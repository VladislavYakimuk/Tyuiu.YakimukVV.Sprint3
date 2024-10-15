using Tyuiu.YakimukVV.Sprint3.Task3.V18.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task3.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();

            string input = "4n5nvf 56 bgy";

            string result = dataService.ReplaceNumOnChar(input, 'n');

            Console.WriteLine("Результат замены цифр на 'n':");
            Console.WriteLine(result);
        }
    }
}
