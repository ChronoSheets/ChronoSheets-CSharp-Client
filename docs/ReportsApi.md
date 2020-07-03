# ChronoSheetsAPI.ChronoSheetsClientLibApi.ReportsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsGetAllChartsDataAdmin**](ReportsApi.md#reportsgetallchartsdataadmin) | **GET** /Reports/GetAllChartsDataAdmin | Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetAllChartsDataUser**](ReportsApi.md#reportsgetallchartsdatauser) | **GET** /Reports/GetAllChartsDataUser | Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user&#39;s own reports.    Requires the &#39;ViewOwnReports&#39; permission.
[**ReportsGetFleetSummaryAdmin**](ReportsApi.md#reportsgetfleetsummaryadmin) | **GET** /Reports/GetFleetSummaryAdmin | Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrgTripById**](ReportsApi.md#reportsgetorgtripbyid) | **GET** /Reports/GetOrgTripById | Get trip by Id, for reporting purposes.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTimesheetFileAttachments**](ReportsApi.md#reportsgetorganisationtimesheetfileattachments) | **GET** /Reports/GetOrganisationTimesheetFileAttachments | Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTranscripts**](ReportsApi.md#reportsgetorganisationtranscripts) | **GET** /Reports/GetOrganisationTranscripts | Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTrips**](ReportsApi.md#reportsgetorganisationtrips) | **GET** /Reports/GetOrganisationTrips | Reports on Organisation trips (GPS tracking from whole organisation).    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetRawDataAdmin**](ReportsApi.md#reportsgetrawdataadmin) | **GET** /Reports/GetRawDataAdmin | Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsProjectCostingsAdmin**](ReportsApi.md#reportsprojectcostingsadmin) | **GET** /Reports/ProjectCostingsAdmin | Gets project cost estimations VS actual cost for date range and users.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsUserJobsOverTime**](ReportsApi.md#reportsuserjobsovertime) | **GET** /Reports/UserJobsOverTime | Timeseries jobs data for the logged in user.    Requires the &#39;ViewOwnReports&#39; or &#39;SubmitTimesheets&#39;.



## ReportsGetAllChartsDataAdmin

> ApiResponseCombinedReportsData ReportsGetAllChartsDataAdmin (DateTime startDate, DateTime endDate, string xChronosheetsAuth, string userIds = null, string forceOnlyThisChart = null)

Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetAllChartsDataAdminExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 
            var forceOnlyThisChart = forceOnlyThisChart_example;  // string | A flag to indicate which report data you require.  Choose a particular set of data, or if you want all data use the 'NotForced' option. (optional) 

            try
            {
                // Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the 'ReportAdmin' permission.
                ApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataAdmin(startDate, endDate, xChronosheetsAuth, userIds, forceOnlyThisChart);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetAllChartsDataAdmin: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 
 **forceOnlyThisChart** | **string**| A flag to indicate which report data you require.  Choose a particular set of data, or if you want all data use the &#39;NotForced&#39; option. | [optional] 

### Return type

[**ApiResponseCombinedReportsData**](ApiResponseCombinedReportsData.md)

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


## ReportsGetAllChartsDataUser

> ApiResponseCombinedReportsData ReportsGetAllChartsDataUser (DateTime startDate, DateTime endDate, string xChronosheetsAuth)

Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user's own reports.    Requires the 'ViewOwnReports' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetAllChartsDataUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user's own reports.    Requires the 'ViewOwnReports' permission.
                ApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataUser(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetAllChartsDataUser: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseCombinedReportsData**](ApiResponseCombinedReportsData.md)

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


## ReportsGetFleetSummaryAdmin

> ApiResponseListFleetSummaryReportItem ReportsGetFleetSummaryAdmin (DateTime startDate, DateTime endDate, string xChronosheetsAuth, string userIds = null)

Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetFleetSummaryAdminExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the 'ReportAdmin' permission.
                ApiResponseListFleetSummaryReportItem result = apiInstance.ReportsGetFleetSummaryAdmin(startDate, endDate, xChronosheetsAuth, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetFleetSummaryAdmin: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**ApiResponseListFleetSummaryReportItem**](ApiResponseListFleetSummaryReportItem.md)

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


## ReportsGetOrgTripById

> ApiResponseTrip ReportsGetOrgTripById (int tripId, string xChronosheetsAuth)

Get trip by Id, for reporting purposes.    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrgTripByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var tripId = 56;  // int | The ID of the Trip you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get trip by Id, for reporting purposes.    Requires the 'ReportAdmin' permission.
                ApiResponseTrip result = apiInstance.ReportsGetOrgTripById(tripId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrgTripById: " + e.Message );
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
 **tripId** | **int**| The ID of the Trip you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseTrip**](ApiResponseTrip.md)

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


## ReportsGetOrganisationTimesheetFileAttachments

> ApiResponseForPaginatedListOrgReportTimesheetFileAttachment ReportsGetOrganisationTimesheetFileAttachments (DateTime startDate, DateTime endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null)

Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTimesheetFileAttachmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the 'ReportAdmin' permission.
                ApiResponseForPaginatedListOrgReportTimesheetFileAttachment result = apiInstance.ReportsGetOrganisationTimesheetFileAttachments(startDate, endDate, xChronosheetsAuth, skip, take, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTimesheetFileAttachments: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**ApiResponseForPaginatedListOrgReportTimesheetFileAttachment**](ApiResponseForPaginatedListOrgReportTimesheetFileAttachment.md)

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


## ReportsGetOrganisationTranscripts

> ApiResponseForPaginatedListOrgReportTranscript ReportsGetOrganisationTranscripts (DateTime startDate, DateTime endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null, string keywords = null)

Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTranscriptsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 
            var keywords = keywords_example;  // string | Search the transcripts by keyword(s) (optional) 

            try
            {
                // Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the 'ReportAdmin' permission.
                ApiResponseForPaginatedListOrgReportTranscript result = apiInstance.ReportsGetOrganisationTranscripts(startDate, endDate, xChronosheetsAuth, skip, take, userIds, keywords);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTranscripts: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 
 **keywords** | **string**| Search the transcripts by keyword(s) | [optional] 

### Return type

[**ApiResponseForPaginatedListOrgReportTranscript**](ApiResponseForPaginatedListOrgReportTranscript.md)

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


## ReportsGetOrganisationTrips

> ApiResponseForPaginatedListOrgReportTrip ReportsGetOrganisationTrips (DateTime startDate, DateTime endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null)

Reports on Organisation trips (GPS tracking from whole organisation).    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTripsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Reports on Organisation trips (GPS tracking from whole organisation).    Requires the 'ReportAdmin' permission.
                ApiResponseForPaginatedListOrgReportTrip result = apiInstance.ReportsGetOrganisationTrips(startDate, endDate, xChronosheetsAuth, skip, take, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTrips: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**ApiResponseForPaginatedListOrgReportTrip**](ApiResponseForPaginatedListOrgReportTrip.md)

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


## ReportsGetRawDataAdmin

> ApiResponseForPaginatedListRawReportItem ReportsGetRawDataAdmin (DateTime startDate, DateTime endDate, string xChronosheetsAuth, string userIds = null, string sort = null, string order = null, int? skip = null, int? take = null)

Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetRawDataAdminExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 
            var sort = sort_example;  // string | Decide which column to sort on (optional) 
            var order = order_example;  // string | Decide which direction to sort the column (optional) 
            var skip = 56;  // int? | Skip this many rows (optional) 
            var take = 56;  // int? | Take this many rows (optional) 

            try
            {
                // Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the 'ReportAdmin' permission.
                ApiResponseForPaginatedListRawReportItem result = apiInstance.ReportsGetRawDataAdmin(startDate, endDate, xChronosheetsAuth, userIds, sort, order, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetRawDataAdmin: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 
 **sort** | **string**| Decide which column to sort on | [optional] 
 **order** | **string**| Decide which direction to sort the column | [optional] 
 **skip** | **int?**| Skip this many rows | [optional] 
 **take** | **int?**| Take this many rows | [optional] 

### Return type

[**ApiResponseForPaginatedListRawReportItem**](ApiResponseForPaginatedListRawReportItem.md)

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


## ReportsProjectCostingsAdmin

> ApiResponseListProjectCostingReportItem ReportsProjectCostingsAdmin (DateTime startDate, DateTime endDate, string xChronosheetsAuth, string userIds = null)

Gets project cost estimations VS actual cost for date range and users.    Requires the 'ReportAdmin' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsProjectCostingsAdminExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Gets project cost estimations VS actual cost for date range and users.    Requires the 'ReportAdmin' permission.
                ApiResponseListProjectCostingReportItem result = apiInstance.ReportsProjectCostingsAdmin(startDate, endDate, xChronosheetsAuth, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsProjectCostingsAdmin: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**ApiResponseListProjectCostingReportItem**](ApiResponseListProjectCostingReportItem.md)

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


## ReportsUserJobsOverTime

> ApiResponseListJobSeriesReportItem ReportsUserJobsOverTime (DateTime startDate, DateTime endDate, string xChronosheetsAuth)

Timeseries jobs data for the logged in user.    Requires the 'ViewOwnReports' or 'SubmitTimesheets'.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsUserJobsOverTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new ReportsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Timeseries jobs data for the logged in user.    Requires the 'ViewOwnReports' or 'SubmitTimesheets'.
                ApiResponseListJobSeriesReportItem result = apiInstance.ReportsUserJobsOverTime(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsUserJobsOverTime: " + e.Message );
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
 **startDate** | **DateTime**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseListJobSeriesReportItem**](ApiResponseListJobSeriesReportItem.md)

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

