using SapConcurApiClient.Api;
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
    public class SapConcurService
    {
        private readonly ConcurApiService _concurApiService;

        public SapConcurService(ConcurApiService concurApiService)
        {
            _concurApiService = concurApiService; 
        }

        public async Task<List<PaymentRequest>> GetInvoicesAsync()
        {
            var paymentRequests = new List<PaymentRequest>(); 
            var paymentRequestDigests = await _concurApiService.PaymentRequestDigestApi.InvoicePaymentrequestdigestsGetAsync();
           
            foreach (var item in paymentRequestDigests.Items)
            {
                var paymentRequest = await _concurApiService.PaymentRequestApi.InvoicePaymentrequestIdGetAsync(item.ID);
                paymentRequests.Add(paymentRequest);
            }
            return paymentRequests;
        }

        public async Task<List<ReportGet>> GetExpenseReportsAsync()
        {
            var expenseReports = await _concurApiService.ExpenseReportsApi.ExpenseReportsGetAsync(offset: null, limit: null, user: null, approvalStatusCode: null, paymentStatusCode: null, currencyCode: null, paymentType: null, reimbursementMethod: null, approverLoginID: null, expenseTypeCode: null, attendeeTypeCode: null, countryCode: null, batchID: null, vendorName: null, hasVAT: null, hasImages: null, hasAttendees: null, hasBillableExpenses: null, isTestUser: null, expenseGroupConfigID: null, entryTransactionDateBefore: null, entryTransactionDateAfter: null, createDateBefore: null, createDateAfter: null, userDefinedDateBefore: null, userDefinedDateAfter: null, submitDateBefore: null, submitDateAfter: null, processingPaymentDateBefore: null, processingPaymentDateAfter: null, paidDateBefore: null, paidDateAfter: null, modifiedDateBefore: null, modifiedDateAfter: null);
            return expenseReports.Items;
        }

        public async Task<List<Vendor>> GetVendorsAsync()
        {
            var vendorCollection = await _concurApiService.VendorsApi.InvoiceVendorsGetAsync(limit: 1000, offset: null, sortDirection: null, sortBy: null, searchType: null, vendorCode: null, vendorName: null, taxID: null, buyerAccountNumber: null, addressCode: null, address1: null, address2: null, address3: null, city: null, state: null, postalCode: null, approved: null, country: null, custom1: null, custom2: null, custom3: null, custom4: null, custom5: null, custom6: null, custom7: null, custom8: null, custom9: null, custom10: null, custom11: null, custom12: null, custom13: null, custom14: null, custom15: null, custom16: null, custom17: null, custom18: null, custom19: null, custom20: null);
            return vendorCollection.Items;
        }

        private bool IsValidUrl(string uriName) 
        {
            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult) && uriResult.Scheme == Uri.UriSchemeHttp;
            return result;
        }
    }
}
