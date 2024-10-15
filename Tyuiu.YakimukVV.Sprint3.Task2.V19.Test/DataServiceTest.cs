using Tyuiu.YakimukVV.Sprint3.Task2.V19.Lib;
namespace Tyuiu.YakimukVV.Sprint3.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double result = dataService.GetMultiplySeries(10, 1, 10);

            double expected = -0.709;
            Assert.AreEqual(expected, result, 0.001, "Результат не совпадает");
        }
    }
}
