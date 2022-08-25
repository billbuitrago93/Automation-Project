using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using SapSageIntegration.Services;
using System;

namespace SapSageIntegration
{
    public class SapConcurFunction
    {
        private readonly MessageBusService _messageBusService;
        private readonly SapConcurService _sapConcurService;

        public SapConcurFunction(
            MessageBusService messageBusService,
            SapConcurService sapConcurService)
        {
            _messageBusService = messageBusService;
            _sapConcurService = sapConcurService;
        }

        [FunctionName("SapConcurFunction")]
        public void Run([TimerTrigger("0 */1 * * * *")] TimerInfo myTimer, ILogger log)
        {
            var startTime = DateTime.Now;
            var watch = System.Diagnostics.Stopwatch.StartNew();

            log.LogInformation($"SapConcurFunction Timer trigger function executed at: {startTime}");

            bool hasError = false;
            try
            {
                var vendors = _sapConcurService.GetVendorsAsync();
                _messageBusService.AddMessageToQueueAsync(MessageType.Vendors, vendors);
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"SapConcurFunction Vendors error");
                hasError = true;
            }

            try
            {
                var invoices = _sapConcurService.GetInvoicesAsync();
                _messageBusService.AddMessageToQueueAsync(MessageType.Invoices, invoices);
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"SapConcurFunction Invoices error");
                hasError = true;
            }

            try
            {
                var expenseRecords = _sapConcurService.GetExpenseReportsAsync();
                _messageBusService.AddMessageToQueueAsync(MessageType.ExpenseReports, expenseRecords);
            }
            catch (Exception ex)
            {
                log.LogError(ex, $"SapConcurFunction ExpenseReports error");
                hasError = true;
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            log.LogInformation($"SapConcurFunction Timer trigger function executed at: {startTime} - completed {(!hasError ? "succesfully" : "with error")}, duration: {elapsedMs}ms");
        }
    }
}
