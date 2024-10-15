﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YakimukVV.Sprint3.Task3.V18.Lib
{
    public class DataService : ISprint3Task3V18
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            var result = new System.Text.StringBuilder();

            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    result.Append(item);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
