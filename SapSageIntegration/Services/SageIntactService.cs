using SapConcurApiClient.ExpenseReportModels;
using SapConcurApiClient.PaymentRequestModels;
using SapConcurApiClient.VendorModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SapSageIntegration.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SageIntactService
    {
        public SageIntactService()
        {

        }

        /// <summary>
        /// Creates <see href="https://developer.concur.com/api-reference/invoice/v3.vendor.html">SAP Vendors</see> 
        /// on <see href="https://developer.intacct.com/api/accounts-payable/vendors/#create-vendor">Sage Intact Vendors</see>
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateVendorsAsync(List<Vendor> items)
        {
           
        }

        /// <summary>
        /// Creates SAP Invoices (PaymentRequests) on Sage Intact AR Payments
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public async Task CreateARPaymentsAsync(List<PaymentRequest> items)
        {
        
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
