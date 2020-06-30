# ChronoSheetsAPI.ChronoSheetsClientLibApi.GeoFencingApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GeoFencingCreateGeofence**](GeoFencingApi.md#geofencingcreategeofence) | **POST** /GeoFencing/CreateGeofence | Create a geofencing with rules to be used for clock on/off automation.  Requires the &#39;ManageGeofencing&#39; permission.
[**GeoFencingDeleteGeofence**](GeoFencingApi.md#geofencingdeletegeofence) | **DELETE** /GeoFencing/DeleteGeofence | Deletes a geofence.  Requires the &#39;ManageGeofencing&#39; permission.
[**GeoFencingGetGeofenceById**](GeoFencingApi.md#geofencinggetgeofencebyid) | **GET** /GeoFencing/GetGeofenceById | Get a geofence by ID  Requires the &#39;SubmitTimesheets&#39; permission.
[**GeoFencingGetGeofences**](GeoFencingApi.md#geofencinggetgeofences) | **GET** /GeoFencing/GetGeofences | Get geofences belonging to your organisation  Requires the &#39;SubmitTimesheets&#39; permission.
[**GeoFencingUpdateGeofence**](GeoFencingApi.md#geofencingupdategeofence) | **PUT** /GeoFencing/UpdateGeofence | Updates a geofencing with rules to be used for clock on/off automation.  Requires the &#39;ManageGeofencing&#39; permission.


<a name="geofencingcreategeofence"></a>
# **GeoFencingCreateGeofence**
> CSApiResponseInt32 GeoFencingCreateGeofence (CSCreateGeoFenceRequest request, string xChronosheetsAuth)

Create a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingCreateGeofenceExample
    {
        public void main()
        {
            var apiInstance = new GeoFencingApi();
            var request = new CSCreateGeoFenceRequest(); // CSCreateGeoFenceRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.
                CSApiResponseInt32 result = apiInstance.GeoFencingCreateGeofence(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingCreateGeofence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSCreateGeoFenceRequest**](CSCreateGeoFenceRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geofencingdeletegeofence"></a>
# **GeoFencingDeleteGeofence**
> CSApiResponseGeofence GeoFencingDeleteGeofence (int? geofenceId, string xChronosheetsAuth)

Deletes a geofence.  Requires the 'ManageGeofencing' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingDeleteGeofenceExample
    {
        public void main()
        {
            var apiInstance = new GeoFencingApi();
            var geofenceId = 56;  // int? | Specify the geofence you want to delete with the geofence ID.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Deletes a geofence.  Requires the 'ManageGeofencing' permission.
                CSApiResponseGeofence result = apiInstance.GeoFencingDeleteGeofence(geofenceId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingDeleteGeofence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geofenceId** | **int?**| Specify the geofence you want to delete with the geofence ID. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseGeofence**](CSApiResponseGeofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geofencinggetgeofencebyid"></a>
# **GeoFencingGetGeofenceById**
> CSApiResponseGeofence GeoFencingGetGeofenceById (int? geofenceId, string xChronosheetsAuth)

Get a geofence by ID  Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingGetGeofenceByIdExample
    {
        public void main()
        {
            var apiInstance = new GeoFencingApi();
            var geofenceId = 56;  // int? | The ID of the geofence you want to obtain
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a geofence by ID  Requires the 'SubmitTimesheets' permission.
                CSApiResponseGeofence result = apiInstance.GeoFencingGetGeofenceById(geofenceId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingGetGeofenceById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **geofenceId** | **int?**| The ID of the geofence you want to obtain | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseGeofence**](CSApiResponseGeofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geofencinggetgeofences"></a>
# **GeoFencingGetGeofences**
> CSApiResponseForPaginatedListExtendedGeofence GeoFencingGetGeofences (string xChronosheetsAuth, int? skip = null, int? take = null)

Get geofences belonging to your organisation  Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingGetGeofencesExample
    {
        public void main()
        {
            var apiInstance = new GeoFencingApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Number of records to skip (optional) 
            var take = 56;  // int? | Number of records to take (optional) 

            try
            {
                // Get geofences belonging to your organisation  Requires the 'SubmitTimesheets' permission.
                CSApiResponseForPaginatedListExtendedGeofence result = apiInstance.GeoFencingGetGeofences(xChronosheetsAuth, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingGetGeofences: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Number of records to skip | [optional] 
 **take** | **int?**| Number of records to take | [optional] 

### Return type

[**CSApiResponseForPaginatedListExtendedGeofence**](CSApiResponseForPaginatedListExtendedGeofence.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geofencingupdategeofence"></a>
# **GeoFencingUpdateGeofence**
> CSApiResponseInt32 GeoFencingUpdateGeofence (CSUpdateGeoFenceRequest request, string xChronosheetsAuth)

Updates a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingUpdateGeofenceExample
    {
        public void main()
        {
            var apiInstance = new GeoFencingApi();
            var request = new CSUpdateGeoFenceRequest(); // CSUpdateGeoFenceRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Updates a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.
                CSApiResponseInt32 result = apiInstance.GeoFencingUpdateGeofence(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingUpdateGeofence: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSUpdateGeoFenceRequest**](CSUpdateGeoFenceRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

