# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserJobFavouritesApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserJobFavouritesCreateJobFavourite**](UserJobFavouritesApi.md#userjobfavouritescreatejobfavourite) | **POST** /UserJobFavourites/CreateJobFavourite | Create a job favourite.    Requires the &#39;SubmitTimesheets&#39; permission.
[**UserJobFavouritesDeleteJobFavourite**](UserJobFavouritesApi.md#userjobfavouritesdeletejobfavourite) | **DELETE** /UserJobFavourites/DeleteJobFavourite | Delete a job favourite.    Requires the &#39;SubmitTimesheets&#39; permission.
[**UserJobFavouritesGetJobFavourites**](UserJobFavouritesApi.md#userjobfavouritesgetjobfavourites) | **GET** /UserJobFavourites/GetJobFavourites | Get your job favourites.    Requires the &#39;SubmitTimesheets&#39; permission.



## UserJobFavouritesCreateJobFavourite

> ApiResponseInt32 UserJobFavouritesCreateJobFavourite (string xChronosheetsAuth, InsertUserJobFavouriteRequest request)

Create a job favourite.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesCreateJobFavouriteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UserJobFavouritesApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new InsertUserJobFavouriteRequest(); // InsertUserJobFavouriteRequest | An Insert UserJobFavourite Request object containing values for the new UserJobFavourite to create

            try
            {
                // Create a job favourite.    Requires the 'SubmitTimesheets' permission.
                ApiResponseInt32 result = apiInstance.UserJobFavouritesCreateJobFavourite(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesCreateJobFavourite: " + e.Message );
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
 **request** | [**InsertUserJobFavouriteRequest**](InsertUserJobFavouriteRequest.md)| An Insert UserJobFavourite Request object containing values for the new UserJobFavourite to create | 

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


## UserJobFavouritesDeleteJobFavourite

> ApiResponseBoolean UserJobFavouritesDeleteJobFavourite (int jobId, string xChronosheetsAuth)

Delete a job favourite.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesDeleteJobFavouriteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UserJobFavouritesApi(Configuration.Default);
            var jobId = 56;  // int | The ID of the Job for the Job Favourite you want to delete.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a job favourite.    Requires the 'SubmitTimesheets' permission.
                ApiResponseBoolean result = apiInstance.UserJobFavouritesDeleteJobFavourite(jobId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesDeleteJobFavourite: " + e.Message );
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
 **jobId** | **int**| The ID of the Job for the Job Favourite you want to delete. | 
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


## UserJobFavouritesGetJobFavourites

> ApiResponseListUserJobFavourite UserJobFavouritesGetJobFavourites (string xChronosheetsAuth)

Get your job favourites.    Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserJobFavouritesGetJobFavouritesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UserJobFavouritesApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get your job favourites.    Requires the 'SubmitTimesheets' permission.
                ApiResponseListUserJobFavourite result = apiInstance.UserJobFavouritesGetJobFavourites(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserJobFavouritesApi.UserJobFavouritesGetJobFavourites: " + e.Message );
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

### Return type

[**ApiResponseListUserJobFavourite**](ApiResponseListUserJobFavourite.md)

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

