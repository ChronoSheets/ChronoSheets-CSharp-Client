# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupUsersApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupUsersGetOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersgetorganisationgroupusers) | **GET** /api/OrganisationGroupUsers/GetOrganisationGroupUsers | Get a collection of organisation group users that belong to an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupUsersUpdateOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersupdateorganisationgroupusers) | **POST** /api/OrganisationGroupUsers/UpdateOrganisationGroupUsers | Set the users who belong to an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.


<a name="organisationgroupusersgetorganisationgroupusers"></a>
# **OrganisationGroupUsersGetOrganisationGroupUsers**
> CSApiResponseListUserForManagement OrganisationGroupUsersGetOrganisationGroupUsers (int? orgGroupId, string xChronosheetsAuth)

Get a collection of organisation group users that belong to an organisation group.    Requires the 'ManageOrganisationGroups' or 'ManageOrganisationUsers' permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupUsersGetOrganisationGroupUsersExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupUsersApi();
            var orgGroupId = 56;  // int? | An OrganisatioGroup Id
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of organisation group users that belong to an organisation group.    Requires the 'ManageOrganisationGroups' or 'ManageOrganisationUsers' permissions.
                CSApiResponseListUserForManagement result = apiInstance.OrganisationGroupUsersGetOrganisationGroupUsers(orgGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupUsersApi.OrganisationGroupUsersGetOrganisationGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgGroupId** | **int?**| An OrganisatioGroup Id | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseListUserForManagement**](CSApiResponseListUserForManagement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupusersupdateorganisationgroupusers"></a>
# **OrganisationGroupUsersUpdateOrganisationGroupUsers**
> CSApiResponseBoolean OrganisationGroupUsersUpdateOrganisationGroupUsers (CSSetOrganisationGroupUsersRequest request, string xChronosheetsAuth)

Set the users who belong to an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupUsersUpdateOrganisationGroupUsersExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupUsersApi();
            var request = new CSSetOrganisationGroupUsersRequest(); // CSSetOrganisationGroupUsersRequest | A request object specifying which users belong to an organisation group.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Set the users who belong to an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                CSApiResponseBoolean result = apiInstance.OrganisationGroupUsersUpdateOrganisationGroupUsers(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupUsersApi.OrganisationGroupUsersUpdateOrganisationGroupUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSSetOrganisationGroupUsersRequest**](CSSetOrganisationGroupUsersRequest.md)| A request object specifying which users belong to an organisation group.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

