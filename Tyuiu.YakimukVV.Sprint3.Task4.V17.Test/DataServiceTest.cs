using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint3.Task4.V17.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();

            double result = dataService.Calculate(-5, 5);

            Assert.AreEqual(0.527, result);
        }
    }
}
