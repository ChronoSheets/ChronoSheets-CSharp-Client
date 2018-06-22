# ChronoSheetsAPI.ChronoSheetsClientLibApi.UsersApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersCreateTimesheetUser**](UsersApi.md#userscreatetimesheetuser) | **PUT** /api/Users/CreateTimesheetUser | Create a user in your organisation
[**UsersGetTimesheetUser**](UsersApi.md#usersgettimesheetuser) | **GET** /api/Users/GetTimesheetUser | Get a particular user in your organisation
[**UsersGetTimesheetUsers**](UsersApi.md#usersgettimesheetusers) | **GET** /api/Users/GetTimesheetUsers | Get users for your organisation
[**UsersUpdateTimesheetUser**](UsersApi.md#usersupdatetimesheetuser) | **POST** /api/Users/UpdateTimesheetUser | Update a user


<a name="userscreatetimesheetuser"></a>
# **UsersCreateTimesheetUser**
> CsApiApiResponseInsertUserResponse UsersCreateTimesheetUser (CsApiInsertUserRequest request, string xChronosheetsAuth)

Create a user in your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersCreateTimesheetUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var request = new CsApiInsertUserRequest(); // CsApiInsertUserRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a user in your organisation
                CsApiApiResponseInsertUserResponse result = apiInstance.UsersCreateTimesheetUser(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCreateTimesheetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertUserRequest**](CsApiInsertUserRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInsertUserResponse**](CsApiApiResponseInsertUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgettimesheetuser"></a>
# **UsersGetTimesheetUser**
> CsApiApiResponseUserForManagement UsersGetTimesheetUser (int? userId, string xChronosheetsAuth)

Get a particular user in your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersGetTimesheetUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var userId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular user in your organisation
                CsApiApiResponseUserForManagement result = apiInstance.UsersGetTimesheetUser(userId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetTimesheetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseUserForManagement**](CsApiApiResponseUserForManagement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersgettimesheetusers"></a>
# **UsersGetTimesheetUsers**
> CsApiApiResponseListUserForManagement UsersGetTimesheetUsers (string xChronosheetsAuth)

Get users for your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersGetTimesheetUsersExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get users for your organisation
                CsApiApiResponseListUserForManagement result = apiInstance.UsersGetTimesheetUsers(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetTimesheetUsers: " + e.Message );
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

[**CsApiApiResponseListUserForManagement**](CsApiApiResponseListUserForManagement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersupdatetimesheetuser"></a>
# **UsersUpdateTimesheetUser**
> CsApiApiResponseUpdateUserResponse UsersUpdateTimesheetUser (CsApiUpdateUserRequest request, string xChronosheetsAuth)

Update a user

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersUpdateTimesheetUserExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var request = new CsApiUpdateUserRequest(); // CsApiUpdateUserRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a user
                CsApiApiResponseUpdateUserResponse result = apiInstance.UsersUpdateTimesheetUser(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUpdateTimesheetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiUpdateUserRequest**](CsApiUpdateUserRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseUpdateUserResponse**](CsApiApiResponseUpdateUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

