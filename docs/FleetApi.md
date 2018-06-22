# ChronoSheetsAPI.ChronoSheetsClientLibApi.FleetApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FleetCreateVehicle**](FleetApi.md#fleetcreatevehicle) | **PUT** /api/Fleet/CreateVehicle | Create a vehicle
[**FleetGetVehicleById**](FleetApi.md#fleetgetvehiclebyid) | **GET** /api/Fleet/GetVehicleById | Get a particular vehicle
[**FleetGetVehicles**](FleetApi.md#fleetgetvehicles) | **GET** /api/Fleet/GetVehicles | Get a collection of vehicles that are under your organisation
[**FleetUpdateVehicle**](FleetApi.md#fleetupdatevehicle) | **POST** /api/Fleet/UpdateVehicle | Update a vehicle


<a name="fleetcreatevehicle"></a>
# **FleetCreateVehicle**
> CsApiApiResponseInt32 FleetCreateVehicle (CsApiInsertVehicleRequest request, string xChronosheetsAuth)

Create a vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetCreateVehicleExample
    {
        public void main()
        {
            var apiInstance = new FleetApi();
            var request = new CsApiInsertVehicleRequest(); // CsApiInsertVehicleRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a vehicle
                CsApiApiResponseInt32 result = apiInstance.FleetCreateVehicle(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetApi.FleetCreateVehicle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertVehicleRequest**](CsApiInsertVehicleRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetgetvehiclebyid"></a>
# **FleetGetVehicleById**
> CsApiApiResponseFleetVehicle FleetGetVehicleById (int? vehicleId, string xChronosheetsAuth)

Get a particular vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetGetVehicleByIdExample
    {
        public void main()
        {
            var apiInstance = new FleetApi();
            var vehicleId = 56;  // int? | The ID of the vehicle you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular vehicle
                CsApiApiResponseFleetVehicle result = apiInstance.FleetGetVehicleById(vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetApi.FleetGetVehicleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleId** | **int?**| The ID of the vehicle you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseFleetVehicle**](CsApiApiResponseFleetVehicle.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetgetvehicles"></a>
# **FleetGetVehicles**
> CsApiApiResponseListFleetVehicle FleetGetVehicles (bool? includeDeleted, string xChronosheetsAuth)

Get a collection of vehicles that are under your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetGetVehiclesExample
    {
        public void main()
        {
            var apiInstance = new FleetApi();
            var includeDeleted = true;  // bool? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of vehicles that are under your organisation
                CsApiApiResponseListFleetVehicle result = apiInstance.FleetGetVehicles(includeDeleted, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetApi.FleetGetVehicles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includeDeleted** | **bool?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListFleetVehicle**](CsApiApiResponseListFleetVehicle.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetupdatevehicle"></a>
# **FleetUpdateVehicle**
> CsApiApiResponseBoolean FleetUpdateVehicle (CsApiSaveVehicleRequest request, string xChronosheetsAuth)

Update a vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FleetUpdateVehicleExample
    {
        public void main()
        {
            var apiInstance = new FleetApi();
            var request = new CsApiSaveVehicleRequest(); // CsApiSaveVehicleRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a vehicle
                CsApiApiResponseBoolean result = apiInstance.FleetUpdateVehicle(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FleetApi.FleetUpdateVehicle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiSaveVehicleRequest**](CsApiSaveVehicleRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

