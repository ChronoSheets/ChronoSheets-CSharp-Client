# ChronoSheetsAPI.ChronoSheetsClientLibApi.GeoFencingApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GeoFencingCreateGeofence**](GeoFencingApi.md#geofencingcreategeofence) | **POST** /GeoFencing/CreateGeofence | Create a geofencing with rules to be used for clock on/off automation.  Requires the &#39;ManageGeofencing&#39; permission.
[**GeoFencingDeleteGeofence**](GeoFencingApi.md#geofencingdeletegeofence) | **DELETE** /GeoFencing/DeleteGeofence | Deletes a geofence.  Requires the &#39;ManageGeofencing&#39; permission.
[**GeoFencingGetGeofenceById**](GeoFencingApi.md#geofencinggetgeofencebyid) | **GET** /GeoFencing/GetGeofenceById | Get a geofence by ID  Requires the &#39;SubmitTimesheets&#39; permission.
[**GeoFencingGetGeofences**](GeoFencingApi.md#geofencinggetgeofences) | **GET** /GeoFencing/GetGeofences | Get geofences belonging to your organisation  Requires the &#39;SubmitTimesheets&#39; permission.
[**GeoFencingUpdateGeofence**](GeoFencingApi.md#geofencingupdategeofence) | **PUT** /GeoFencing/UpdateGeofence | Updates a geofencing with rules to be used for clock on/off automation.  Requires the &#39;ManageGeofencing&#39; permission.



## GeoFencingCreateGeofence

> ApiResponseInt32 GeoFencingCreateGeofence (string xChronosheetsAuth, CreateGeoFenceRequest request)

Create a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingCreateGeofenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new GeoFencingApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new CreateGeoFenceRequest(); // CreateGeoFenceRequest | 

            try
            {
                // Create a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.
                ApiResponseInt32 result = apiInstance.GeoFencingCreateGeofence(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingCreateGeofence: " + e.Message );
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
 **request** | [**CreateGeoFenceRequest**](CreateGeoFenceRequest.md)|  | 

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


## GeoFencingDeleteGeofence

> ApiResponseGeofence GeoFencingDeleteGeofence (int geofenceId, string xChronosheetsAuth)

Deletes a geofence.  Requires the 'ManageGeofencing' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingDeleteGeofenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new GeoFencingApi(Configuration.Default);
            var geofenceId = 56;  // int | Specify the geofence you want to delete with the geofence ID.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Deletes a geofence.  Requires the 'ManageGeofencing' permission.
                ApiResponseGeofence result = apiInstance.GeoFencingDeleteGeofence(geofenceId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingDeleteGeofence: " + e.Message );
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
 **geofenceId** | **int**| Specify the geofence you want to delete with the geofence ID. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseGeofence**](ApiResponseGeofence.md)

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


## GeoFencingGetGeofenceById

> ApiResponseGeofence GeoFencingGetGeofenceById (int geofenceId, string xChronosheetsAuth)

Get a geofence by ID  Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingGetGeofenceByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new GeoFencingApi(Configuration.Default);
            var geofenceId = 56;  // int | The ID of the geofence you want to obtain
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a geofence by ID  Requires the 'SubmitTimesheets' permission.
                ApiResponseGeofence result = apiInstance.GeoFencingGetGeofenceById(geofenceId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingGetGeofenceById: " + e.Message );
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
 **geofenceId** | **int**| The ID of the geofence you want to obtain | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseGeofence**](ApiResponseGeofence.md)

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


## GeoFencingGetGeofences

> ApiResponseForPaginatedListExtendedGeofence GeoFencingGetGeofences (string xChronosheetsAuth, int? skip = null, int? take = null)

Get geofences belonging to your organisation  Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingGetGeofencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new GeoFencingApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Number of records to skip (optional) 
            var take = 56;  // int? | Number of records to take (optional) 

            try
            {
                // Get geofences belonging to your organisation  Requires the 'SubmitTimesheets' permission.
                ApiResponseForPaginatedListExtendedGeofence result = apiInstance.GeoFencingGetGeofences(xChronosheetsAuth, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingGetGeofences: " + e.Message );
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
 **skip** | **int?**| Number of records to skip | [optional] 
 **take** | **int?**| Number of records to take | [optional] 

### Return type

[**ApiResponseForPaginatedListExtendedGeofence**](ApiResponseForPaginatedListExtendedGeofence.md)

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


## GeoFencingUpdateGeofence

> ApiResponseInt32 GeoFencingUpdateGeofence (string xChronosheetsAuth, UpdateGeoFenceRequest request)

Updates a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class GeoFencingUpdateGeofenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new GeoFencingApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new UpdateGeoFenceRequest(); // UpdateGeoFenceRequest | 

            try
            {
                // Updates a geofencing with rules to be used for clock on/off automation.  Requires the 'ManageGeofencing' permission.
                ApiResponseInt32 result = apiInstance.GeoFencingUpdateGeofence(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GeoFencingApi.GeoFencingUpdateGeofence: " + e.Message );
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
 **request** | [**UpdateGeoFenceRequest**](UpdateGeoFenceRequest.md)|  | 

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

