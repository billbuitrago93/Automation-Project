# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://hostname/concur/api/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoicePaymentrequestdigestsGet**](ResourcesApi.md#invoicepaymentrequestdigestsget) | **GET** /invoice/paymentrequestdigests | Get all payment requests digests based on the search criteria.
[**InvoicePaymentrequestdigestsIdGet**](ResourcesApi.md#invoicepaymentrequestdigestsidget) | **GET** /invoice/paymentrequestdigests/{id} | Get the payment request digest based on ID. 


<a name="invoicepaymentrequestdigestsget"></a>
# **InvoicePaymentrequestdigestsGet**
> PaymentRequestDigestCollection InvoicePaymentrequestdigestsGet (string offset = null, int? limit = null, string approvalStatus = null, string paymentStatus = null, string vendorInvoiceNumber = null, DateTime? createDateBefore = null, DateTime? createDateAfter = null, DateTime? userDefinedDateBefore = null, DateTime? userDefinedDateAfter = null, DateTime? submitDateBefore = null, DateTime? submitDateAfter = null, DateTime? paidDateBefore = null, DateTime? paidDateAfter = null)

Get all payment requests digests based on the search criteria.

Returns all payment requests digests based on the search criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePaymentrequestdigestsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var offset = offset_example;  // string | The start of the page offset. (optional) 
            var limit = 56;  // int? | The number of records to return (default 1000). (optional) 
            var approvalStatus = approvalStatus_example;  // string | A code representing a Payment Request Approval Status. Use GET /invoice/localizeddata to get the available approval status codes. (optional) 
            var paymentStatus = paymentStatus_example;  // string | A code representing a Payment Request Payment Status. Use GET /invoice/localizeddata to get the available payment status codes (optional) 
            var vendorInvoiceNumber = vendorInvoiceNumber_example;  // string | Vendor invoice number tied to invoice. (optional) 
            var createDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request create date is before this date.Format: YYYY-MM-DD. (optional) 
            var createDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request create date is after this date.Format: YYYY-MM-DD. (optional) 
            var userDefinedDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request user defined date is before this date.Format: YYYY-MM-DD. (optional) 
            var userDefinedDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request user defined date is after this date.Format: YYYY-MM-DD. (optional) 
            var submitDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request submit date is before this date.Format: YYYY-MM-DD. (optional) 
            var submitDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request submit date is after this date.Format: YYYY-MM-DD. (optional) 
            var paidDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request paid date is before this date.Format: YYYY-MM-DD. (optional) 
            var paidDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The payment request paid date is after this date.Format: YYYY-MM-DD. (optional) 

            try
            {
                // Get all payment requests digests based on the search criteria.
                PaymentRequestDigestCollection result = apiInstance.InvoicePaymentrequestdigestsGet(offset, limit, approvalStatus, paymentStatus, vendorInvoiceNumber, createDateBefore, createDateAfter, userDefinedDateBefore, userDefinedDateAfter, submitDateBefore, submitDateAfter, paidDateBefore, paidDateAfter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoicePaymentrequestdigestsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **string**| The start of the page offset. | [optional] 
 **limit** | **int?**| The number of records to return (default 1000). | [optional] 
 **approvalStatus** | **string**| A code representing a Payment Request Approval Status. Use GET /invoice/localizeddata to get the available approval status codes. | [optional] 
 **paymentStatus** | **string**| A code representing a Payment Request Payment Status. Use GET /invoice/localizeddata to get the available payment status codes | [optional] 
 **vendorInvoiceNumber** | **string**| Vendor invoice number tied to invoice. | [optional] 
 **createDateBefore** | **DateTime?**| The payment request create date is before this date.Format: YYYY-MM-DD. | [optional] 
 **createDateAfter** | **DateTime?**| The payment request create date is after this date.Format: YYYY-MM-DD. | [optional] 
 **userDefinedDateBefore** | **DateTime?**| The payment request user defined date is before this date.Format: YYYY-MM-DD. | [optional] 
 **userDefinedDateAfter** | **DateTime?**| The payment request user defined date is after this date.Format: YYYY-MM-DD. | [optional] 
 **submitDateBefore** | **DateTime?**| The payment request submit date is before this date.Format: YYYY-MM-DD. | [optional] 
 **submitDateAfter** | **DateTime?**| The payment request submit date is after this date.Format: YYYY-MM-DD. | [optional] 
 **paidDateBefore** | **DateTime?**| The payment request paid date is before this date.Format: YYYY-MM-DD. | [optional] 
 **paidDateAfter** | **DateTime?**| The payment request paid date is after this date.Format: YYYY-MM-DD. | [optional] 

### Return type

[**PaymentRequestDigestCollection**](PaymentRequestDigestCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicepaymentrequestdigestsidget"></a>
# **InvoicePaymentrequestdigestsIdGet**
> PaymentRequestDigest InvoicePaymentrequestdigestsIdGet (string id)

Get the payment request digest based on ID. 

Returns the payment request digest based on ID. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePaymentrequestdigestsIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The payment request ID

            try
            {
                // Get the payment request digest based on ID. 
                PaymentRequestDigest result = apiInstance.InvoicePaymentrequestdigestsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoicePaymentrequestdigestsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The payment request ID | 

### Return type

[**PaymentRequestDigest**](PaymentRequestDigest.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

