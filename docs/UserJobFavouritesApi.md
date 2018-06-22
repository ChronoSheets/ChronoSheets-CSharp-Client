# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserJobFavouritesApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserJobFavouritesCreateJobFavourite**](UserJobFavouritesApi.md#userjobfavouritescreatejobfavourite) | **PUT** /api/UserJobFavourites/CreateJobFavourite | Create a job favourite
[**UserJobFavouritesDeleteJobFavourite**](UserJobFavouritesApi.md#userjobfavouritesdeletejobfavourite) | **DELETE** /api/UserJobFavourites/DeleteJobFavourite | Delete a job favourite
[**UserJobFavouritesGetJobFavourites**](UserJobFavouritesApi.md#userjobfavouritesgetjobfavourites) | **GET** /api/UserJobFavourites/GetJobFavourites | Get your job favourites


<a name="userjobfavouritescreatejobfavourite"></a>
# **UserJobFavouritesCreateJobFavourite**
> CsApiApiResponseInt32 UserJobFavouritesCreateJobFavourite (CsApiInsertUserJobFavouriteRequest request, string xChronosheetsAuth)

Create a job favourite

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
            var request = new CsApiInsertUserJobFavouriteRequest(); // CsApiInsertUserJobFavouriteRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a job favourite
                CsApiApiResponseInt32 result = apiInstance.UserJobFavouritesCreateJobFavourite(request, xChronosheetsAuth);
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
 **request** | [**CsApiInsertUserJobFavouriteRequest**](CsApiInsertUserJobFavouriteRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userjobfavouritesdeletejobfavourite"></a>
# **UserJobFavouritesDeleteJobFavourite**
> CsApiApiResponseBoolean UserJobFavouritesDeleteJobFavourite (int? jobId, string xChronosheetsAuth)

Delete a job favourite

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
            var jobId = 56;  // int? | The ID of the Job
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a job favourite
                CsApiApiResponseBoolean result = apiInstance.UserJobFavouritesDeleteJobFavourite(jobId, xChronosheetsAuth);
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
 **jobId** | **int?**| The ID of the Job | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userjobfavouritesgetjobfavourites"></a>
# **UserJobFavouritesGetJobFavourites**
> CsApiApiResponseListUserJobFavourite UserJobFavouritesGetJobFavourites (string xChronosheetsAuth)

Get your job favourites

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
                // Get your job favourites
                CsApiApiResponseListUserJobFavourite result = apiInstance.UserJobFavouritesGetJobFavourites(xChronosheetsAuth);
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

[**CsApiApiResponseListUserJobFavourite**](CsApiApiResponseListUserJobFavourite.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

