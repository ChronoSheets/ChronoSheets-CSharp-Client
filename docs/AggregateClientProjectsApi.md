# ChronoSheetsAPI.ChronoSheetsClientLibApi.AggregateClientProjectsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AggregateClientProjectsGetAggregateClientProjects**](AggregateClientProjectsApi.md#aggregateclientprojectsgetaggregateclientprojects) | **GET** /AggregateClientProjects/GetAggregateClientProjects | Get client and project information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageClientsAndProjects&#39; permissions.


<a name="aggregateclientprojectsgetaggregateclientprojects"></a>
# **AggregateClientProjectsGetAggregateClientProjects**
> CSApiResponseListAggregateClient AggregateClientProjectsGetAggregateClientProjects (string xChronosheetsAuth)

Get client and project information, aggregated.    Requires the 'SubmitTimesheets' or 'ManageClientsAndProjects' permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class AggregateClientProjectsGetAggregateClientProjectsExample
    {
        public void main()
        {
            var apiInstance = new AggregateClientProjectsApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get client and project information, aggregated.    Requires the 'SubmitTimesheets' or 'ManageClientsAndProjects' permissions.
                CSApiResponseListAggregateClient result = apiInstance.AggregateClientProjectsGetAggregateClientProjects(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AggregateClientProjectsApi.AggregateClientProjectsGetAggregateClientProjects: " + e.Message );
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

[**CSApiResponseListAggregateClient**](CSApiResponseListAggregateClient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

