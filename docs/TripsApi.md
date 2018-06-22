# ChronoSheetsAPI.ChronoSheetsClientLibApi.TripsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TripsCreateTrip**](TripsApi.md#tripscreatetrip) | **POST** /api/Trips/CreateTrip | Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.
[**TripsGetMyTripById**](TripsApi.md#tripsgetmytripbyid) | **GET** /api/Trips/GetMyTripById | Get trip by Id
[**TripsGetMyTrips**](TripsApi.md#tripsgetmytrips) | **GET** /api/Trips/GetMyTrips | Get my trips


<a name="tripscreatetrip"></a>
# **TripsCreateTrip**
> CsApiApiResponseInt32 TripsCreateTrip (CsApiCreateTripRequest request, string xChronosheetsAuth)

Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TripsCreateTripExample
    {
        public void main()
        {
            var apiInstance = new TripsApi();
            var request = new CsApiCreateTripRequest(); // CsApiCreateTripRequest | The create trip request
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.
                CsApiApiResponseInt32 result = apiInstance.TripsCreateTrip(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripsApi.TripsCreateTrip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiCreateTripRequest**](CsApiCreateTripRequest.md)| The create trip request | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tripsgetmytripbyid"></a>
# **TripsGetMyTripById**
> CsApiApiResponseTrip TripsGetMyTripById (int? tripId, string xChronosheetsAuth)

Get trip by Id

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TripsGetMyTripByIdExample
    {
        public void main()
        {
            var apiInstance = new TripsApi();
            var tripId = 56;  // int? | The ID of the trip
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get trip by Id
                CsApiApiResponseTrip result = apiInstance.TripsGetMyTripById(tripId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripsApi.TripsGetMyTripById: " + e.Message );
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

<a name="tripsgetmytrips"></a>
# **TripsGetMyTrips**
> CsApiApiResponseForPaginatedListTrip TripsGetMyTrips (DateTime? startDate, DateTime? endDate, int? skip, int? take, int? vehicleId, string xChronosheetsAuth)

Get my trips

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TripsGetMyTripsExample
    {
        public void main()
        {
            var apiInstance = new TripsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | 
            var skip = 56;  // int? | 
            var take = 56;  // int? | 
            var vehicleId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get my trips
                CsApiApiResponseForPaginatedListTrip result = apiInstance.TripsGetMyTrips(startDate, endDate, skip, take, vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TripsApi.TripsGetMyTrips: " + e.Message );
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
 **vehicleId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseForPaginatedListTrip**](CsApiApiResponseForPaginatedListTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

