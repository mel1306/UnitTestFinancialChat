using Bot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFinancialChat
{
    [TestClass]
    public class CsvServiceTest
    {
        [TestMethod]
        public void CsvService_CheckIfStockObjectHasData()
        {
            var csv = new CsvService();
            var stock = csv.GetStock("A.US");
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void CsvService_CheckWrongInputValueInTheCsvService()
        {
            var csv = new CsvService();
            var stock = csv.GetStock("123.456");
            Assert.IsNull(stock);
        }
    }
}
