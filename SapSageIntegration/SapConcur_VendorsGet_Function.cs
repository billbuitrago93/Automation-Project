using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SapSageIntegration.Services;
using SapSageIntegration.Services.Message;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SapConcur_VendorsGet_Function
    {
        private readonly SapConcurService _sapConcurService;

        public SapConcur_VendorsGet_Function(SapConcurService sapConcurService)
        {
            _sapConcurService = sapConcurService;
        }

        [FunctionName("SapConcur_VendorsGet_Function")]
        [return: ServiceBus("%MessageBusQueueName%", Connection = "MessageBusConnection")]
        public async Task<MessageDto> RunAsync([TimerTrigger("%SAPGetRequestTriggerTime%")] TimerInfo myTimer, ILogger log)
        {
            var vendors = await _sapConcurService.GetVendorsAsync();
            return new MessageDto(MessageType.Vendors, vendors);
        }
    }
}
