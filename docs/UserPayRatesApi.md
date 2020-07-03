# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserPayRatesApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserPayRatesCreatePayRate**](UserPayRatesApi.md#userpayratescreatepayrate) | **POST** /UserPayRates/CreatePayRate | Create a new pay rate for a particular user, archiving the previous pay rate.    Requires the &#39;ManageOrganisationUsers&#39; permission.
[**UserPayRatesGetPayRates**](UserPayRatesApi.md#userpayratesgetpayrates) | **GET** /UserPayRates/GetPayRates | Get a collection of pay rates for a particular user, specified by user id.    Requires the &#39;ManageOrganisationUsers&#39; permission.



## UserPayRatesCreatePayRate

> ApiResponseInt32 UserPayRatesCreatePayRate (string xChronosheetsAuth, InsertUserHourlyRateRequest request)

Create a new pay rate for a particular user, archiving the previous pay rate.    Requires the 'ManageOrganisationUsers' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserPayRatesCreatePayRateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UserPayRatesApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new InsertUserHourlyRateRequest(); // InsertUserHourlyRateRequest | An Insert UserHourlyRate Request object containing values for the new UserHourlyRate to create

            try
            {
                // Create a new pay rate for a particular user, archiving the previous pay rate.    Requires the 'ManageOrganisationUsers' permission.
                ApiResponseInt32 result = apiInstance.UserPayRatesCreatePayRate(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserPayRatesApi.UserPayRatesCreatePayRate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **request** | [**InsertUserHourlyRateRequest**](InsertUserHourlyRateRequest.md)| An Insert UserHourlyRate Request object containing values for the new UserHourlyRate to create | 

### Return type

[**ApiResponseInt32**](ApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
- **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UserPayRatesGetPayRates

> ApiResponseListUserHourlyRate UserPayRatesGetPayRates (int userId, string xChronosheetsAuth)

Get a collection of pay rates for a particular user, specified by user id.    Requires the 'ManageOrganisationUsers' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserPayRatesGetPayRatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UserPayRatesApi(Configuration.Default);
            var userId = 56;  // int | The ID of the User for which you want to get UserHourlyRate objects
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of pay rates for a particular user, specified by user id.    Requires the 'ManageOrganisationUsers' permission.
                ApiResponseListUserHourlyRate result = apiInstance.UserPayRatesGetPayRates(userId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserPayRatesApi.UserPayRatesGetPayRates: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int**| The ID of the User for which you want to get UserHourlyRate objects | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseListUserHourlyRate**](ApiResponseListUserHourlyRate.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

