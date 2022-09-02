using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SapSageIntegration.Models;
using SapSageIntegration.Services;
using System.Text.Json;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SapConcurFunction
    {
        private readonly SapConcurService sapConcurService;

        public SapConcurFunction(IConfiguration configuration)
        {
            var config = new SapConcurConfig();
            config.BaseUrl = "https://sapconcurapi.azurewebsites.net/api/v3.0";
            sapConcurService = new SapConcurService(config);
        }

        [FunctionName("SAP-Concur-Function")]
        public async Task RunAsync([TimerTrigger(Consts.SAPGetRequestTriggerTime)] TimerInfo myTimer, ILogger log, [ServiceBus(Consts.MessageBusQueueName, Connection = Consts.MessageBusConnection)] IAsyncCollector<MessageDto> outputServiceBus)
        {
            var invoices = await sapConcurService.GetInvoicesAsync();
            await outputServiceBus.AddAsync(new MessageDto(MessageType.Invoices, JsonSerializer.Serialize(invoices)));

            var expenseRecords = await sapConcurService.GetExpenseReportsAsync();
            await outputServiceBus.AddAsync(new MessageDto(MessageType.ExpenseReports, JsonSerializer.Serialize(expenseRecords)));

            var vendors = await sapConcurService.GetVendorsAsync();
            await outputServiceBus.AddAsync(new MessageDto(MessageType.Vendors, JsonSerializer.Serialize(vendors)));
        }
    }
}
