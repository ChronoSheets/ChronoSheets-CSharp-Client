# ChronoSheetsAPI.ChronoSheetsClientLibApi.TripsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TripsCreateTrip**](TripsApi.md#tripscreatetrip) | **POST** /api/Trips/CreateTrip | Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.    Requires the &#39;SubmitTimesheets&#39; permission.
[**TripsGetMyTripById**](TripsApi.md#tripsgetmytripbyid) | **GET** /api/Trips/GetMyTripById | Get trip by Id.    Requires the &#39;ViewMyTrips&#39; permission.
[**TripsGetMyTrips**](TripsApi.md#tripsgetmytrips) | **GET** /api/Trips/GetMyTrips | Get my trips.  Get the GPS trips you&#39;ve recorded and submitted.    Requires the &#39;ViewMyTrips&#39; permission.


<a name="tripscreatetrip"></a>
# **TripsCreateTrip**
> CSApiResponseInt32 TripsCreateTrip (CSCreateTripRequest request, string xChronosheetsAuth)

Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.    Requires the 'SubmitTimesheets' permission.

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
            var request = new CSCreateTripRequest(); // CSCreateTripRequest | A Create Trip Request object containing values for the new Trip to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a new trip.  Important: create a timesheet record before calling this, passing in the new timesheet record id as a reference.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseInt32 result = apiInstance.TripsCreateTrip(request, xChronosheetsAuth);
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
 **request** | [**CSCreateTripRequest**](CSCreateTripRequest.md)| A Create Trip Request object containing values for the new Trip to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tripsgetmytripbyid"></a>
# **TripsGetMyTripById**
> CSApiResponseTrip TripsGetMyTripById (int? tripId, string xChronosheetsAuth)

Get trip by Id.    Requires the 'ViewMyTrips' permission.

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
            var tripId = 56;  // int? | The ID of the Trip you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get trip by Id.    Requires the 'ViewMyTrips' permission.
                CSApiResponseTrip result = apiInstance.TripsGetMyTripById(tripId, xChronosheetsAuth);
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
 **tripId** | **int?**| The ID of the Trip you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseTrip**](CSApiResponseTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tripsgetmytrips"></a>
# **TripsGetMyTrips**
> CSApiResponseForPaginatedListTrip TripsGetMyTrips (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null, int? vehicleId = null)

Get my trips.  Get the GPS trips you've recorded and submitted.    Requires the 'ViewMyTrips' permission.

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
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The Start date of the date range.  Trips after this date will be obtained.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The End date of the date range.  Trips before this date will be obtained.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many Trips (optional) 
            var take = 56;  // int? | Take this many Trips (optional) 
            var vehicleId = 56;  // int? | Filter by a particular Vehicle (get trips made with a particular vehicle), specified by VehicleId (optional) 

            try
            {
                // Get my trips.  Get the GPS trips you've recorded and submitted.    Requires the 'ViewMyTrips' permission.
                CSApiResponseForPaginatedListTrip result = apiInstance.TripsGetMyTrips(startDate, endDate, xChronosheetsAuth, skip, take, vehicleId);
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
 **startDate** | **DateTime?**| The Start date of the date range.  Trips after this date will be obtained. | 
 **endDate** | **DateTime?**| The End date of the date range.  Trips before this date will be obtained. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many Trips | [optional] 
 **take** | **int?**| Take this many Trips | [optional] 
 **vehicleId** | **int?**| Filter by a particular Vehicle (get trips made with a particular vehicle), specified by VehicleId | [optional] 

### Return type

[**CSApiResponseForPaginatedListTrip**](CSApiResponseForPaginatedListTrip.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

