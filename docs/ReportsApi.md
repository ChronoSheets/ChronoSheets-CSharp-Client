# ChronoSheetsAPI.ChronoSheetsClientLibApi.ReportsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReportsGetAllChartsDataAdmin**](ReportsApi.md#reportsgetallchartsdataadmin) | **GET** /api/Reports/GetAllChartsDataAdmin | Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects)
[**ReportsGetAllChartsDataUser**](ReportsApi.md#reportsgetallchartsdatauser) | **GET** /api/Reports/GetAllChartsDataUser | Get Consolidated User Reports Data (Jobs and Tasks)
[**ReportsGetOrgTripById**](ReportsApi.md#reportsgetorgtripbyid) | **GET** /api/Reports/GetOrgTripById | Get trip by Id, for reporting purposes
[**ReportsGetOrganisationTimesheetFileAttachments**](ReportsApi.md#reportsgetorganisationtimesheetfileattachments) | **GET** /api/Reports/GetOrganisationTimesheetFileAttachments | Reports on Organisation timesheet file attachments
[**ReportsGetOrganisationTrips**](ReportsApi.md#reportsgetorganisationtrips) | **GET** /api/Reports/GetOrganisationTrips | Reports on Organisation trips (GPS tracking from whole organisation)
[**ReportsGetRawDataAdmin**](ReportsApi.md#reportsgetrawdataadmin) | **GET** /api/Reports/GetRawDataAdmin | Get Timesheets Raw Data
[**ReportsProjectCostingsAdmin**](ReportsApi.md#reportsprojectcostingsadmin) | **GET** /api/Reports/ProjectCostingsAdmin | Gets project cost estimations VS actual cost for date range and users
[**ReportsUserJobsOverTime**](ReportsApi.md#reportsuserjobsovertime) | **GET** /api/Reports/UserJobsOverTime | Timeseries jobs data for the logged in user


<a name="reportsgetallchartsdataadmin"></a>
# **ReportsGetAllChartsDataAdmin**
> CsApiApiResponseCombinedReportsData ReportsGetAllChartsDataAdmin (DateTime? startDate, DateTime? endDate, string userIds, string xChronosheetsAuth)

Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects)

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var userIds = userIds_example;  // string | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get Consolidated Admin Reports Data (Jobs, Tasks, Clients and Projects)
                CsApiApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataAdmin(startDate, endDate, userIds, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **userIds** | **string**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseCombinedReportsData**](CsApiApiResponseCombinedReportsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetallchartsdatauser"></a>
# **ReportsGetAllChartsDataUser**
> CsApiApiResponseCombinedReportsData ReportsGetAllChartsDataUser (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Get Consolidated User Reports Data (Jobs and Tasks)

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get Consolidated User Reports Data (Jobs and Tasks)
                CsApiApiResponseCombinedReportsData result = apiInstance.ReportsGetAllChartsDataUser(startDate, endDate, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseCombinedReportsData**](CsApiApiResponseCombinedReportsData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorgtripbyid"></a>
# **ReportsGetOrgTripById**
> CsApiApiResponseTrip ReportsGetOrgTripById (int? tripId, string xChronosheetsAuth)

Get trip by Id, for reporting purposes

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
            var tripId = 56;  // int? | The ID of the trip
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get trip by Id, for reporting purposes
                CsApiApiResponseTrip result = apiInstance.ReportsGetOrgTripById(tripId, xChronosheetsAuth);
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
 **tripId** | **int?**| The ID of the trip | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseTrip**](CsApiApiResponseTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorganisationtimesheetfileattachments"></a>
# **ReportsGetOrganisationTimesheetFileAttachments**
> CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment ReportsGetOrganisationTimesheetFileAttachments (DateTime? startDate, DateTime? endDate, int? skip, int? take, string userIds, string xChronosheetsAuth)

Reports on Organisation timesheet file attachments

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var skip = 56;  // int? | 
            var take = 56;  // int? | 
            var userIds = userIds_example;  // string | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Reports on Organisation timesheet file attachments
                CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment result = apiInstance.ReportsGetOrganisationTimesheetFileAttachments(startDate, endDate, skip, take, userIds, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **skip** | **int?**|  | 
 **take** | **int?**|  | 
 **userIds** | **string**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment**](CsApiApiResponseForPaginatedListOrgReportTimesheetFileAttachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetorganisationtrips"></a>
# **ReportsGetOrganisationTrips**
> CsApiApiResponseForPaginatedListOrgReportTrip ReportsGetOrganisationTrips (DateTime? startDate, DateTime? endDate, int? skip, int? take, string userIds, string xChronosheetsAuth)

Reports on Organisation trips (GPS tracking from whole organisation)

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var skip = 56;  // int? | 
            var take = 56;  // int? | 
            var userIds = userIds_example;  // string | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Reports on Organisation trips (GPS tracking from whole organisation)
                CsApiApiResponseForPaginatedListOrgReportTrip result = apiInstance.ReportsGetOrganisationTrips(startDate, endDate, skip, take, userIds, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **skip** | **int?**|  | 
 **take** | **int?**|  | 
 **userIds** | **string**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseForPaginatedListOrgReportTrip**](CsApiApiResponseForPaginatedListOrgReportTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsgetrawdataadmin"></a>
# **ReportsGetRawDataAdmin**
> CsApiApiResponseForPaginatedListRawReportItem ReportsGetRawDataAdmin (DateTime? startDate, DateTime? endDate, string userIds, string sort, string order, int? skip, int? take, string xChronosheetsAuth)

Get Timesheets Raw Data

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var userIds = userIds_example;  // string | 
            var sort = sort_example;  // string | 
            var order = order_example;  // string | 
            var skip = 56;  // int? | 
            var take = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get Timesheets Raw Data
                CsApiApiResponseForPaginatedListRawReportItem result = apiInstance.ReportsGetRawDataAdmin(startDate, endDate, userIds, sort, order, skip, take, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **userIds** | **string**|  | 
 **sort** | **string**|  | 
 **order** | **string**|  | 
 **skip** | **int?**|  | 
 **take** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseForPaginatedListRawReportItem**](CsApiApiResponseForPaginatedListRawReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsprojectcostingsadmin"></a>
# **ReportsProjectCostingsAdmin**
> CsApiApiResponseListProjectCostingReportItem ReportsProjectCostingsAdmin (DateTime? startDate, DateTime? endDate, string userIds, string xChronosheetsAuth)

Gets project cost estimations VS actual cost for date range and users

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var userIds = userIds_example;  // string | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Gets project cost estimations VS actual cost for date range and users
                CsApiApiResponseListProjectCostingReportItem result = apiInstance.ReportsProjectCostingsAdmin(startDate, endDate, userIds, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **userIds** | **string**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListProjectCostingReportItem**](CsApiApiResponseListProjectCostingReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reportsuserjobsovertime"></a>
# **ReportsUserJobsOverTime**
> CsApiApiResponseListJobSeriesReportItem ReportsUserJobsOverTime (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth)

Timeseries jobs data for the logged in user

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Timeseries jobs data for the logged in user
                CsApiApiResponseListJobSeriesReportItem result = apiInstance.ReportsUserJobsOverTime(startDate, endDate, xChronosheetsAuth);
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
 **startDate** | **DateTime?**|  | 
 **endDate** | **DateTime?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListJobSeriesReportItem**](CsApiApiResponseListJobSeriesReportItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

