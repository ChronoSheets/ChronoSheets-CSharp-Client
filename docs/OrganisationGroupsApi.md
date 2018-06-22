# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupsCreateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupscreateorganisationgroup) | **PUT** /api/OrganisationGroups/CreateOrganisationGroup | Create an organisation group
[**OrganisationGroupsGetOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroup) | **GET** /api/OrganisationGroups/GetOrganisationGroup | Get a particular organisation group
[**OrganisationGroupsGetOrganisationGroups**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroups) | **GET** /api/OrganisationGroups/GetOrganisationGroups | Get a collection of organisation groups that are under your organisation
[**OrganisationGroupsGetOrganisationGroupsForJob**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforjob) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForJob | Get org groups for a particular job
[**OrganisationGroupsGetOrganisationGroupsForVehicle**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforvehicle) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForVehicle | Get org groups for a particular vehicle
[**OrganisationGroupsUpdateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsupdateorganisationgroup) | **POST** /api/OrganisationGroups/UpdateOrganisationGroup | Update an organisation group


<a name="organisationgroupscreateorganisationgroup"></a>
# **OrganisationGroupsCreateOrganisationGroup**
> CsApiApiResponseInt32 OrganisationGroupsCreateOrganisationGroup (CsApiInsertOrganisationGroupRequest request, string xChronosheetsAuth)

Create an organisation group

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsCreateOrganisationGroupExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var request = new CsApiInsertOrganisationGroupRequest(); // CsApiInsertOrganisationGroupRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create an organisation group
                CsApiApiResponseInt32 result = apiInstance.OrganisationGroupsCreateOrganisationGroup(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsCreateOrganisationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertOrganisationGroupRequest**](CsApiInsertOrganisationGroupRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroup"></a>
# **OrganisationGroupsGetOrganisationGroup**
> CsApiApiResponseOrganisationGroup OrganisationGroupsGetOrganisationGroup (int? organisationGroupId, string xChronosheetsAuth)

Get a particular organisation group

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var organisationGroupId = 56;  // int? | The ID of the organisation group you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular organisation group
                CsApiApiResponseOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroup(organisationGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organisationGroupId** | **int?**| The ID of the organisation group you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseOrganisationGroup**](CsApiApiResponseOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroups"></a>
# **OrganisationGroupsGetOrganisationGroups**
> CsApiApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroups (string xChronosheetsAuth)

Get a collection of organisation groups that are under your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of organisation groups that are under your organisation
                CsApiApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroups(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroups: " + e.Message );
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

[**CsApiApiResponseListOrganisationGroup**](CsApiApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroupsforjob"></a>
# **OrganisationGroupsGetOrganisationGroupsForJob**
> CsApiApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForJob (int? jobId, string xChronosheetsAuth)

Get org groups for a particular job

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsForJobExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var jobId = 56;  // int? | The ID of the job
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get org groups for a particular job
                CsApiApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForJob(jobId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroupsForJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **int?**| The ID of the job | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListOrganisationGroup**](CsApiApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroupsforvehicle"></a>
# **OrganisationGroupsGetOrganisationGroupsForVehicle**
> CsApiApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForVehicle (int? vehicleId, string xChronosheetsAuth)

Get org groups for a particular vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsForVehicleExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var vehicleId = 56;  // int? | The ID of the vehicle
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get org groups for a particular vehicle
                CsApiApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForVehicle(vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroupsForVehicle: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vehicleId** | **int?**| The ID of the vehicle | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListOrganisationGroup**](CsApiApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsupdateorganisationgroup"></a>
# **OrganisationGroupsUpdateOrganisationGroup**
> CsApiApiResponseBoolean OrganisationGroupsUpdateOrganisationGroup (CsApiSaveOrganisationGroupRequest request, string xChronosheetsAuth)

Update an organisation group

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsUpdateOrganisationGroupExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var request = new CsApiSaveOrganisationGroupRequest(); // CsApiSaveOrganisationGroupRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update an organisation group
                CsApiApiResponseBoolean result = apiInstance.OrganisationGroupsUpdateOrganisationGroup(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsUpdateOrganisationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiSaveOrganisationGroupRequest**](CsApiSaveOrganisationGroupRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

