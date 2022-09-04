using IO.Swagger.Api;
using SapConcurApiClient.Client;

namespace SapConcurApiClient.Api
{
    public class ConcurApiService
    {
        private readonly Configuration configuration;

        public ConcurExpenseReportsApi ExpenseReportsApi { get; private set; }
        public ConcurPaymentRequestDigestApi PaymentRequestDigestApi { get; private set; }
        public ConcurPaymentRequestApi PaymentRequestApi { get; private set; }
        public ConcurVendorsApi VendorsApi { get; private set; }

        public ConcurApiService(string basePath, string clientId, string clientSecret)
        {
            configuration = new Configuration();
            configuration.BasePath = basePath;
            // configuration.AccessToken = ConcurApiOAuthService.GetAuthToken(clientId, clientSecret);

            ExpenseReportsApi = new ConcurExpenseReportsApi(configuration);
            PaymentRequestDigestApi = new ConcurPaymentRequestDigestApi(configuration);
            PaymentRequestApi = new ConcurPaymentRequestApi(configuration);
            VendorsApi = new ConcurVendorsApi(configuration);
        }
    }
}
