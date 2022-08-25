using SapConcurApiClient.Api;
using SapConcurApiClient.VendorModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SapSageIntegration.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SapConcurService
    {
        private const string BaseUrl = "";
        private readonly ConcurVendorsApi _concurVendorsApi;

        public SapConcurService(ConcurVendorsApi concurVendorsApi)
        {
            _concurVendorsApi = concurVendorsApi; 
        }

        public async Task<List<object>> GetInvoicesAsync()
        {
            return new List<object>();
        }

        public async Task<List<object>> GetExpenseReportsAsync()
        {
            return new List<object>();
        }

        public async Task<List<Vendor>> GetVendorsAsync()
        {
            var vendorCollection = await _concurVendorsApi.InvoiceVendorsGetAsync(limit: 1000, offset: null, sortDirection: null, sortBy: null, searchType: null, vendorCode: null, vendorName: null, taxID: null, buyerAccountNumber: null, addressCode: null, address1: null, address2: null, address3: null, city: null, state: null, postalCode: null, approved: null, country: null, custom1: null, custom2: null, custom3: null, custom4: null, custom5: null, custom6: null, custom7: null, custom8: null, custom9: null, custom10: null, custom11: null, custom12: null, custom13: null, custom14: null, custom15: null, custom16: null, custom17: null, custom18: null, custom19: null, custom20: null);
            return (List<Vendor>)vendorCollection.Items;
        }
    }
}
