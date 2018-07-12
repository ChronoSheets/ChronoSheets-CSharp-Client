# ChronoSheetsAPI.ChronoSheetsClientLibApi.FleetApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FleetCreateVehicle**](FleetApi.md#fleetcreatevehicle) | **POST** /api/Fleet/CreateVehicle | Create a vehicle.    Requires the &#39;ManageFleet&#39; permission.
[**FleetGetVehicleById**](FleetApi.md#fleetgetvehiclebyid) | **GET** /api/Fleet/GetVehicleById | Get a particular vehicle.  Does not require any special permission.
[**FleetGetVehicles**](FleetApi.md#fleetgetvehicles) | **GET** /api/Fleet/GetVehicles | Get a collection of vehicles that are under your organisation.    Does not require any special permission.
[**FleetUpdateVehicle**](FleetApi.md#fleetupdatevehicle) | **PUT** /api/Fleet/UpdateVehicle | Update a vehicle.    Requires the &#39;ManageFleet&#39; permission.


<a name="fleetcreatevehicle"></a>
# **FleetCreateVehicle**
> CSApiResponseInt32 FleetCreateVehicle (CSInsertVehicleRequest request, string xChronosheetsAuth)

Create a vehicle.    Requires the 'ManageFleet' permission.

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
            var request = new CSInsertVehicleRequest(); // CSInsertVehicleRequest | An Insert Vehicle Request object containing values for the new Vehicle to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a vehicle.    Requires the 'ManageFleet' permission.
                CSApiResponseInt32 result = apiInstance.FleetCreateVehicle(request, xChronosheetsAuth);
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
 **request** | [**CSInsertVehicleRequest**](CSInsertVehicleRequest.md)| An Insert Vehicle Request object containing values for the new Vehicle to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetgetvehiclebyid"></a>
# **FleetGetVehicleById**
> CSApiResponseFleetVehicle FleetGetVehicleById (int? vehicleId, string xChronosheetsAuth)

Get a particular vehicle.  Does not require any special permission.

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
            var vehicleId = 56;  // int? | The ID of the Vehicle you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular vehicle.  Does not require any special permission.
                CSApiResponseFleetVehicle result = apiInstance.FleetGetVehicleById(vehicleId, xChronosheetsAuth);
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
 **vehicleId** | **int?**| The ID of the Vehicle you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseFleetVehicle**](CSApiResponseFleetVehicle.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetgetvehicles"></a>
# **FleetGetVehicles**
> CSApiResponseListFleetVehicle FleetGetVehicles (bool? includeDeleted, string xChronosheetsAuth)

Get a collection of vehicles that are under your organisation.    Does not require any special permission.

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
            var includeDeleted = true;  // bool? | Whether or not to include deleted vehicles
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of vehicles that are under your organisation.    Does not require any special permission.
                CSApiResponseListFleetVehicle result = apiInstance.FleetGetVehicles(includeDeleted, xChronosheetsAuth);
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
 **includeDeleted** | **bool?**| Whether or not to include deleted vehicles | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListFleetVehicle**](CSApiResponseListFleetVehicle.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fleetupdatevehicle"></a>
# **FleetUpdateVehicle**
> CSApiResponseBoolean FleetUpdateVehicle (CSSaveVehicleRequest request, string xChronosheetsAuth)

Update a vehicle.    Requires the 'ManageFleet' permission.

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
            var request = new CSSaveVehicleRequest(); // CSSaveVehicleRequest | A Save Vehicle Request object containing updated fields.  Make sure to specify the Vehicle Id in the request object so that ChronoSheets knows which Vehicle to update
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a vehicle.    Requires the 'ManageFleet' permission.
                CSApiResponseBoolean result = apiInstance.FleetUpdateVehicle(request, xChronosheetsAuth);
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
 **request** | [**CSSaveVehicleRequest**](CSSaveVehicleRequest.md)| A Save Vehicle Request object containing updated fields.  Make sure to specify the Vehicle Id in the request object so that ChronoSheets knows which Vehicle to update | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

