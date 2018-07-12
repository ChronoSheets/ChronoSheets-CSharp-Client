# ChronoSheetsAPI.ChronoSheetsClientLibApi.TimesheetsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimesheetsCreateSingleTimesheet**](TimesheetsApi.md#timesheetscreatesingletimesheet) | **POST** /api/Timesheets/CreateSingleTimesheet | Inserts a single timesheet record.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsDeleteTimesheet**](TimesheetsApi.md#timesheetsdeletetimesheet) | **DELETE** /api/Timesheets/DeleteTimesheet | Delete a timesheet.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsGetTimesheets**](TimesheetsApi.md#timesheetsgettimesheets) | **GET** /api/Timesheets/GetTimesheets | Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsUpdateTimesheets**](TimesheetsApi.md#timesheetsupdatetimesheets) | **PUT** /api/Timesheets/UpdateTimesheets | Batch update timesheets.    Requires the &#39;SubmitTimesheets&#39; permission.


<a name="timesheetscreatesingletimesheet"></a>
# **TimesheetsCreateSingleTimesheet**
> CSApiResponseInt32 TimesheetsCreateSingleTimesheet (CSTimesheet request, string xChronosheetsAuth)

Inserts a single timesheet record.    Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsCreateSingleTimesheetExample
    {
        public void main()
        {
            var apiInstance = new TimesheetsApi();
            var request = new CSTimesheet(); // CSTimesheet | A Timesheet Request object containing values for the new Timesheet to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Inserts a single timesheet record.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseInt32 result = apiInstance.TimesheetsCreateSingleTimesheet(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsCreateSingleTimesheet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSTimesheet**](CSTimesheet.md)| A Timesheet Request object containing values for the new Timesheet to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsdeletetimesheet"></a>
# **TimesheetsDeleteTimesheet**
> CSApiResponseBoolean TimesheetsDeleteTimesheet (int? timesheetId, string xChronosheetsAuth)

Delete a timesheet.    Requires the 'SubmitTimesheets' permission.

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
            var timesheetId = 56;  // int? | The ID of the Timesheet you want to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a timesheet.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseBoolean result = apiInstance.TimesheetsDeleteTimesheet(timesheetId, xChronosheetsAuth);
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
 **timesheetId** | **int?**| The ID of the Timesheet you want to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsgettimesheets"></a>
# **TimesheetsGetTimesheets**
> CSApiResponseListTimesheet TimesheetsGetTimesheets (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the 'SubmitTimesheets' permission.

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
                // Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseListTimesheet result = apiInstance.TimesheetsGetTimesheets(startDate, endDate, xChronosheetsAuth);
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

[**CSApiResponseListTimesheet**](CSApiResponseListTimesheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetsupdatetimesheets"></a>
# **TimesheetsUpdateTimesheets**
> CSApiResponseListInt32 TimesheetsUpdateTimesheets (CSBatchUpdateTimesheetRequest request, string xChronosheetsAuth)

Batch update timesheets.    Requires the 'SubmitTimesheets' permission.

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
            var request = new CSBatchUpdateTimesheetRequest(); // CSBatchUpdateTimesheetRequest | A BatchUpdateTimesheet Request object containing values for the new Timesheets to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Batch update timesheets.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseListInt32 result = apiInstance.TimesheetsUpdateTimesheets(request, xChronosheetsAuth);
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
 **request** | [**CSBatchUpdateTimesheetRequest**](CSBatchUpdateTimesheetRequest.md)| A BatchUpdateTimesheet Request object containing values for the new Timesheets to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListInt32**](CSApiResponseListInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

