using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SapConcurApiClient.ExpenseReportModels;
using SapConcurApiClient.PaymentRequestModels;
using SapConcurApiClient.VendorModels;
using SapSageIntegration.Models;
using SapSageIntegration.Services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SapSageIntegration
{
    public class SageIntactFunction
    {
        private readonly SageIntactService sageIntactService;
        private const byte MaxResendCount = 100;

        public SageIntactFunction()
        {
            var config = new SageIntactConfig();
            config.EndpointUrl = "https://api.intacct.com/ia/xml/xmlgw.phtml";
            config.SenderId = "SapSageInteg";
            config.SenderPassword = "Sage#ibn1996adam99";
            config.CompanyId = "Sample hdzjnrz";
            config.UserId = "SSIUser";
            config.UserPassword = "ERgB0Tj!j95";
            sageIntactService = new SageIntactService(config);
        }

        [FunctionName("Sage-Intact-Function")]
        public async Task RunAsync([ServiceBusTrigger(Consts.MessageBusQueueName, Connection = Consts.MessageBusConnection)] MessageDto message, ILogger log, [ServiceBus(Consts.MessageBusQueueName, Connection = Consts.MessageBusConnection)] IAsyncCollector<MessageDto> outputServiceBus)
        {
            try
            { 
                log.LogInformation($"C# ServiceBus queue trigger function processed message: {message.Type.ToString().ToUpper()}, resendCount: {message.ResendCount}");
                switch (message.Type)
                {
                    case MessageType.Invoices:
                        await sageIntactService.CreateARPaymentsAsync(Deserialize<List<PaymentRequest>>(message.Value));
                        break;
                    case MessageType.Vendors:
                        await sageIntactService.CreateVendorsAsync(Deserialize<List<Vendor>>(message.Value));
                        break;
                    case MessageType.ExpenseReports:
                        await sageIntactService.CreateAPPaymentsAsync(Deserialize<List<ReportGet>>(message.Value));
                        break;
                    default:
                        throw new ArgumentException($"Bad message type: {message.Type}");
                } 
            }
            catch (Exception ex)
            {
                if (message.ResendCount < MaxResendCount)
                {
                    Thread.Sleep(5000);
                    message.ResendCount += 1;
                    message.ResendDesc = ex.Message; 
                    await outputServiceBus.AddAsync(message);
                    log.LogError(ex, $"Resended message {message.Type}, resendCount: {message.ResendDesc}");
                }
            }
        }

        /// <summary>
        /// Deserialize using Newtonsoft.Json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
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
