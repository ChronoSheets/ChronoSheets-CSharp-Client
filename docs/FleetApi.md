# ChronoSheetsAPI.ChronoSheetsClientLibApi.FleetApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FleetCreateVehicle**](FleetApi.md#fleetcreatevehicle) | **POST** /Fleet/CreateVehicle | Create a vehicle.    Requires the &#39;ManageFleet&#39; permission.
[**FleetDeleteVehicle**](FleetApi.md#fleetdeletevehicle) | **DELETE** /Fleet/DeleteVehicle | Delete a vehicle from the fleet.  Requires the &#39;ManageFleet&#39; permission.
[**FleetGetVehicleById**](FleetApi.md#fleetgetvehiclebyid) | **GET** /Fleet/GetVehicleById | Get a particular vehicle.  Does not require any special permission.
[**FleetGetVehicles**](FleetApi.md#fleetgetvehicles) | **GET** /Fleet/GetVehicles | Get a collection of vehicles that are under your organisation.    Does not require any special permission.
[**FleetUpdateVehicle**](FleetApi.md#fleetupdatevehicle) | **PUT** /Fleet/UpdateVehicle | Update a vehicle.    Requires the &#39;ManageFleet&#39; permission.



## FleetCreateVehicle

> ApiResponseInt32 FleetCreateVehicle (string xChronosheetsAuth, InsertVehicleRequest request)

Create a vehicle.    Requires the 'ManageFleet' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetCreateVehicleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FleetApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new InsertVehicleRequest(); // InsertVehicleRequest | An Insert Vehicle Request object containing values for the new Vehicle to create

            try
            {
                // Create a vehicle.    Requires the 'ManageFleet' permission.
                ApiResponseInt32 result = apiInstance.FleetCreateVehicle(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FleetApi.FleetCreateVehicle: " + e.Message );
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
 **request** | [**InsertVehicleRequest**](InsertVehicleRequest.md)| An Insert Vehicle Request object containing values for the new Vehicle to create | 

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


## FleetDeleteVehicle

> ApiResponseBoolean FleetDeleteVehicle (int vehicleId, string xChronosheetsAuth)

Delete a vehicle from the fleet.  Requires the 'ManageFleet' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetDeleteVehicleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FleetApi(Configuration.Default);
            var vehicleId = 56;  // int | The unique ID of the vehicle you wish to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a vehicle from the fleet.  Requires the 'ManageFleet' permission.
                ApiResponseBoolean result = apiInstance.FleetDeleteVehicle(vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FleetApi.FleetDeleteVehicle: " + e.Message );
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
 **vehicleId** | **int**| The unique ID of the vehicle you wish to delete | 
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


## FleetGetVehicleById

> ApiResponseFleetVehicle FleetGetVehicleById (int vehicleId, string xChronosheetsAuth)

Get a particular vehicle.  Does not require any special permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetGetVehicleByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FleetApi(Configuration.Default);
            var vehicleId = 56;  // int | The ID of the Vehicle you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular vehicle.  Does not require any special permission.
                ApiResponseFleetVehicle result = apiInstance.FleetGetVehicleById(vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FleetApi.FleetGetVehicleById: " + e.Message );
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
 **vehicleId** | **int**| The ID of the Vehicle you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseFleetVehicle**](ApiResponseFleetVehicle.md)

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


## FleetGetVehicles

> ApiResponseListFleetVehicle FleetGetVehicles (string xChronosheetsAuth, bool? includeDeleted = null)

Get a collection of vehicles that are under your organisation.    Does not require any special permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetGetVehiclesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FleetApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var includeDeleted = true;  // bool? | Whether or not to include deleted vehicles (optional) 

            try
            {
                // Get a collection of vehicles that are under your organisation.    Does not require any special permission.
                ApiResponseListFleetVehicle result = apiInstance.FleetGetVehicles(xChronosheetsAuth, includeDeleted);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FleetApi.FleetGetVehicles: " + e.Message );
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
 **includeDeleted** | **bool?**| Whether or not to include deleted vehicles | [optional] 

### Return type

[**ApiResponseListFleetVehicle**](ApiResponseListFleetVehicle.md)

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


## FleetUpdateVehicle

> ApiResponseBoolean FleetUpdateVehicle (string xChronosheetsAuth, SaveVehicleRequest request)

Update a vehicle.    Requires the 'ManageFleet' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetUpdateVehicleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FleetApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new SaveVehicleRequest(); // SaveVehicleRequest | A Save Vehicle Request object containing updated fields.  Make sure to specify the Vehicle Id in the request object so that ChronoSheets knows which Vehicle to update

            try
            {
                // Update a vehicle.    Requires the 'ManageFleet' permission.
                ApiResponseBoolean result = apiInstance.FleetUpdateVehicle(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FleetApi.FleetUpdateVehicle: " + e.Message );
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
 **request** | [**SaveVehicleRequest**](SaveVehicleRequest.md)| A Save Vehicle Request object containing updated fields.  Make sure to specify the Vehicle Id in the request object so that ChronoSheets knows which Vehicle to update | 

### Return type

[**ApiResponseBoolean**](ApiResponseBoolean.md)

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

