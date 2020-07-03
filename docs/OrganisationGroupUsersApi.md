# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupUsersApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupUsersGetOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersgetorganisationgroupusers) | **GET** /OrganisationGroupUsers/GetOrganisationGroupUsers | Get a collection of organisation group users that belong to an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupUsersUpdateOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersupdateorganisationgroupusers) | **PUT** /OrganisationGroupUsers/UpdateOrganisationGroupUsers | Set the users who belong to an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.



## OrganisationGroupUsersGetOrganisationGroupUsers

> ApiResponseListUserForManagement OrganisationGroupUsersGetOrganisationGroupUsers (int orgGroupId, string xChronosheetsAuth)

Get a collection of organisation group users that belong to an organisation group.    Requires the 'ManageOrganisationGroups' or 'ManageOrganisationUsers' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupUsersGetOrganisationGroupUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupUsersApi(Configuration.Default);
            var orgGroupId = 56;  // int | An OrganisationGroup Id
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of organisation group users that belong to an organisation group.    Requires the 'ManageOrganisationGroups' or 'ManageOrganisationUsers' permissions.
                ApiResponseListUserForManagement result = apiInstance.OrganisationGroupUsersGetOrganisationGroupUsers(orgGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupUsersApi.OrganisationGroupUsersGetOrganisationGroupUsers: " + e.Message );
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
 **orgGroupId** | **int**| An OrganisationGroup Id | 
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


## OrganisationGroupUsersUpdateOrganisationGroupUsers

> ApiResponseBoolean OrganisationGroupUsersUpdateOrganisationGroupUsers (string xChronosheetsAuth, SetOrganisationGroupUsersRequest request)

Set the users who belong to an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupUsersUpdateOrganisationGroupUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupUsersApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new SetOrganisationGroupUsersRequest(); // SetOrganisationGroupUsersRequest | A request object specifying which users belong to an organisation group.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update. CsvUserIds is a comma separated list of User Ids, e.g. 1,2,3,4

            try
            {
                // Set the users who belong to an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                ApiResponseBoolean result = apiInstance.OrganisationGroupUsersUpdateOrganisationGroupUsers(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupUsersApi.OrganisationGroupUsersUpdateOrganisationGroupUsers: " + e.Message );
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
 **request** | [**SetOrganisationGroupUsersRequest**](SetOrganisationGroupUsersRequest.md)| A request object specifying which users belong to an organisation group.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update. CsvUserIds is a comma separated list of User Ids, e.g. 1,2,3,4 | 

### Return type

[**ApiResponseBoolean**](ApiResponseBoolean.md)

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

