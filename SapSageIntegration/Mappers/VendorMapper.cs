using Intacct.SDK.Functions.AccountsPayable;
using SapConcurApiClient.VendorModels;
using Xml2CSharp;

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
