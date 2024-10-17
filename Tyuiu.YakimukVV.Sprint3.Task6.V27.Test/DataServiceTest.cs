using Tyuiu.YakimukVV.Sprint3.Task6.V27.Lib;
namespace Tyuiu.YakimukVV.Sprint3.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSumTheDivisors()
        {
            DataService dataService = new DataService();
            int expectedSum = 129; 

            int actualSum = dataService.GetSumTheDivisors(14, 20);

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
