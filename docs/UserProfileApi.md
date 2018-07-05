# ChronoSheetsAPI.ChronoSheetsClientLibApi.UserProfileApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserProfileDoLogin**](UserProfileApi.md#userprofiledologin) | **POST** /api/UserProfile/DoLogin | 
[**UserProfileDoLogout**](UserProfileApi.md#userprofiledologout) | **DELETE** /api/UserProfile/DoLogout | 
[**UserProfileGetMyProfile**](UserProfileApi.md#userprofilegetmyprofile) | **GET** /api/UserProfile/GetMyProfile | 
[**UserProfileKeepSessionAlive**](UserProfileApi.md#userprofilekeepsessionalive) | **GET** /api/UserProfile/KeepSessionAlive | 
[**UserProfileUpdateMyProfile**](UserProfileApi.md#userprofileupdatemyprofile) | **POST** /api/UserProfile/UpdateMyProfile | 


<a name="userprofiledologin"></a>
# **UserProfileDoLogin**
> CSApiResponseDoLoginResponse UserProfileDoLogin (CSDoLoginRequest request)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserProfileDoLoginExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();
            var request = new CSDoLoginRequest(); // CSDoLoginRequest | 

            try
            {
                CSApiResponseDoLoginResponse result = apiInstance.UserProfileDoLogin(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileDoLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSDoLoginRequest**](CSDoLoginRequest.md)|  | 

### Return type

[**CSApiResponseDoLoginResponse**](CSApiResponseDoLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofiledologout"></a>
# **UserProfileDoLogout**
> CSApiResponseBoolean UserProfileDoLogout (string xChronosheetsAuth)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserProfileDoLogoutExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                CSApiResponseBoolean result = apiInstance.UserProfileDoLogout(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileDoLogout: " + e.Message );
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

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilegetmyprofile"></a>
# **UserProfileGetMyProfile**
> CSApiResponseUserProfile UserProfileGetMyProfile (string xChronosheetsAuth)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserProfileGetMyProfileExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                CSApiResponseUserProfile result = apiInstance.UserProfileGetMyProfile(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileGetMyProfile: " + e.Message );
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

[**CSApiResponseUserProfile**](CSApiResponseUserProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilekeepsessionalive"></a>
# **UserProfileKeepSessionAlive**
> CSApiResponseBoolean UserProfileKeepSessionAlive (string xChronosheetsAuth)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserProfileKeepSessionAliveExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                CSApiResponseBoolean result = apiInstance.UserProfileKeepSessionAlive(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileKeepSessionAlive: " + e.Message );
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

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileupdatemyprofile"></a>
# **UserProfileUpdateMyProfile**
> CSApiResponseUpdateProfileResponse UserProfileUpdateMyProfile (CSUpdateMyProfileRequest request, string xChronosheetsAuth)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UserProfileUpdateMyProfileExample
    {
        public void main()
        {
            var apiInstance = new UserProfileApi();
            var request = new CSUpdateMyProfileRequest(); // CSUpdateMyProfileRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                CSApiResponseUpdateProfileResponse result = apiInstance.UserProfileUpdateMyProfile(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserProfileApi.UserProfileUpdateMyProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSUpdateMyProfileRequest**](CSUpdateMyProfileRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseUpdateProfileResponse**](CSApiResponseUpdateProfileResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

