# ChronoSheetsAPI.ChronoSheetsClientLibApi.TimesheetsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimesheetsDeleteTimesheet**](TimesheetsApi.md#timesheetsdeletetimesheet) | **DELETE** /api/Timesheets/DeleteTimesheet | Delete a timesheet
[**TimesheetsGetTimesheets**](TimesheetsApi.md#timesheetsgettimesheets) | **GET** /api/Timesheets/GetTimesheets | Get timesheets between start and end dates
[**TimesheetsInsertSingleTimesheet**](TimesheetsApi.md#timesheetsinsertsingletimesheet) | **POST** /api/Timesheets/InsertSingleTimesheet | Inserts a single timesheet record
[**TimesheetsUpdateTimesheets**](TimesheetsApi.md#timesheetsupdatetimesheets) | **POST** /api/Timesheets/UpdateTimesheets | Batch update timesheets


<a name="timesheetsdeletetimesheet"></a>
# **TimesheetsDeleteTimesheet**
> CsApiApiResponseBoolean TimesheetsDeleteTimesheet (int? timesheetId, string xChronosheetsAuth)

Delete a timesheet

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsDeleteTimesheetExample
    {
        public void main()
        {
            var apiInstance = new TimesheetsApi();
            var timesheetId = 56;  // int? | The ID of the timesheet to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a timesheet
                CsApiApiResponseBoolean result = apiInstance.TimesheetsDeleteTimesheet(timesheetId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsDeleteTimesheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **timesheetId** | **int?**| The ID of the timesheet to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsgettimesheets"></a>
# **TimesheetsGetTimesheets**
> CsApiApiResponseListTimesheet TimesheetsGetTimesheets (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Get timesheets between start and end dates

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsGetTimesheetsExample
    {
        public void main()
        {
            var apiInstance = new TimesheetsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the date range
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the date range
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get timesheets between start and end dates
                CsApiApiResponseListTimesheet result = apiInstance.TimesheetsGetTimesheets(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsGetTimesheets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date of the date range | 
 **endDate** | **DateTime?**| The end date of the date range | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListTimesheet**](CsApiApiResponseListTimesheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsinsertsingletimesheet"></a>
# **TimesheetsInsertSingleTimesheet**
> CsApiApiResponseInt32 TimesheetsInsertSingleTimesheet (CsApiTimesheet request, string xChronosheetsAuth)

Inserts a single timesheet record

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsInsertSingleTimesheetExample
    {
        public void main()
        {
            var apiInstance = new TimesheetsApi();
            var request = new CsApiTimesheet(); // CsApiTimesheet | The timesheet request object
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Inserts a single timesheet record
                CsApiApiResponseInt32 result = apiInstance.TimesheetsInsertSingleTimesheet(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsInsertSingleTimesheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiTimesheet**](CsApiTimesheet.md)| The timesheet request object | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsupdatetimesheets"></a>
# **TimesheetsUpdateTimesheets**
> CsApiApiResponseListInt32 TimesheetsUpdateTimesheets (CsApiBatchUpdateTimesheetRequest request, string xChronosheetsAuth)

Batch update timesheets

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsUpdateTimesheetsExample
    {
        public void main()
        {
            var apiInstance = new TimesheetsApi();
            var request = new CsApiBatchUpdateTimesheetRequest(); // CsApiBatchUpdateTimesheetRequest | The batch update timesheets request
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Batch update timesheets
                CsApiApiResponseListInt32 result = apiInstance.TimesheetsUpdateTimesheets(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsUpdateTimesheets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiBatchUpdateTimesheetRequest**](CsApiBatchUpdateTimesheetRequest.md)| The batch update timesheets request | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListInt32**](CsApiApiResponseListInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

