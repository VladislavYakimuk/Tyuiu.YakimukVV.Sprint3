using Tyuiu.YakimukVV.Sprint3.Task1.V6.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var dataService = new DataService();
            int value = 4;
            int startValue = 1;
            int stopValue = 10;
            double expectedValue = -389102.25;
            double result = dataService.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(expectedValue, result, 0.001);
        }
    }
}
