using Bot;
using MessageQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFinancialChat
{
    [TestClass]
    public class BotUnitTests
    {
        [TestMethod]
        public void TestBot_CheckCommandIsOk()
        {
            var result = true;
            try
            {
                var bot = new BotService(new RabbitMQInfo
                {
                    Username = "nrpogasa",
                    Password = "IeFUZNy3tHlXDC_2HRExgdIV5uNplZIq",
                    HostName = "nrpogasa",
                    Uri = "amqps://nrpogasa:IeFUZNy3tHlXDC_2HRExgdIV5uNplZIq@orangutan.rmq.cloudamqp.com/nrpogasa",
                    VirtualHost = "nrpogasa"
                });
                bot.CheckStocksCommand("Hi, how are you?");
                bot.CheckStocksCommand("/stock=A.US");
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);
        }
    }
}
