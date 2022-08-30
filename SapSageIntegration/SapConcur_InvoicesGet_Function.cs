using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging; 
using SapSageIntegration.Services;
using SapSageIntegration.Services.Message;
using System.Text.Json;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SapConcur_InvoicesGet_Function
    {
        private readonly SapConcurService _sapConcurService;

        public SapConcur_InvoicesGet_Function(SapConcurService sapConcurService)
        {
            _sapConcurService = sapConcurService;
        }

        [FunctionName("SapConcur_InvoicesGet_Function")]
        [return: ServiceBus("%MessageBusQueueName%", Connection = "MessageBusConnection")]
        public async Task<MessageDto> RunAsync([TimerTrigger("%SAPGetRequestTriggerTime%")] TimerInfo myTimer, ILogger log)
        {
            var invoices = await _sapConcurService.GetInvoicesAsync(); 

            return new MessageDto(MessageType.Invoices, JsonSerializer.Serialize(invoices));
        }
    }
}
