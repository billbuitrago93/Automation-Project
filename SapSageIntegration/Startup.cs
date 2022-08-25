using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SapConcurApiClient.Api;
using SapSageIntegration;
using SapSageIntegration.Services;

[assembly: FunctionsStartup(typeof(Startup))]
namespace SapSageIntegration
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<SapConcurService>();
            builder.Services.AddSingleton<ConcurVendorsApi>();

            builder.Services.AddSingleton<MessageBusService>();
        }
    }
}
