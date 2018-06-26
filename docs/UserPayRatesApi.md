# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserPayRatesApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserPayRatesCreatePayRate**](UserPayRatesApi.md#userpayratescreatepayrate) | **PUT** /api/UserPayRates/CreatePayRate | Create a new pay rate for a particular user, archiving the previous pay rate
[**UserPayRatesGetPayRates**](UserPayRatesApi.md#userpayratesgetpayrates) | **GET** /api/UserPayRates/GetPayRates | Get a collection of pay rates for a particular user, specified by user id


<a name="userpayratescreatepayrate"></a>
# **UserPayRatesCreatePayRate**
> CSApiResponseInt32 UserPayRatesCreatePayRate (CSInsertUserHourlyRateRequest request, string xChronosheetsAuth)

Create a new pay rate for a particular user, archiving the previous pay rate

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserPayRatesCreatePayRateExample
    {
        public void main()
        {
            var apiInstance = new UserPayRatesApi();
            var request = new CSInsertUserHourlyRateRequest(); // CSInsertUserHourlyRateRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a new pay rate for a particular user, archiving the previous pay rate
                CSApiResponseInt32 result = apiInstance.UserPayRatesCreatePayRate(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserPayRatesApi.UserPayRatesCreatePayRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSInsertUserHourlyRateRequest**](CSInsertUserHourlyRateRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userpayratesgetpayrates"></a>
# **UserPayRatesGetPayRates**
> CSApiResponseListUserHourlyRate UserPayRatesGetPayRates (int? userId, string xChronosheetsAuth)

Get a collection of pay rates for a particular user, specified by user id

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserPayRatesGetPayRatesExample
    {
        public void main()
        {
            var apiInstance = new UserPayRatesApi();
            var userId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of pay rates for a particular user, specified by user id
                CSApiResponseListUserHourlyRate result = apiInstance.UserPayRatesGetPayRates(userId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserPayRatesApi.UserPayRatesGetPayRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListUserHourlyRate**](CSApiResponseListUserHourlyRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

