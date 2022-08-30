using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SapSageIntegration.Services.Message;

namespace SapSageIntegration
{
    public class SageIntactFunction
    {
        [FunctionName("SageIntactFunction")]
        public void Run([ServiceBusTrigger("%MessageBusQueueName%", Connection = "MessageBusConnection")] MessageDto myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem.Type}");
        }
    }
}
