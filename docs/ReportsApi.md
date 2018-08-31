# ChronoSheetsAPI.ChronoSheetsClientLibApi.ReportsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsGetAllChartsDataAdmin**](ReportsApi.md#reportsgetallchartsdataadmin) | **GET** /api/Reports/GetAllChartsDataAdmin | Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetAllChartsDataUser**](ReportsApi.md#reportsgetallchartsdatauser) | **GET** /api/Reports/GetAllChartsDataUser | Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user&#39;s own reports.    Requires the &#39;ViewOwnReports&#39; permission.
[**ReportsGetFleetSummaryAdmin**](ReportsApi.md#reportsgetfleetsummaryadmin) | **GET** /api/Reports/GetFleetSummaryAdmin | Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrgTripById**](ReportsApi.md#reportsgetorgtripbyid) | **GET** /api/Reports/GetOrgTripById | Get trip by Id, for reporting purposes.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTimesheetFileAttachments**](ReportsApi.md#reportsgetorganisationtimesheetfileattachments) | **GET** /api/Reports/GetOrganisationTimesheetFileAttachments | Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTranscripts**](ReportsApi.md#reportsgetorganisationtranscripts) | **GET** /api/Reports/GetOrganisationTranscripts | Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetOrganisationTrips**](ReportsApi.md#reportsgetorganisationtrips) | **GET** /api/Reports/GetOrganisationTrips | Reports on Organisation trips (GPS tracking from whole organisation).    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsGetRawDataAdmin**](ReportsApi.md#reportsgetrawdataadmin) | **GET** /api/Reports/GetRawDataAdmin | Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsProjectCostingsAdmin**](ReportsApi.md#reportsprojectcostingsadmin) | **GET** /api/Reports/ProjectCostingsAdmin | Gets project cost estimations VS actual cost for date range and users.    Requires the &#39;ReportAdmin&#39; permission.
[**ReportsUserJobsOverTime**](ReportsApi.md#reportsuserjobsovertime) | **GET** /api/Reports/UserJobsOverTime | Timeseries jobs data for the logged in user.    Requires the &#39;ViewOwnReports&#39; or &#39;SubmitTimesheets&#39;.


<a name="reportsgetallchartsdataadmin"></a>
# **ReportsGetAllChartsDataAdmin**
> CSApiResponseCombinedReportsData ReportsGetAllChartsDataAdmin (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, string userIds = null)

Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetAllChartsDataAdminExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects).  These are the organisation wide reports, with data from potentially all employees.    Requires the 'ReportAdmin' permission.
                CSApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataAdmin(startDate, endDate, xChronosheetsAuth, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetAllChartsDataAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**CSApiResponseCombinedReportsData**](CSApiResponseCombinedReportsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetallchartsdatauser"></a>
# **ReportsGetAllChartsDataUser**
> CSApiResponseCombinedReportsData ReportsGetAllChartsDataUser (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user's own reports.    Requires the 'ViewOwnReports' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetAllChartsDataUserExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get Consolidated User Reports Data (Jobs, Tasks, Clients and Projects).  These are the user's own reports.    Requires the 'ViewOwnReports' permission.
                CSApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataUser(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetAllChartsDataUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseCombinedReportsData**](CSApiResponseCombinedReportsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetfleetsummaryadmin"></a>
# **ReportsGetFleetSummaryAdmin**
> CSApiResponseListFleetSummaryReportItem ReportsGetFleetSummaryAdmin (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, string userIds = null)

Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetFleetSummaryAdminExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Gets a summary report, which includes total distance travelled and total running costs, for vehicles within your organisation  Requires the 'ReportAdmin' permission.
                CSApiResponseListFleetSummaryReportItem result = apiInstance.ReportsGetFleetSummaryAdmin(startDate, endDate, xChronosheetsAuth, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetFleetSummaryAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**CSApiResponseListFleetSummaryReportItem**](CSApiResponseListFleetSummaryReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorgtripbyid"></a>
# **ReportsGetOrgTripById**
> CSApiResponseTrip ReportsGetOrgTripById (int? tripId, string xChronosheetsAuth)

Get trip by Id, for reporting purposes.    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrgTripByIdExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var tripId = 56;  // int? | The ID of the Trip you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get trip by Id, for reporting purposes.    Requires the 'ReportAdmin' permission.
                CSApiResponseTrip result = apiInstance.ReportsGetOrgTripById(tripId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrgTripById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tripId** | **int?**| The ID of the Trip you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseTrip**](CSApiResponseTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorganisationtimesheetfileattachments"></a>
# **ReportsGetOrganisationTimesheetFileAttachments**
> CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment ReportsGetOrganisationTimesheetFileAttachments (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null)

Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTimesheetFileAttachmentsExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Reports on Organisation timesheet file attachments (files uploaded and attached to timesheet records)  Requires the 'ReportAdmin' permission.
                CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment result = apiInstance.ReportsGetOrganisationTimesheetFileAttachments(startDate, endDate, xChronosheetsAuth, skip, take, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTimesheetFileAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment**](CSApiResponseForPaginatedListOrgReportTimesheetFileAttachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorganisationtranscripts"></a>
# **ReportsGetOrganisationTranscripts**
> CSApiResponseForPaginatedListOrgReportTranscript ReportsGetOrganisationTranscripts (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null, string keywords = null)

Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTranscriptsExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 
            var keywords = keywords_example;  // string | Search the transcripts by keyword(s) (optional) 

            try
            {
                // Reports on Organisation transcripts (When an audio file is attached, it will be automatically transcribed, these are the transcriptions)    Requires the 'ReportAdmin' permission.
                CSApiResponseForPaginatedListOrgReportTranscript result = apiInstance.ReportsGetOrganisationTranscripts(startDate, endDate, xChronosheetsAuth, skip, take, userIds, keywords);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTranscripts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 
 **keywords** | **string**| Search the transcripts by keyword(s) | [optional] 

### Return type

[**CSApiResponseForPaginatedListOrgReportTranscript**](CSApiResponseForPaginatedListOrgReportTranscript.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorganisationtrips"></a>
# **ReportsGetOrganisationTrips**
> CSApiResponseForPaginatedListOrgReportTrip ReportsGetOrganisationTrips (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string userIds = null)

Reports on Organisation trips (GPS tracking from whole organisation).    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetOrganisationTripsExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many items (optional) 
            var take = 56;  // int? | Take this many items (optional) 
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Reports on Organisation trips (GPS tracking from whole organisation).    Requires the 'ReportAdmin' permission.
                CSApiResponseForPaginatedListOrgReportTrip result = apiInstance.ReportsGetOrganisationTrips(startDate, endDate, xChronosheetsAuth, skip, take, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetOrganisationTrips: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many items | [optional] 
 **take** | **int?**| Take this many items | [optional] 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**CSApiResponseForPaginatedListOrgReportTrip**](CSApiResponseForPaginatedListOrgReportTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetrawdataadmin"></a>
# **ReportsGetRawDataAdmin**
> CSApiResponseForPaginatedListRawReportItem ReportsGetRawDataAdmin (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, string userIds = null, string sort = null, string order = null, int? skip = null, int? take = null)

Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsGetRawDataAdminExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 
            var sort = sort_example;  // string | Decide which column to sort on (optional) 
            var order = order_example;  // string | Decide which direction to sort the column (optional) 
            var skip = 56;  // int? | Skip this many rows (optional) 
            var take = 56;  // int? | Take this many rows (optional) 

            try
            {
                // Get Timesheets Raw Data.  This data details each timesheet record.  These are the organisation wide timesheet records, with data from potentially all employees.    Requires the 'ReportAdmin' permission.
                CSApiResponseForPaginatedListRawReportItem result = apiInstance.ReportsGetRawDataAdmin(startDate, endDate, xChronosheetsAuth, userIds, sort, order, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsGetRawDataAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 
 **sort** | **string**| Decide which column to sort on | [optional] 
 **order** | **string**| Decide which direction to sort the column | [optional] 
 **skip** | **int?**| Skip this many rows | [optional] 
 **take** | **int?**| Take this many rows | [optional] 

### Return type

[**CSApiResponseForPaginatedListRawReportItem**](CSApiResponseForPaginatedListRawReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsprojectcostingsadmin"></a>
# **ReportsProjectCostingsAdmin**
> CSApiResponseListProjectCostingReportItem ReportsProjectCostingsAdmin (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, string userIds = null)

Gets project cost estimations VS actual cost for date range and users.    Requires the 'ReportAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsProjectCostingsAdminExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var userIds = userIds_example;  // string | A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. (optional) 

            try
            {
                // Gets project cost estimations VS actual cost for date range and users.    Requires the 'ReportAdmin' permission.
                CSApiResponseListProjectCostingReportItem result = apiInstance.ReportsProjectCostingsAdmin(startDate, endDate, xChronosheetsAuth, userIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsProjectCostingsAdmin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **userIds** | **string**| A comma-separated list of user Ids, if you want to filter the report data to particular users.  If you want all, send a blank string. | [optional] 

### Return type

[**CSApiResponseListProjectCostingReportItem**](CSApiResponseListProjectCostingReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsuserjobsovertime"></a>
# **ReportsUserJobsOverTime**
> CSApiResponseListJobSeriesReportItem ReportsUserJobsOverTime (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Timeseries jobs data for the logged in user.    Requires the 'ViewOwnReports' or 'SubmitTimesheets'.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ReportsUserJobsOverTimeExample
    {
        public void main()
        {
            var apiInstance = new ReportsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date for the date range.  Report data in the response is after this date
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date for the date range.  Report data in the response is before this date
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Timeseries jobs data for the logged in user.    Requires the 'ViewOwnReports' or 'SubmitTimesheets'.
                CSApiResponseListJobSeriesReportItem result = apiInstance.ReportsUserJobsOverTime(startDate, endDate, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportsUserJobsOverTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The start date for the date range.  Report data in the response is after this date | 
 **endDate** | **DateTime?**| The end date for the date range.  Report data in the response is before this date | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListJobSeriesReportItem**](CSApiResponseListJobSeriesReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

