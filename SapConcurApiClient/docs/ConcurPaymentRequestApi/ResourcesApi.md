# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://hostname/concur/api/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InvoicePaymentrequestIdGet**](ResourcesApi.md#invoicepaymentrequestidget) | **GET** /invoice/paymentrequest/{id} | Gets all relevant information of a Payment Request.
[**InvoicePaymentrequestPost**](ResourcesApi.md#invoicepaymentrequestpost) | **POST** /invoice/paymentrequest | Create a new Payment Request.
[**InvoicePaymentrequestPut**](ResourcesApi.md#invoicepaymentrequestput) | **PUT** /invoice/paymentrequest | Update a Payment Request.


<a name="invoicepaymentrequestidget"></a>
# **InvoicePaymentrequestIdGet**
> PaymentRequest InvoicePaymentrequestIdGet (string id)

Gets all relevant information of a Payment Request.

This API Gets all relevant information (Payment Request Header, Payment Request Line Item and Payment Request Allocation) of a Payment Request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePaymentrequestIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | Payment Request ID.

            try
            {
                // Gets all relevant information of a Payment Request.
                PaymentRequest result = apiInstance.InvoicePaymentrequestIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoicePaymentrequestIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Payment Request ID. | 

### Return type

[**PaymentRequest**](PaymentRequest.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicepaymentrequestpost"></a>
# **InvoicePaymentrequestPost**
> CreateResponse InvoicePaymentrequestPost (PaymentRequestPost paymentRequest)

Create a new Payment Request.

Creates a new Payment Request with all relevant details including line items and associated allocations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePaymentrequestPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var paymentRequest = new PaymentRequestPost(); // PaymentRequestPost | An XML or JSON representation of a Payment Request.

            try
            {
                // Create a new Payment Request.
                CreateResponse result = apiInstance.InvoicePaymentrequestPost(paymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoicePaymentrequestPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentRequest** | [**PaymentRequestPost**](PaymentRequestPost.md)| An XML or JSON representation of a Payment Request. | 

### Return type

[**CreateResponse**](CreateResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="invoicepaymentrequestput"></a>
# **InvoicePaymentrequestPut**
> CreateResponse InvoicePaymentrequestPut (PaymentRequestPut paymentRequest)

Update a Payment Request.

Updates a Payment Request with all relevant details including line items and associated allocations.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InvoicePaymentrequestPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var paymentRequest = new PaymentRequestPut(); // PaymentRequestPut | An XML or JSON representation of a Payment Request.

            try
            {
                // Update a Payment Request.
                CreateResponse result = apiInstance.InvoicePaymentrequestPut(paymentRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.InvoicePaymentrequestPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **paymentRequest** | [**PaymentRequestPut**](PaymentRequestPut.md)| An XML or JSON representation of a Payment Request. | 

### Return type

[**CreateResponse**](CreateResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

