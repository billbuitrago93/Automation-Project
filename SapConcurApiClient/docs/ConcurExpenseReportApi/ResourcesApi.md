# IO.Swagger.Api.ResourcesApi

All URIs are relative to *https://hostname/concur/api/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExpenseReportsGet**](ResourcesApi.md#expensereportsget) | **GET** /expense/reports | Gets all reports
[**ExpenseReportsIdGet**](ResourcesApi.md#expensereportsidget) | **GET** /expense/reports/{id} | Gets a single report
[**ExpenseReportsIdPut**](ResourcesApi.md#expensereportsidput) | **PUT** /expense/reports/{id} | Update report
[**ExpenseReportsPost**](ResourcesApi.md#expensereportspost) | **POST** /expense/reports | Create a new report


<a name="expensereportsget"></a>
# **ExpenseReportsGet**
> ReportCollection ExpenseReportsGet (string offset = null, int? limit = null, string user = null, string approvalStatusCode = null, string paymentStatusCode = null, string currencyCode = null, string paymentType = null, string reimbursementMethod = null, string approverLoginID = null, string expenseTypeCode = null, string attendeeTypeCode = null, string countryCode = null, string batchID = null, string vendorName = null, bool? hasVAT = null, bool? hasImages = null, bool? hasAttendees = null, bool? hasBillableExpenses = null, bool? isTestUser = null, string expenseGroupConfigID = null, DateTime? entryTransactionDateBefore = null, DateTime? entryTransactionDateAfter = null, DateTime? createDateBefore = null, DateTime? createDateAfter = null, DateTime? userDefinedDateBefore = null, DateTime? userDefinedDateAfter = null, DateTime? submitDateBefore = null, DateTime? submitDateAfter = null, DateTime? processingPaymentDateBefore = null, DateTime? processingPaymentDateAfter = null, DateTime? paidDateBefore = null, DateTime? paidDateAfter = null, DateTime? modifiedDateBefore = null, DateTime? modifiedDateAfter = null)

Gets all reports

Returns all reports owned by the user based on the search criteria.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpenseReportsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var offset = offset_example;  // string | Starting page offset (optional) 
            var limit = 56;  // int? | Number of records to return (default 25) (optional) 
            var user = user_example;  // string | Optional. The login ID of the report owner(s) to use when searching for reports. If the value is set to LoginID, reports for the report owner with this login ID value are returned. If the value is set to ALL, reports for all report owners are returned. If this parameter is not specified, reports for the OAuth Consumer are returned. The access token owner (OAuth Consumer) must have the Web Services Admin role to use this parameter. (optional) 
            var approvalStatusCode = approvalStatusCode_example;  // string | The status code for the Approval Status. The values can include Concur Expense standard codes or custom codes. The Concur Expense standard code values are: A_AAFH - Report submission triggered an anomaly and fraud check; A_ACCO - Report is pending reviews; A_APPR - Report has been approved; A_EXTV - Report is pending external validation; A_FILE - Report has been submitted; A_NOTF - Report has not been submitted; A_PBDG - Report approval is pending Budget approval; A_PECO - Report approval is pending Cost object approval; A_PEND - Report is pending manager approval; A_PVAL - Report is pending prepayment validation; A_RESU - Report needs to be resubmitted; A_RHLD - Report submission is pending receipt images; A_TEXP - Report expired in approval queue. For custom codes, contact Concur Developer Support. (optional) 
            var paymentStatusCode = paymentStatusCode_example;  // string | The payment status code for the report. The values can include Concur Expense standard codes or custom codes. The Concur Expense standard code values are: P_HOLD - Report payment is on hold; P_NOTP - Report has not been paid; P_PAID - Report has been paid; P_PAYC - Payment is confirmed. Some or all of the report expenses have been paid; P_PROC - Report is in process to be paid. For custom codes, contact Concur Developer Support. (optional) 
            var currencyCode = currencyCode_example;  // string | The 3-letter ISO 4217 currency code for the report currency. Example: USD. (optional) 
            var paymentType = paymentType_example;  // string | The unique identifier for the payment type that is the payment type for at least one expense entry in the report. Use PaymentTypeID from the \"GET Expense Group Configurations\" function. (optional) 
            var reimbursementMethod = reimbursementMethod_example;  // string | The method the report owner will be reimbursed. VALUES: ADPPAYR - ADP Payroll; APCHECK - AP (Company Check); CNQRPAY - Expense Pay; PMTSERV - Other Payment Service. NOTE: PAY_PAL is NOT supported. (optional) 
            var approverLoginID = approverLoginID_example;  // string | The login ID for the report approver that is the current approver assigned to the report. (optional) 
            var expenseTypeCode = expenseTypeCode_example;  // string | The expense type code that is the expense type for at least one expense entry in the report. Use ExpenseTypeCode from the \"GET Expense Group Configurations\" function. (optional) 
            var attendeeTypeCode = attendeeTypeCode_example;  // string | The report contains expense entries that have attendees of the specified type. (optional) 
            var countryCode = countryCode_example;  // string | The report country. Maximum 2 characters. Format: The ISO 3166-1 alpha-2 country code. Example: United States is US. (optional) 
            var batchID = batchID_example;  // string | The unique identifier for a payment batch where there is at least one report payee within the report. Use the BatchID from the \"GET Payment Batch List\" function. (optional) 
            var vendorName = vendorName_example;  // string | The Vendor Description that is the vendor for at least one expense entry in the report. (optional) 
            var hasVAT = true;  // bool? | Determines if the report has at least one expense entry with VAT details. Format: true or false. (optional) 
            var hasImages = true;  // bool? | Determines if the report has at least one expense entry with an entry image or if there is a report image for this report. Format: true or false. (optional) 
            var hasAttendees = true;  // bool? | Determines if the report has at least one expense entry with an attendee. Format: true or false. (optional) 
            var hasBillableExpenses = true;  // bool? | The IsBillable flag for at least one expense entry in the report. Format: true or false. (optional) 
            var isTestUser = true;  // bool? | The report owner is a test user using the report for testing purposes in a non-production envirnment. format: true or false. (optional) 
            var expenseGroupConfigID = expenseGroupConfigID_example;  // string | The unique identifier for the expense group configuration associated to the report's expense group. Use the ID from the \"GET Expense Group Configurations\" function. (optional) 
            var entryTransactionDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The entry transaction date for at least one expense entry in the report is before this date.Format: YYYY-MM-DD (optional) 
            var entryTransactionDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The entry transaction date for at least one expense entry in the report is after this date.Format: YYYY-MM-DD (optional) 
            var createDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report create date is before this date.Format: YYYY-MM-DD (optional) 
            var createDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report create date is after this date.Format: YYYY-MM-DD (optional) 
            var userDefinedDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report user defined date is before this date.Format: YYYY-MM-DD (optional) 
            var userDefinedDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report user defined date is after this date.Format: YYYY-MM-DD (optional) 
            var submitDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report submit date is before this date.Format: YYYY-MM-DD (optional) 
            var submitDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report submit date is after this date.Format: YYYY-MM-DD (optional) 
            var processingPaymentDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report processing payment date is before this date.Format: YYYY-MM-DD (optional) 
            var processingPaymentDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report processing payment date is after this date. Format: YYYY-MM-DD (optional) 
            var paidDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report paid date is before this date.Format: YYYY-MM-DD (optional) 
            var paidDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report paid date is after this date.Format: YYYY-MM-DD (optional) 
            var modifiedDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | The report modified date is before this date.Format: YYYY-MM-DD (optional) 
            var modifiedDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | The report modified date is after this date.Format: YYYY-MM-DD (optional) 

            try
            {
                // Gets all reports
                ReportCollection result = apiInstance.ExpenseReportsGet(offset, limit, user, approvalStatusCode, paymentStatusCode, currencyCode, paymentType, reimbursementMethod, approverLoginID, expenseTypeCode, attendeeTypeCode, countryCode, batchID, vendorName, hasVAT, hasImages, hasAttendees, hasBillableExpenses, isTestUser, expenseGroupConfigID, entryTransactionDateBefore, entryTransactionDateAfter, createDateBefore, createDateAfter, userDefinedDateBefore, userDefinedDateAfter, submitDateBefore, submitDateAfter, processingPaymentDateBefore, processingPaymentDateAfter, paidDateBefore, paidDateAfter, modifiedDateBefore, modifiedDateAfter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ExpenseReportsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **string**| Starting page offset | [optional] 
 **limit** | **int?**| Number of records to return (default 25) | [optional] 
 **user** | **string**| Optional. The login ID of the report owner(s) to use when searching for reports. If the value is set to LoginID, reports for the report owner with this login ID value are returned. If the value is set to ALL, reports for all report owners are returned. If this parameter is not specified, reports for the OAuth Consumer are returned. The access token owner (OAuth Consumer) must have the Web Services Admin role to use this parameter. | [optional] 
 **approvalStatusCode** | **string**| The status code for the Approval Status. The values can include Concur Expense standard codes or custom codes. The Concur Expense standard code values are: A_AAFH - Report submission triggered an anomaly and fraud check; A_ACCO - Report is pending reviews; A_APPR - Report has been approved; A_EXTV - Report is pending external validation; A_FILE - Report has been submitted; A_NOTF - Report has not been submitted; A_PBDG - Report approval is pending Budget approval; A_PECO - Report approval is pending Cost object approval; A_PEND - Report is pending manager approval; A_PVAL - Report is pending prepayment validation; A_RESU - Report needs to be resubmitted; A_RHLD - Report submission is pending receipt images; A_TEXP - Report expired in approval queue. For custom codes, contact Concur Developer Support. | [optional] 
 **paymentStatusCode** | **string**| The payment status code for the report. The values can include Concur Expense standard codes or custom codes. The Concur Expense standard code values are: P_HOLD - Report payment is on hold; P_NOTP - Report has not been paid; P_PAID - Report has been paid; P_PAYC - Payment is confirmed. Some or all of the report expenses have been paid; P_PROC - Report is in process to be paid. For custom codes, contact Concur Developer Support. | [optional] 
 **currencyCode** | **string**| The 3-letter ISO 4217 currency code for the report currency. Example: USD. | [optional] 
 **paymentType** | **string**| The unique identifier for the payment type that is the payment type for at least one expense entry in the report. Use PaymentTypeID from the \&quot;GET Expense Group Configurations\&quot; function. | [optional] 
 **reimbursementMethod** | **string**| The method the report owner will be reimbursed. VALUES: ADPPAYR - ADP Payroll; APCHECK - AP (Company Check); CNQRPAY - Expense Pay; PMTSERV - Other Payment Service. NOTE: PAY_PAL is NOT supported. | [optional] 
 **approverLoginID** | **string**| The login ID for the report approver that is the current approver assigned to the report. | [optional] 
 **expenseTypeCode** | **string**| The expense type code that is the expense type for at least one expense entry in the report. Use ExpenseTypeCode from the \&quot;GET Expense Group Configurations\&quot; function. | [optional] 
 **attendeeTypeCode** | **string**| The report contains expense entries that have attendees of the specified type. | [optional] 
 **countryCode** | **string**| The report country. Maximum 2 characters. Format: The ISO 3166-1 alpha-2 country code. Example: United States is US. | [optional] 
 **batchID** | **string**| The unique identifier for a payment batch where there is at least one report payee within the report. Use the BatchID from the \&quot;GET Payment Batch List\&quot; function. | [optional] 
 **vendorName** | **string**| The Vendor Description that is the vendor for at least one expense entry in the report. | [optional] 
 **hasVAT** | **bool?**| Determines if the report has at least one expense entry with VAT details. Format: true or false. | [optional] 
 **hasImages** | **bool?**| Determines if the report has at least one expense entry with an entry image or if there is a report image for this report. Format: true or false. | [optional] 
 **hasAttendees** | **bool?**| Determines if the report has at least one expense entry with an attendee. Format: true or false. | [optional] 
 **hasBillableExpenses** | **bool?**| The IsBillable flag for at least one expense entry in the report. Format: true or false. | [optional] 
 **isTestUser** | **bool?**| The report owner is a test user using the report for testing purposes in a non-production envirnment. format: true or false. | [optional] 
 **expenseGroupConfigID** | **string**| The unique identifier for the expense group configuration associated to the report&#39;s expense group. Use the ID from the \&quot;GET Expense Group Configurations\&quot; function. | [optional] 
 **entryTransactionDateBefore** | **DateTime?**| The entry transaction date for at least one expense entry in the report is before this date.Format: YYYY-MM-DD | [optional] 
 **entryTransactionDateAfter** | **DateTime?**| The entry transaction date for at least one expense entry in the report is after this date.Format: YYYY-MM-DD | [optional] 
 **createDateBefore** | **DateTime?**| The report create date is before this date.Format: YYYY-MM-DD | [optional] 
 **createDateAfter** | **DateTime?**| The report create date is after this date.Format: YYYY-MM-DD | [optional] 
 **userDefinedDateBefore** | **DateTime?**| The report user defined date is before this date.Format: YYYY-MM-DD | [optional] 
 **userDefinedDateAfter** | **DateTime?**| The report user defined date is after this date.Format: YYYY-MM-DD | [optional] 
 **submitDateBefore** | **DateTime?**| The report submit date is before this date.Format: YYYY-MM-DD | [optional] 
 **submitDateAfter** | **DateTime?**| The report submit date is after this date.Format: YYYY-MM-DD | [optional] 
 **processingPaymentDateBefore** | **DateTime?**| The report processing payment date is before this date.Format: YYYY-MM-DD | [optional] 
 **processingPaymentDateAfter** | **DateTime?**| The report processing payment date is after this date. Format: YYYY-MM-DD | [optional] 
 **paidDateBefore** | **DateTime?**| The report paid date is before this date.Format: YYYY-MM-DD | [optional] 
 **paidDateAfter** | **DateTime?**| The report paid date is after this date.Format: YYYY-MM-DD | [optional] 
 **modifiedDateBefore** | **DateTime?**| The report modified date is before this date.Format: YYYY-MM-DD | [optional] 
 **modifiedDateAfter** | **DateTime?**| The report modified date is after this date.Format: YYYY-MM-DD | [optional] 

### Return type

[**ReportCollection**](ReportCollection.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expensereportsidget"></a>
# **ExpenseReportsIdGet**
> ReportGet ExpenseReportsIdGet (string id, string user = null)

Gets a single report

Returns the specified report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpenseReportsIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | Report ID
            var user = user_example;  // string | Optional. The login ID of the report owner(s) to use when searching for reports. If the value is set to LoginID, reports for the report owner with this login ID value are returned. If the value is set to ALL, reports for all report owners are returned. If this parameter is not specified, reports for the OAuth Consumer are returned. The access token owner (OAuth Consumer) must have the Web Services Admin role to use this parameter. (optional) 

            try
            {
                // Gets a single report
                ReportGet result = apiInstance.ExpenseReportsIdGet(id, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ExpenseReportsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Report ID | 
 **user** | **string**| Optional. The login ID of the report owner(s) to use when searching for reports. If the value is set to LoginID, reports for the report owner with this login ID value are returned. If the value is set to ALL, reports for all report owners are returned. If this parameter is not specified, reports for the OAuth Consumer are returned. The access token owner (OAuth Consumer) must have the Web Services Admin role to use this parameter. | [optional] 

### Return type

[**ReportGet**](ReportGet.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expensereportsidput"></a>
# **ExpenseReportsIdPut**
> Object ExpenseReportsIdPut (string id, ReportPut content, string user = null)

Update report

Updates the report specified in the URL. Only the provided fields will be updated, missing fields will not be altered.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpenseReportsIdPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The unique identifier for the report.
            var content = new ReportPut(); // ReportPut | The report object to update
            var user = user_example;  // string | Optional. The login ID for the Report Owner. (optional) 

            try
            {
                // Update report
                Object result = apiInstance.ExpenseReportsIdPut(id, content, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ExpenseReportsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The unique identifier for the report. | 
 **content** | [**ReportPut**](ReportPut.md)| The report object to update | 
 **user** | **string**| Optional. The login ID for the Report Owner. | [optional] 

### Return type

**Object**

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="expensereportspost"></a>
# **ExpenseReportsPost**
> CreateResponse ExpenseReportsPost (ReportPost content, string user = null)

Create a new report

Create an expense report with the supplied data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExpenseReportsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ResourcesApi();
            var content = new ReportPost(); // ReportPost | Report object to create
            var user = user_example;  // string | Optional. The login ID for the Report Owner. (optional) 

            try
            {
                // Create a new report
                CreateResponse result = apiInstance.ExpenseReportsPost(content, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.ExpenseReportsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **content** | [**ReportPost**](ReportPost.md)| Report object to create | 
 **user** | **string**| Optional. The login ID for the Report Owner. | [optional] 

### Return type

[**CreateResponse**](CreateResponse.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

