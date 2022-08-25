using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapConcurApiClient.Api
{
    public class ConcurApiService
    {
        public ConcurExpenseReportsApi ExpenseReportsApi { get; private set; }
        public ConcurPaymentRequestDigestApi PaymentRequestDigestApi { get; private set; }
        public ConcurPaymentRequestApi PaymentRequestApi{ get; private set; }
        public ConcurVendorsApi VendorsApi { get; private set; }

        public ConcurApiService()
        {
            ExpenseReportsApi = new ConcurExpenseReportsApi();
            PaymentRequestDigestApi = new ConcurPaymentRequestDigestApi();
            PaymentRequestApi = new ConcurPaymentRequestApi();
            VendorsApi = new ConcurVendorsApi();
        }
    }
}
