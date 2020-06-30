# ChronoSheetsAPI.ChronoSheetsClientLibApi.AggregateJobTasksApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregateJobTasksGetAggregateJobTasks**](AggregateJobTasksApi.md#aggregatejobtasksgetaggregatejobtasks) | **GET** /AggregateJobTasks/GetAggregateJobTasks | Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.


<a name="aggregatejobtasksgetaggregatejobtasks"></a>
# **AggregateJobTasksGetAggregateJobTasks**
> CSApiResponseListAggregateJobCode AggregateJobTasksGetAggregateJobTasks (string xChronosheetsAuth)

Get jobs and tasks information, aggregated.    Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class AggregateJobTasksGetAggregateJobTasksExample
    {
        public void main()
        {
            var apiInstance = new AggregateJobTasksApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get jobs and tasks information, aggregated.    Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.
                CSApiResponseListAggregateJobCode result = apiInstance.AggregateJobTasksGetAggregateJobTasks(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregateJobTasksApi.AggregateJobTasksGetAggregateJobTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListAggregateJobCode**](CSApiResponseListAggregateJobCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

