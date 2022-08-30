using IO.Swagger.Api;
using SapConcurApiClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapConcurApiClient.Api
{
    public class ConcurApiService
    {
       // private const string BasePath = "https://www.concursolutions.com/api/v3.0";

        private readonly Configuration configuration;

        public ConcurExpenseReportsApi ExpenseReportsApi { get; private set; }
        public ConcurPaymentRequestDigestApi PaymentRequestDigestApi { get; private set; }
        public ConcurPaymentRequestApi PaymentRequestApi{ get; private set; }
        public ConcurVendorsApi VendorsApi { get; private set; }

        public ConcurApiService(string basePath)
        { 
            configuration = new Configuration();
            configuration.BasePath = basePath;
            //configuration.AccessToken = ConcurApiOAuthService.GetAuthToken("" ,"");

            ExpenseReportsApi = new ConcurExpenseReportsApi(configuration);
            PaymentRequestDigestApi = new ConcurPaymentRequestDigestApi(configuration);
            PaymentRequestApi = new ConcurPaymentRequestApi(configuration);
            VendorsApi = new ConcurVendorsApi(configuration);
        }
    }
}
