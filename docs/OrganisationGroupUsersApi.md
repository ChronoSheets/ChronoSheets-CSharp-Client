# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupUsersApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupUsersGetOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersgetorganisationgroupusers) | **GET** /api/OrganisationGroupUsers/GetOrganisationGroupUsers | Get a collection of organisation group users that belong to an organisation group
[**OrganisationGroupUsersUpdateOrganisationGroupUsers**](OrganisationGroupUsersApi.md#organisationgroupusersupdateorganisationgroupusers) | **POST** /api/OrganisationGroupUsers/UpdateOrganisationGroupUsers | Set the users who belong to an organisation group


<a name="organisationgroupusersgetorganisationgroupusers"></a>
# **OrganisationGroupUsersGetOrganisationGroupUsers**
> CsApiApiResponseListUserForManagement OrganisationGroupUsersGetOrganisationGroupUsers (int? orgGroupId, string xChronosheetsAuth)

Get a collection of organisation group users that belong to an organisation group

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
            var orgGroupId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of organisation group users that belong to an organisation group
                CsApiApiResponseListUserForManagement result = apiInstance.OrganisationGroupUsersGetOrganisationGroupUsers(orgGroupId, xChronosheetsAuth);
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
 **orgGroupId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListUserForManagement**](CsApiApiResponseListUserForManagement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupusersupdateorganisationgroupusers"></a>
# **OrganisationGroupUsersUpdateOrganisationGroupUsers**
> CsApiApiResponseBoolean OrganisationGroupUsersUpdateOrganisationGroupUsers (CsApiSetOrganisationGroupUsersRequest request, string xChronosheetsAuth)

Set the users who belong to an organisation group

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
            var request = new CsApiSetOrganisationGroupUsersRequest(); // CsApiSetOrganisationGroupUsersRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Set the users who belong to an organisation group
                CsApiApiResponseBoolean result = apiInstance.OrganisationGroupUsersUpdateOrganisationGroupUsers(request, xChronosheetsAuth);
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
 **request** | [**CsApiSetOrganisationGroupUsersRequest**](CsApiSetOrganisationGroupUsersRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

