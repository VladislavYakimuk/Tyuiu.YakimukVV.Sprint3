using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YakimukVV.Sprint3.Task7.V29.Lib;

namespace Tyuiu.YakimukVV.Sprint3.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFunctionValues()
        {
            DataService dataService = new DataService();

            double[] expectedValues = {
                -32.26,  // F(-5)
                -27.5,   // F(-4)
                -22.8,   // F(-3)
                -17.95,  // F(-2)
                -12.97,  // F(-1)
                -9.0,    // F(0)
                -0.31,   // F(1)
                3.77,    // F(2)
                8.57,    // F(3)
                13.42,   // F(4)
                18.28    // F(5)
            };

            double[] actualValues = dataService.GetMassFunction(-5, 5);

            for (int i = 0; i < expectedValues.Length; i++)
            {
                Assert.AreEqual(expectedValues[i], actualValues[i], 0.01);
            }
        }
    }
}
