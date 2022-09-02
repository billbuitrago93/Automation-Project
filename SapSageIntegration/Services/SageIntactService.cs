using Intacct.SDK;  
using SapConcurApiClient.ExpenseReportModels;
using SapConcurApiClient.PaymentRequestModels;
using SapConcurApiClient.VendorModels; 
using System.Collections.Generic;
using System.Threading.Tasks;
using SapSageIntegration.Mappers;
using Intacct.SDK.Functions;
using Intacct.SDK.Functions.AccountsReceivable;
using Intacct.SDK.Xml;

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
                SessionId = config.SessionId,
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
            var vendorCreateFunctions = new List<IFunction>(); 
            foreach (var item in items)
            {
                var vendorCreate = VendorMapper.Map(item);
                vendorCreateFunctions.Add(vendorCreate); 
            }
            var createTask = client.ExecuteBatch(vendorCreateFunctions);
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
            var arPaymentsCreateFunctions = new List<IFunction>();
            var z = default(string);
            var x = new ArPaymentCreate();
        }

        /// <summary>
        /// Creates SAP Expense Reports on Sage Intact AP Payments
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateAPPaymentsAsync(List<ReportGet> items)
        {

        }
    }
}
