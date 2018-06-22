# ChronoSheetsAPI.ChronoSheetsClientLibApi.UsualHoursApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsualHoursGetUsualHours**](UsualHoursApi.md#usualhoursgetusualhours) | **GET** /api/UsualHours/GetUsualHours | Get usual hours (rostered hours) for an employee
[**UsualHoursSetUsualHours**](UsualHoursApi.md#usualhourssetusualhours) | **POST** /api/UsualHours/SetUsualHours | Set usual hours (rostered hours) for an employee


<a name="usualhoursgetusualhours"></a>
# **UsualHoursGetUsualHours**
> CsApiApiResponseListUsualHoursDay UsualHoursGetUsualHours (int? userId, string xChronosheetsAuth)

Get usual hours (rostered hours) for an employee

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsualHoursGetUsualHoursExample
    {
        public void main()
        {
            var apiInstance = new UsualHoursApi();
            var userId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get usual hours (rostered hours) for an employee
                CsApiApiResponseListUsualHoursDay result = apiInstance.UsualHoursGetUsualHours(userId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsualHoursApi.UsualHoursGetUsualHours: " + e.Message );
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

[**CsApiApiResponseListUsualHoursDay**](CsApiApiResponseListUsualHoursDay.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usualhourssetusualhours"></a>
# **UsualHoursSetUsualHours**
> CsApiApiResponseBoolean UsualHoursSetUsualHours (CsApiSetUsualHoursRequest request, string xChronosheetsAuth)

Set usual hours (rostered hours) for an employee

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsualHoursSetUsualHoursExample
    {
        public void main()
        {
            var apiInstance = new UsualHoursApi();
            var request = new CsApiSetUsualHoursRequest(); // CsApiSetUsualHoursRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Set usual hours (rostered hours) for an employee
                CsApiApiResponseBoolean result = apiInstance.UsualHoursSetUsualHours(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsualHoursApi.UsualHoursSetUsualHours: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiSetUsualHoursRequest**](CsApiSetUsualHoursRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

