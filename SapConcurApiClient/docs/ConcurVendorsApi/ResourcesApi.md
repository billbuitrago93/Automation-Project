# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://hostname/concur/api/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoiceVendorsDelete**](ResourcesApi.md#invoicevendorsdelete) | **DELETE** /invoice/vendors | Delete a vendor.
[**InvoiceVendorsGet**](ResourcesApi.md#invoicevendorsget) | **GET** /invoice/vendors | Retrieves an existing vendor.
[**InvoiceVendorsPost**](ResourcesApi.md#invoicevendorspost) | **POST** /invoice/vendors | Create vendor/s.
[**InvoiceVendorsPut**](ResourcesApi.md#invoicevendorsput) | **PUT** /invoice/vendors | Updates existing vendor/s.


<a name="invoicevendorsdelete"></a>
# **InvoiceVendorsDelete**
> VendorCollection InvoiceVendorsDelete (string vendorCode, string addressCode)

Delete a vendor.

Delete a vendor by Vendor Code and Address Code.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceVendorsDeleteExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var vendorCode = vendorCode_example;  // string | Vendor Code to be deleted
            var addressCode = addressCode_example;  // string | Address Code to be deleted

            try
            {
                // Delete a vendor.
                VendorCollection result = apiInstance.InvoiceVendorsDelete(vendorCode, addressCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoiceVendorsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendorCode** | **string**| Vendor Code to be deleted | 
 **addressCode** | **string**| Address Code to be deleted | 

### Return type

[**VendorCollection**](VendorCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicevendorsget"></a>
# **InvoiceVendorsGet**
> VendorCollection InvoiceVendorsGet (int? limit = null, string offset = null, string sortDirection = null, string sortBy = null, string searchType = null, string vendorCode = null, string vendorName = null, string taxID = null, string buyerAccountNumber = null, string addressCode = null, string address1 = null, string address2 = null, string address3 = null, string city = null, string state = null, string postalCode = null, string approved = null, string country = null, string custom1 = null, string custom2 = null, string custom3 = null, string custom4 = null, string custom5 = null, string custom6 = null, string custom7 = null, string custom8 = null, string custom9 = null, string custom10 = null, string custom11 = null, string custom12 = null, string custom13 = null, string custom14 = null, string custom15 = null, string custom16 = null, string custom17 = null, string custom18 = null, string custom19 = null, string custom20 = null)

Retrieves an existing vendor.

Gets an existing vendor.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceVendorsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var limit = 56;  // int? | The maximum number of items to be returned in a  response. The default is 25 and cannot exceed 1000. (optional) 
            var offset = offset_example;  // string | Specifies the starting point for the next query when iterating through the collection response.  Use with paged collections of resources. (optional) 
            var sortDirection = sortDirection_example;  // string | ascending or descending, The default value will be ascending. (optional) 
            var sortBy = sortBy_example;  // string | Field you need to the results to be sorted by. Vendor Name will be made default if no value is sent. Only fields that are added to the vendor form can be used here. Fields have to be specified by name as specified in Doc. (optional) 
            var searchType = searchType_example;  // string | Valid Options - exact, begins, contains and ends - Applies for the entire given search parameters. The default value if not sent is exact. (optional) 
            var vendorCode = vendorCode_example;  // string | Vendor Code to be searched (optional) 
            var vendorName = vendorName_example;  // string | Vendor Name to be searched (optional) 
            var taxID = taxID_example;  // string | Tax ID to be searched (optional) 
            var buyerAccountNumber = buyerAccountNumber_example;  // string | Buyer Account Number to be searched (optional) 
            var addressCode = addressCode_example;  // string | Address Code to be searched (optional) 
            var address1 = address1_example;  // string | Address 1 to be searched (optional) 
            var address2 = address2_example;  // string | Address 2 to be searched (optional) 
            var address3 = address3_example;  // string | Address 3 to be searched (optional) 
            var city = city_example;  // string | City to be searched (optional) 
            var state = state_example;  // string | State to be searched (optional) 
            var postalCode = postalCode_example;  // string | Postal Code to be searched (optional) 
            var approved = approved_example;  // string | Find Approved/Un Approved Vendors , True/False (optional) 
            var country = country_example;  // string | Country to be searched (optional) 
            var custom1 = custom1_example;  // string | Custom 1 to be searched (optional) 
            var custom2 = custom2_example;  // string | Custom 2 to be searched (optional) 
            var custom3 = custom3_example;  // string | Custom 3 to be searched (optional) 
            var custom4 = custom4_example;  // string | Custom 4 to be searched (optional) 
            var custom5 = custom5_example;  // string | Custom 5 to be searched (optional) 
            var custom6 = custom6_example;  // string | Custom 6 to be searched (optional) 
            var custom7 = custom7_example;  // string | Custom 7 to be searched (optional) 
            var custom8 = custom8_example;  // string | Custom 8 to be searched (optional) 
            var custom9 = custom9_example;  // string | Custom 9 to be searched (optional) 
            var custom10 = custom10_example;  // string | Custom 10 to be searched (optional) 
            var custom11 = custom11_example;  // string | Custom 11 to be searched (optional) 
            var custom12 = custom12_example;  // string | Custom 12 to be searched (optional) 
            var custom13 = custom13_example;  // string | Custom 13 to be searched (optional) 
            var custom14 = custom14_example;  // string | Custom 14 to be searched (optional) 
            var custom15 = custom15_example;  // string | Custom 15 to be searched (optional) 
            var custom16 = custom16_example;  // string | Custom 16 to be searched (optional) 
            var custom17 = custom17_example;  // string | Custom 17 to be searched (optional) 
            var custom18 = custom18_example;  // string | Custom 18 to be searched (optional) 
            var custom19 = custom19_example;  // string | Custom 19 to be searched (optional) 
            var custom20 = custom20_example;  // string | Custom 20 to be searched (optional) 

            try
            {
                // Retrieves an existing vendor.
                VendorCollection result = apiInstance.InvoiceVendorsGet(limit, offset, sortDirection, sortBy, searchType, vendorCode, vendorName, taxID, buyerAccountNumber, addressCode, address1, address2, address3, city, state, postalCode, approved, country, custom1, custom2, custom3, custom4, custom5, custom6, custom7, custom8, custom9, custom10, custom11, custom12, custom13, custom14, custom15, custom16, custom17, custom18, custom19, custom20);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoiceVendorsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The maximum number of items to be returned in a  response. The default is 25 and cannot exceed 1000. | [optional] 
 **offset** | **string**| Specifies the starting point for the next query when iterating through the collection response.  Use with paged collections of resources. | [optional] 
 **sortDirection** | **string**| ascending or descending, The default value will be ascending. | [optional] 
 **sortBy** | **string**| Field you need to the results to be sorted by. Vendor Name will be made default if no value is sent. Only fields that are added to the vendor form can be used here. Fields have to be specified by name as specified in Doc. | [optional] 
 **searchType** | **string**| Valid Options - exact, begins, contains and ends - Applies for the entire given search parameters. The default value if not sent is exact. | [optional] 
 **vendorCode** | **string**| Vendor Code to be searched | [optional] 
 **vendorName** | **string**| Vendor Name to be searched | [optional] 
 **taxID** | **string**| Tax ID to be searched | [optional] 
 **buyerAccountNumber** | **string**| Buyer Account Number to be searched | [optional] 
 **addressCode** | **string**| Address Code to be searched | [optional] 
 **address1** | **string**| Address 1 to be searched | [optional] 
 **address2** | **string**| Address 2 to be searched | [optional] 
 **address3** | **string**| Address 3 to be searched | [optional] 
 **city** | **string**| City to be searched | [optional] 
 **state** | **string**| State to be searched | [optional] 
 **postalCode** | **string**| Postal Code to be searched | [optional] 
 **approved** | **string**| Find Approved/Un Approved Vendors , True/False | [optional] 
 **country** | **string**| Country to be searched | [optional] 
 **custom1** | **string**| Custom 1 to be searched | [optional] 
 **custom2** | **string**| Custom 2 to be searched | [optional] 
 **custom3** | **string**| Custom 3 to be searched | [optional] 
 **custom4** | **string**| Custom 4 to be searched | [optional] 
 **custom5** | **string**| Custom 5 to be searched | [optional] 
 **custom6** | **string**| Custom 6 to be searched | [optional] 
 **custom7** | **string**| Custom 7 to be searched | [optional] 
 **custom8** | **string**| Custom 8 to be searched | [optional] 
 **custom9** | **string**| Custom 9 to be searched | [optional] 
 **custom10** | **string**| Custom 10 to be searched | [optional] 
 **custom11** | **string**| Custom 11 to be searched | [optional] 
 **custom12** | **string**| Custom 12 to be searched | [optional] 
 **custom13** | **string**| Custom 13 to be searched | [optional] 
 **custom14** | **string**| Custom 14 to be searched | [optional] 
 **custom15** | **string**| Custom 15 to be searched | [optional] 
 **custom16** | **string**| Custom 16 to be searched | [optional] 
 **custom17** | **string**| Custom 17 to be searched | [optional] 
 **custom18** | **string**| Custom 18 to be searched | [optional] 
 **custom19** | **string**| Custom 19 to be searched | [optional] 
 **custom20** | **string**| Custom 20 to be searched | [optional] 

### Return type

[**VendorCollection**](VendorCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicevendorspost"></a>
# **InvoiceVendorsPost**
> VendorCollection InvoiceVendorsPost (VendorCollection vendors)

Create vendor/s.

Create vendor/s and returns the status of creation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceVendorsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var vendors = new VendorCollection(); // VendorCollection | The vendor details.

            try
            {
                // Create vendor/s.
                VendorCollection result = apiInstance.InvoiceVendorsPost(vendors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoiceVendorsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendors** | [**VendorCollection**](VendorCollection.md)| The vendor details. | 

### Return type

[**VendorCollection**](VendorCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicevendorsput"></a>
# **InvoiceVendorsPut**
> VendorCollection InvoiceVendorsPut (VendorCollection vendors)

Updates existing vendor/s.

Updates existing vendor/s and returns the status of creation.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoiceVendorsPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var vendors = new VendorCollection(); // VendorCollection | The vendor details.

            try
            {
                // Updates existing vendor/s.
                VendorCollection result = apiInstance.InvoiceVendorsPut(vendors);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoiceVendorsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vendors** | [**VendorCollection**](VendorCollection.md)| The vendor details. | 

### Return type

[**VendorCollection**](VendorCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

