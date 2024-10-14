using Tyuiu.YakimukVV.Sprint3.Task0.V4.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.YakimukVV.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new DataService();
            int startValue = 1;
            int stopValue = 7;

            double result = service.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(6482.439, result, 0.001); 
        }
    }
}
