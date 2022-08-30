using Azure;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SapConcurApiClient.ExpenseReportModels;
using SapConcurApiClient.PaymentRequestModels;
using SapConcurApiClient.VendorModels;
using SapSageIntegration.Services;
using SapSageIntegration.Services.Message;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SageIntactFunction
    {
        private readonly SageIntactService _sageIntactService;
        private const byte MaxResendCount = 100;

        public SageIntactFunction(SageIntactService sageIntactService)
        {
            _sageIntactService = sageIntactService;
        }

        [FunctionName("SageIntactFunction")]
        public async Task RunAsync([ServiceBusTrigger("%MessageBusQueueName%", Connection = "MessageBusConnection")] MessageDto message, ILogger log, [ServiceBus("%MessageBusQueueName%", Connection = "MessageBusConnection")] IAsyncCollector<MessageDto> outputServiceBus)
        {
            try
            { 
                log.LogInformation($"C# ServiceBus queue trigger function processed message: {message.Type}, resendCount: {message.ResendCount}");
                switch (message.Type)
                {
                    case MessageType.Invoices:
                        await _sageIntactService.CreateARPaymentsAsync(Deserialize<List<PaymentRequest>>(message.Value));
                        throw new Exception("xxxx");
                        break;
                    case MessageType.Vendors:
                        await _sageIntactService.CreateVendorsAsync(Deserialize<List<Vendor>>(message.Value));
                        break;
                    case MessageType.ExpenseReports:
                        await _sageIntactService.CreateAPPaymentsAsync(Deserialize<List<ReportGet>>(message.Value));
                        break;
                    default:
                        throw new ArgumentException($"Bad message type: {message.Type}");
                } 
            }
            catch (Exception ex)
            {
                if (message.ResendCount < MaxResendCount)
                {
                    Thread.Sleep(3000);
                    message.ResendCount += 1;
                    message.ResendDesc = ex.Message; 
                    await outputServiceBus.AddAsync(message);
                    log.LogInformation($" {message.Type}, resendCount: {message.ResendDesc}");
                }
            }
        }

        private T Deserialize<T>(string content) 
        { 
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };

            return (T)JsonConvert.DeserializeObject(content, typeof(T), serializerSettings);
        }
    }
}
