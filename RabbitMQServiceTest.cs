using MessageQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RabbitMQ;

namespace UnitTestFinancialChat
{
    [TestClass]
    public class RabbitMQServiceTest
    {
        [TestMethod]
        public void RabbitMQService_CheckIfRabbitMQWorksFine()
        {
            var result = true;
            try
            {
                var rabbitMq = new RabbitMQService(new RabbitMQInfo
                {
                    Username = "nrpogasa",
                    Password = "IeFUZNy3tHlXDC_2HRExgdIV5uNplZIq",
                    HostName = "nrpogasa",
                    Uri = "amqps://nrpogasa:IeFUZNy3tHlXDC_2HRExgdIV5uNplZIq@orangutan.rmq.cloudamqp.com/nrpogasa",
                    VirtualHost = "nrpogasa"
                });
                rabbitMq.PublishMessage("test message");
            }
            catch
            {
                result = false;
            }

            Assert.IsTrue(result);
        }
    }
}
