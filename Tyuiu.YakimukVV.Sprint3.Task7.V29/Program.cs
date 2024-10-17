using System;
using Tyuiu.YakimukVV.Sprint3.Task7.V29.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();  
            double[] values = dataService.GetMassFunction(-5, 5);  

            Console.WriteLine("Таблица значений функции F(x) на интервале [-5, 5]:");

            for (int i = 0; i < values.Length; i++)
            {
                int x = -5 + i; 
                Console.WriteLine($"F({x}) = {values[i]}"); 
            }
        }
    }
}
