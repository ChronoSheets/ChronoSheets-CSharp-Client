# ChronoSheetsAPI.ChronoSheetsClientLibApi.UsersApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersCreateTimesheetUser**](UsersApi.md#userscreatetimesheetuser) | **POST** /Users/CreateTimesheetUser | Create a user account in your organisation.  Requires the &#39;ManageOrganisationUsers&#39; permission.
[**UsersGetTimesheetUser**](UsersApi.md#usersgettimesheetuser) | **GET** /Users/GetTimesheetUser | Get a particular user in your organisation.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationGroups&#39; permissions.
[**UsersGetTimesheetUsers**](UsersApi.md#usersgettimesheetusers) | **GET** /Users/GetTimesheetUsers | Get users accounts in your organisation.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationGroups&#39; permissions.
[**UsersUpdateTimesheetUser**](UsersApi.md#usersupdatetimesheetuser) | **PUT** /Users/UpdateTimesheetUser | Update a user account.  Requires the &#39;ManageOrganisationUsers&#39; permission.



## UsersCreateTimesheetUser

> ApiResponseInsertUserResponse UsersCreateTimesheetUser (string xChronosheetsAuth, InsertUserRequest request)

Create a user account in your organisation.  Requires the 'ManageOrganisationUsers' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersCreateTimesheetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UsersApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new InsertUserRequest(); // InsertUserRequest | An Insert User Request object containing values for the new User to create

            try
            {
                // Create a user account in your organisation.  Requires the 'ManageOrganisationUsers' permission.
                ApiResponseInsertUserResponse result = apiInstance.UsersCreateTimesheetUser(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersCreateTimesheetUser: " + e.Message );
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
 **request** | [**InsertUserRequest**](InsertUserRequest.md)| An Insert User Request object containing values for the new User to create | 

### Return type

[**ApiResponseInsertUserResponse**](ApiResponseInsertUserResponse.md)

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


## UsersGetTimesheetUser

> ApiResponseUserForManagement UsersGetTimesheetUser (int userId, string xChronosheetsAuth)

Get a particular user in your organisation.  Requires the 'ManageOrganisationUsers' or 'ManageOrganisationGroups' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersGetTimesheetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UsersApi(Configuration.Default);
            var userId = 56;  // int | The User ID of the UserForManagement you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular user in your organisation.  Requires the 'ManageOrganisationUsers' or 'ManageOrganisationGroups' permissions.
                ApiResponseUserForManagement result = apiInstance.UsersGetTimesheetUser(userId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetTimesheetUser: " + e.Message );
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
 **userId** | **int**| The User ID of the UserForManagement you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseUserForManagement**](ApiResponseUserForManagement.md)

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


## UsersGetTimesheetUsers

> ApiResponseListUserForManagement UsersGetTimesheetUsers (string xChronosheetsAuth)

Get users accounts in your organisation.  Requires the 'ManageOrganisationUsers' or 'ManageOrganisationGroups' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersGetTimesheetUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UsersApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get users accounts in your organisation.  Requires the 'ManageOrganisationUsers' or 'ManageOrganisationGroups' permissions.
                ApiResponseListUserForManagement result = apiInstance.UsersGetTimesheetUsers(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGetTimesheetUsers: " + e.Message );
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

[**ApiResponseListUserForManagement**](ApiResponseListUserForManagement.md)

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


## UsersUpdateTimesheetUser

> ApiResponseUpdateUserResponse UsersUpdateTimesheetUser (string xChronosheetsAuth, UpdateUserRequest request)

Update a user account.  Requires the 'ManageOrganisationUsers' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class UsersUpdateTimesheetUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new UsersApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new UpdateUserRequest(); // UpdateUserRequest | A Update User Request object containing updated fields.  Make sure to specify the User Id in the request object so that ChronoSheets knows which User to update

            try
            {
                // Update a user account.  Requires the 'ManageOrganisationUsers' permission.
                ApiResponseUpdateUserResponse result = apiInstance.UsersUpdateTimesheetUser(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UsersApi.UsersUpdateTimesheetUser: " + e.Message );
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
 **request** | [**UpdateUserRequest**](UpdateUserRequest.md)| A Update User Request object containing updated fields.  Make sure to specify the User Id in the request object so that ChronoSheets knows which User to update | 

### Return type

[**ApiResponseUpdateUserResponse**](ApiResponseUpdateUserResponse.md)

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

