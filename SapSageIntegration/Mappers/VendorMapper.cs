using Intacct.SDK.Functions.AccountsPayable;
using SapConcurApiClient.VendorModels;

namespace SapSageIntegration.Mappers
{
    public static class VendorMapper
    {
        public static VendorCreate Map(Vendor vendor)
        {
            return new VendorCreate();
        }
    }
}
