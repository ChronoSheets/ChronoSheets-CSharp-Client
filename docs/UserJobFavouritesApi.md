# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserJobFavouritesApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserJobFavouritesCreateJobFavourite**](UserJobFavouritesApi.md#userjobfavouritescreatejobfavourite) | **POST** /api/UserJobFavourites/CreateJobFavourite | Create a job favourite.    Requires the &#39;SubmitTimesheets&#39; permission.
[**UserJobFavouritesDeleteJobFavourite**](UserJobFavouritesApi.md#userjobfavouritesdeletejobfavourite) | **DELETE** /api/UserJobFavourites/DeleteJobFavourite | Delete a job favourite.    Requires the &#39;SubmitTimesheets&#39; permission.
[**UserJobFavouritesGetJobFavourites**](UserJobFavouritesApi.md#userjobfavouritesgetjobfavourites) | **GET** /api/UserJobFavourites/GetJobFavourites | Get your job favourites.    Requires the &#39;SubmitTimesheets&#39; permission.


<a name="userjobfavouritescreatejobfavourite"></a>
# **UserJobFavouritesCreateJobFavourite**
> CSApiResponseInt32 UserJobFavouritesCreateJobFavourite (CSInsertUserJobFavouriteRequest request, string xChronosheetsAuth)

Create a job favourite.    Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesCreateJobFavouriteExample
    {
        public void main()
        {
            var apiInstance = new UserJobFavouritesApi();
            var request = new CSInsertUserJobFavouriteRequest(); // CSInsertUserJobFavouriteRequest | An Insert UserJobFavourite Request object containing values for the new UserJobFavourite to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a job favourite.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseInt32 result = apiInstance.UserJobFavouritesCreateJobFavourite(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesCreateJobFavourite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSInsertUserJobFavouriteRequest**](CSInsertUserJobFavouriteRequest.md)| An Insert UserJobFavourite Request object containing values for the new UserJobFavourite to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userjobfavouritesdeletejobfavourite"></a>
# **UserJobFavouritesDeleteJobFavourite**
> CSApiResponseBoolean UserJobFavouritesDeleteJobFavourite (int? jobId, string xChronosheetsAuth)

Delete a job favourite.    Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesDeleteJobFavouriteExample
    {
        public void main()
        {
            var apiInstance = new UserJobFavouritesApi();
            var jobId = 56;  // int? | The ID of the Job for the Job Favourite you want to delete.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a job favourite.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseBoolean result = apiInstance.UserJobFavouritesDeleteJobFavourite(jobId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesDeleteJobFavourite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| The ID of the Job for the Job Favourite you want to delete. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userjobfavouritesgetjobfavourites"></a>
# **UserJobFavouritesGetJobFavourites**
> CSApiResponseListUserJobFavourite UserJobFavouritesGetJobFavourites (string xChronosheetsAuth)

Get your job favourites.    Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesGetJobFavouritesExample
    {
        public void main()
        {
            var apiInstance = new UserJobFavouritesApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get your job favourites.    Requires the 'SubmitTimesheets' permission.
                CSApiResponseListUserJobFavourite result = apiInstance.UserJobFavouritesGetJobFavourites(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesGetJobFavourites: " + e.Message );
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

[**CSApiResponseListUserJobFavourite**](CSApiResponseListUserJobFavourite.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

