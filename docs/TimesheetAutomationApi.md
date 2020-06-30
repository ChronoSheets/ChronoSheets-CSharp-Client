# ChronoSheetsAPI.ChronoSheetsClientLibApi.TimesheetAutomationApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimesheetAutomationCreateAutomationStep**](TimesheetAutomationApi.md#timesheetautomationcreateautomationstep) | **POST** /TimesheetAutomation/CreateAutomationStep | Creates an automation step.  Timesheet automation is determined by looking at steps taken by the user.  Create a step to log some automation action, such as entering a geofence or tapping on an NFC badge.  Requires the &#39;SubmitTimesheets&#39; permission.
[**TimesheetAutomationGetTimesheetAutomationAuditTrail**](TimesheetAutomationApi.md#timesheetautomationgettimesheetautomationaudittrail) | **GET** /TimesheetAutomation/GetTimesheetAutomationAuditTrail | Retrieve the timesheet automation / alerts for geofences activities or NFC tap on/off.  Requires the &#39;ManageGeofencing&#39; permission.


<a name="timesheetautomationcreateautomationstep"></a>
# **TimesheetAutomationCreateAutomationStep**
> CSApiResponseInt32 TimesheetAutomationCreateAutomationStep (CSCreateAutomationStepRequest request, string xChronosheetsAuth)

Creates an automation step.  Timesheet automation is determined by looking at steps taken by the user.  Create a step to log some automation action, such as entering a geofence or tapping on an NFC badge.  Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetAutomationCreateAutomationStepExample
    {
        public void main()
        {
            var apiInstance = new TimesheetAutomationApi();
            var request = new CSCreateAutomationStepRequest(); // CSCreateAutomationStepRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Creates an automation step.  Timesheet automation is determined by looking at steps taken by the user.  Create a step to log some automation action, such as entering a geofence or tapping on an NFC badge.  Requires the 'SubmitTimesheets' permission.
                CSApiResponseInt32 result = apiInstance.TimesheetAutomationCreateAutomationStep(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetAutomationApi.TimesheetAutomationCreateAutomationStep: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSCreateAutomationStepRequest**](CSCreateAutomationStepRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="timesheetautomationgettimesheetautomationaudittrail"></a>
# **TimesheetAutomationGetTimesheetAutomationAuditTrail**
> CSApiResponseForPaginatedListTimesheetAutomationWithOrgAndGeofence TimesheetAutomationGetTimesheetAutomationAuditTrail (int? geofenceId, int? userId, string sort, string order, string xChronosheetsAuth, int? skip = null, int? take = null)

Retrieve the timesheet automation / alerts for geofences activities or NFC tap on/off.  Requires the 'ManageGeofencing' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TimesheetAutomationGetTimesheetAutomationAuditTrailExample
    {
        public void main()
        {
            var apiInstance = new TimesheetAutomationApi();
            var geofenceId = 56;  // int? | The ID of the Geofence
            var userId = 56;  // int? | 
            var sort = sort_example;  // string | 
            var order = order_example;  // string | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many records (optional) 
            var take = 56;  // int? | Take this many records (optional) 

            try
            {
                // Retrieve the timesheet automation / alerts for geofences activities or NFC tap on/off.  Requires the 'ManageGeofencing' permission.
                CSApiResponseForPaginatedListTimesheetAutomationWithOrgAndGeofence result = apiInstance.TimesheetAutomationGetTimesheetAutomationAuditTrail(geofenceId, userId, sort, order, xChronosheetsAuth, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimesheetAutomationApi.TimesheetAutomationGetTimesheetAutomationAuditTrail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geofenceId** | **int?**| The ID of the Geofence | 
 **userId** | **int?**|  | 
 **sort** | **string**|  | 
 **order** | **string**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many records | [optional] 
 **take** | **int?**| Take this many records | [optional] 

### Return type

[**CSApiResponseForPaginatedListTimesheetAutomationWithOrgAndGeofence**](CSApiResponseForPaginatedListTimesheetAutomationWithOrgAndGeofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

