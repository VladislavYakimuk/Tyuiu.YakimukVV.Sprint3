using Tyuiu.YakimukVV.Sprint3.Task3.V18.Lib;
namespace Tyuiu.YakimukVV.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var dataService = new DataService();
            string input = "4n5nvf 56 bgy";
            char replacementChar = 'n';
            string expectedOutput = "nnnnvf nn bgy";

            string actualOutput = dataService.ReplaceNumOnChar(input, replacementChar);

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
