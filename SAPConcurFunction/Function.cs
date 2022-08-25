using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SAPConcurFunction
{
    public class Function
    {
        [FunctionName("Function")]
        public void Run([ServiceBusTrigger("myqueue", Connection = "asdasd")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
