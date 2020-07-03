# ChronoSheetsAPI.ChronoSheetsClientLibApi.TimesheetsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimesheetsCreateSingleTimesheet**](TimesheetsApi.md#timesheetscreatesingletimesheet) | **POST** /Timesheets/CreateSingleTimesheet | Inserts a single timesheet record.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsDeleteTimesheet**](TimesheetsApi.md#timesheetsdeletetimesheet) | **DELETE** /Timesheets/DeleteTimesheet | Delete a timesheet.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsGetTimesheets**](TimesheetsApi.md#timesheetsgettimesheets) | **GET** /Timesheets/GetTimesheets | Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetsUpdateTimesheets**](TimesheetsApi.md#timesheetsupdatetimesheets) | **PUT** /Timesheets/UpdateTimesheets | Batch update timesheets.    Requires the &#39;SubmitTimesheets&#39; permission.



## TimesheetsCreateSingleTimesheet

> ApiResponseInt32 TimesheetsCreateSingleTimesheet (string xChronosheetsAuth, Timesheet request)

Inserts a single timesheet record.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsCreateSingleTimesheetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new TimesheetsApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new Timesheet(); // Timesheet | A Timesheet Request object containing values for the new Timesheet to create

            try
            {
                // Inserts a single timesheet record.    Requires the 'SubmitTimesheets' permission.
                ApiResponseInt32 result = apiInstance.TimesheetsCreateSingleTimesheet(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsCreateSingleTimesheet: " + e.Message );
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
 **request** | [**Timesheet**](Timesheet.md)| A Timesheet Request object containing values for the new Timesheet to create | 

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


## TimesheetsDeleteTimesheet

> ApiResponseBoolean TimesheetsDeleteTimesheet (int timesheetId, string xChronosheetsAuth)

Delete a timesheet.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsDeleteTimesheetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new TimesheetsApi(Configuration.Default);
            var timesheetId = 56;  // int | The ID of the Timesheet you want to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a timesheet.    Requires the 'SubmitTimesheets' permission.
                ApiResponseBoolean result = apiInstance.TimesheetsDeleteTimesheet(timesheetId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsDeleteTimesheet: " + e.Message );
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
 **timesheetId** | **int**| The ID of the Timesheet you want to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseBoolean**](ApiResponseBoolean.md)

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


## TimesheetsGetTimesheets

> ApiResponseListTimesheet TimesheetsGetTimesheets (DateTime startDate, DateTime endDate, string xChronosheetsAuth)

Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsGetTimesheetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new TimesheetsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date of the date range
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date of the date range
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get timesheets between start and end dates.  Note: the date range cannot exceed 24 hours.  This method is generally used to get timesheets for a particular day.    Requires the 'SubmitTimesheets' permission.
                ApiResponseListTimesheet result = apiInstance.TimesheetsGetTimesheets(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsGetTimesheets: " + e.Message );
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
 **startDate** | **DateTime**| The start date of the date range | 
 **endDate** | **DateTime**| The end date of the date range | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseListTimesheet**](ApiResponseListTimesheet.md)

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


## TimesheetsUpdateTimesheets

> ApiResponseListInt32 TimesheetsUpdateTimesheets (string xChronosheetsAuth, BatchUpdateTimesheetRequest request)

Batch update timesheets.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetsUpdateTimesheetsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new TimesheetsApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new BatchUpdateTimesheetRequest(); // BatchUpdateTimesheetRequest | A BatchUpdateTimesheet Request object containing values for the new Timesheets to create or update.  If the timesheet Id is specified, then an update will be performed, else the timesheet record will be created.

            try
            {
                // Batch update timesheets.    Requires the 'SubmitTimesheets' permission.
                ApiResponseListInt32 result = apiInstance.TimesheetsUpdateTimesheets(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TimesheetsApi.TimesheetsUpdateTimesheets: " + e.Message );
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
 **request** | [**BatchUpdateTimesheetRequest**](BatchUpdateTimesheetRequest.md)| A BatchUpdateTimesheet Request object containing values for the new Timesheets to create or update.  If the timesheet Id is specified, then an update will be performed, else the timesheet record will be created. | 

### Return type

[**ApiResponseListInt32**](ApiResponseListInt32.md)

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

