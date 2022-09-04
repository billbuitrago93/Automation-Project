using Intacct.SDK;
using Intacct.SDK.Functions;
using Intacct.SDK.Functions.AccountsReceivable;
using Intacct.SDK.Xml;
using SapConcurApiClient.ExpenseReportModels;
using SapConcurApiClient.PaymentRequestModels;
using SapConcurApiClient.VendorModels;
using SapSageIntegration.Mappers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SapSageIntegration.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SageIntactService
    {
        private readonly OnlineClient client;
        public SageIntactService(SageIntactConfig config)
        {
            var clientConfig = new ClientConfig()
            {
                EndpointUrl = config.EndpointUrl,
                EntityId = config.EntityId,
                CompanyId = config.CompanyId,
                SenderId = config.SenderId,
                SenderPassword = config.SenderPassword,
                UserId = config.UserId,
                UserPassword = config.UserPassword,
            };
            client = new OnlineClient(clientConfig);
        }

        /// <summary>
        /// Creates <see href="https://developer.concur.com/api-reference/invoice/v3.vendor.html">SAP Vendors</see> 
        /// on <see href="https://developer.intacct.com/api/accounts-payable/vendors/#create-vendor">Sage Intact Vendors</see>
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateVendorsAsync(List<Vendor> items)
        {
            var createFunctions = new List<IFunction>();
            foreach (var item in items)
            {
                var mappedFunction = new VendorMapper(item);
                createFunctions.Add(mappedFunction); 

            }
            var createTask = client.ExecuteBatch(createFunctions);
            createTask.Wait();

            //OnlineResponse createResponse = createTask.Result;
        }

        /// <summary>
        /// Creates SAP Invoices (PaymentRequests) on Sage Intact AR Payments
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateARPaymentsAsync(List<PaymentRequest> items)
        {
            var createFunctions = new List<IFunction>();
            foreach (var item in items)
            {
                var mappedFunction = new InvoiceMapper(item);
                createFunctions.Add(mappedFunction);
            }
            var createTask = client.ExecuteBatch(createFunctions);
            createTask.Wait(); 
        }

        /// <summary>
        /// Creates SAP Expense Reports on Sage Intact AP Payments
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateAPPaymentsAsync(List<ReportGet> items)
        {

        }

        private string FunctionXmlToString(IFunction function) 
        {
            Stream stream = new MemoryStream();
            XmlWriterSettings xmlSettings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true,
                IndentChars = "    "
            };
            IaXmlWriter xml = new IaXmlWriter(stream, xmlSettings);

            function.WriteXml(ref xml);

            xml.Flush();
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
             
            return reader.ReadToEnd();
        }
    }
}
