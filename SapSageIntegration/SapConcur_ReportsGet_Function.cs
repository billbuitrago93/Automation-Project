using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SapSageIntegration.Services;
using SapSageIntegration.Services.Message;
using System.Text.Json;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SapConcur_ReportsGet_Function
    {
        private readonly SapConcurService _sapConcurService;

        public SapConcur_ReportsGet_Function(SapConcurService sapConcurService)
        {
            _sapConcurService = sapConcurService;
        }

        [FunctionName("SapConcur_ReportsGet_Function")]
        [return: ServiceBus("%MessageBusQueueName%", Connection = "MessageBusConnection")]
        public async Task<MessageDto> RunAsync([TimerTrigger("%SAPGetRequestTriggerTime%")] TimerInfo myTimer, ILogger log)
        {
            var expenseRecords = await _sapConcurService.GetExpenseReportsAsync();
            return new MessageDto(MessageType.ExpenseReports, JsonSerializer.Serialize(expenseRecords)); 
        }
    }
}
