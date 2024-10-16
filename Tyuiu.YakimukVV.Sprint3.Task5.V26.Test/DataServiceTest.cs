using Tyuiu.YakimukVV.Sprint3.Task5.V26.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.YakimukVV.Sprint3.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            DataService dataService = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 13;

            double result = dataService.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);


            double expected = 49146.884;
            Assert.AreEqual(expected, result, 0.001, "Метод возвращает неправильный результат");
        }
    }
}
