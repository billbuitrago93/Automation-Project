using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SapConcurApiClient.Api;
using SapSageIntegration;
using SapSageIntegration.Services;
using SapSageIntegration.Services.Message;

[assembly: FunctionsStartup(typeof(Startup))]
namespace SapSageIntegration
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //var configuration = builder.GetContext().Configuration;
            //string queueName = configuration.GetValue<string>("MessageBusQueueName"); 
            //string connectionString = configuration.GetValue<string>("MessageBusConnection");
            //builder.Services.AddSingleton(new MessageBusService(connectionString, queueName));

            const string sapApiBaseUrl = "http://localhost:50352/api/v3.0";
            builder.Services.AddSingleton(new ConcurApiService(sapApiBaseUrl));
            builder.Services.AddSingleton<SapConcurService>();
            builder.Services.AddSingleton<SageIntactService>();
        }
    }
}
