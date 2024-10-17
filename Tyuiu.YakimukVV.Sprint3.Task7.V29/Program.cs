using System;
using Tyuiu.YakimukVV.Sprint3.Task7.V29.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            DataService dataService = new DataService();  
            double[] values = dataService.GetMassFunction(-5, 5);
            Console.Title = "Спринт #3 | Выполнил: Якимук В. В. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Якимук Владислав Владимирович | ИБКСб-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("*            2x - 3                                                       *");
            Console.WriteLine("* F(x) =  ------------- + 5x - 6                                          *");
            Console.WriteLine("*          cos(x) - 2x                                                    *");
            Console.WriteLine("* (произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1 *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть значе  *");
            Console.WriteLine("* ние 0. Значения округлить до двух знаков после запятой.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Старт шага = -5");
            Console.WriteLine("Конец шага = 5");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i < values.Length; i++)
            {
                int x = -5 + i; 
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}   |", startValue, values[i]);
                startValue++;

            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
