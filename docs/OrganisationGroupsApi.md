# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupsCreateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupscreateorganisationgroup) | **POST** /api/OrganisationGroups/CreateOrganisationGroup | Create an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.
[**OrganisationGroupsDeleteOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsdeleteorganisationgroup) | **DELETE** /api/OrganisationGroups/DeleteOrganisationGroup | 
[**OrganisationGroupsGetOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroup) | **GET** /api/OrganisationGroups/GetOrganisationGroup | Get a particular organisation group.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroups**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroups) | **GET** /api/OrganisationGroups/GetOrganisationGroups | Get a collection of organisation groups that are under your organisation.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroupsForJob**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforjob) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForJob | Get org groups for a particular job.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroupsForVehicle**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforvehicle) | **GET** /api/OrganisationGroups/GetOrganisationGroupsForVehicle | Get org groups for a particular vehicle.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageFleet&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsUpdateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsupdateorganisationgroup) | **PUT** /api/OrganisationGroups/UpdateOrganisationGroup | Update an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.


<a name="organisationgroupscreateorganisationgroup"></a>
# **OrganisationGroupsCreateOrganisationGroup**
> CSApiResponseInt32 OrganisationGroupsCreateOrganisationGroup (CSInsertOrganisationGroupRequest request, string xChronosheetsAuth)

Create an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

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
            var request = new CSInsertOrganisationGroupRequest(); // CSInsertOrganisationGroupRequest | An Insert OrganisationGroup Request object containing values for the new OrganisationGroup to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                CSApiResponseInt32 result = apiInstance.OrganisationGroupsCreateOrganisationGroup(request, xChronosheetsAuth);
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
 **request** | [**CSInsertOrganisationGroupRequest**](CSInsertOrganisationGroupRequest.md)| An Insert OrganisationGroup Request object containing values for the new OrganisationGroup to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsdeleteorganisationgroup"></a>
# **OrganisationGroupsDeleteOrganisationGroup**
> CSApiResponseBoolean OrganisationGroupsDeleteOrganisationGroup (int? organisationGroupId, string xChronosheetsAuth)



### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsDeleteOrganisationGroupExample
    {
        public void main()
        {
            var apiInstance = new OrganisationGroupsApi();
            var organisationGroupId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                CSApiResponseBoolean result = apiInstance.OrganisationGroupsDeleteOrganisationGroup(organisationGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsDeleteOrganisationGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organisationGroupId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroup"></a>
# **OrganisationGroupsGetOrganisationGroup**
> CSApiResponseOrganisationGroup OrganisationGroupsGetOrganisationGroup (int? organisationGroupId, string xChronosheetsAuth)

Get a particular organisation group.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

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
            var organisationGroupId = 56;  // int? | The ID of the OrganisationGroup you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular organisation group.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                CSApiResponseOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroup(organisationGroupId, xChronosheetsAuth);
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
 **organisationGroupId** | **int?**| The ID of the OrganisationGroup you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseOrganisationGroup**](CSApiResponseOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroups"></a>
# **OrganisationGroupsGetOrganisationGroups**
> CSApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroups (string xChronosheetsAuth)

Get a collection of organisation groups that are under your organisation.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

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
                // Get a collection of organisation groups that are under your organisation.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                CSApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroups(xChronosheetsAuth);
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

[**CSApiResponseListOrganisationGroup**](CSApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroupsforjob"></a>
# **OrganisationGroupsGetOrganisationGroupsForJob**
> CSApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForJob (int? jobId, string xChronosheetsAuth)

Get org groups for a particular job.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

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
                // Get org groups for a particular job.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                CSApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForJob(jobId, xChronosheetsAuth);
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

[**CSApiResponseListOrganisationGroup**](CSApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsgetorganisationgroupsforvehicle"></a>
# **OrganisationGroupsGetOrganisationGroupsForVehicle**
> CSApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForVehicle (int? vehicleId, string xChronosheetsAuth)

Get org groups for a particular vehicle.    Requires the 'ManageOrganisationGroups', 'ManageFleet' or 'ManageOrganisationUsers' permissions.

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
                // Get org groups for a particular vehicle.    Requires the 'ManageOrganisationGroups', 'ManageFleet' or 'ManageOrganisationUsers' permissions.
                CSApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForVehicle(vehicleId, xChronosheetsAuth);
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

[**CSApiResponseListOrganisationGroup**](CSApiResponseListOrganisationGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationgroupsupdateorganisationgroup"></a>
# **OrganisationGroupsUpdateOrganisationGroup**
> CSApiResponseBoolean OrganisationGroupsUpdateOrganisationGroup (CSSaveOrganisationGroupRequest request, string xChronosheetsAuth)

Update an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

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
            var request = new CSSaveOrganisationGroupRequest(); // CSSaveOrganisationGroupRequest | A Save OrganisationGroup Request object containing updated fields.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                CSApiResponseBoolean result = apiInstance.OrganisationGroupsUpdateOrganisationGroup(request, xChronosheetsAuth);
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
 **request** | [**CSSaveOrganisationGroupRequest**](CSSaveOrganisationGroupRequest.md)| A Save OrganisationGroup Request object containing updated fields.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

