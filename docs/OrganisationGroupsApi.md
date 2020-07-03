# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationGroupsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGroupsCreateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupscreateorganisationgroup) | **POST** /OrganisationGroups/CreateOrganisationGroup | Create an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.
[**OrganisationGroupsDeleteOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsdeleteorganisationgroup) | **DELETE** /OrganisationGroups/DeleteOrganisationGroup | 
[**OrganisationGroupsGetOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroup) | **GET** /OrganisationGroups/GetOrganisationGroup | Get a particular organisation group.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroups**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroups) | **GET** /OrganisationGroups/GetOrganisationGroups | Get a collection of organisation groups that are under your organisation.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroupsForJob**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforjob) | **GET** /OrganisationGroups/GetOrganisationGroupsForJob | Get org groups for a particular job.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageJobsAndTask&#39;, &#39;ManageClientsAndProjects&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsGetOrganisationGroupsForVehicle**](OrganisationGroupsApi.md#organisationgroupsgetorganisationgroupsforvehicle) | **GET** /OrganisationGroups/GetOrganisationGroupsForVehicle | Get org groups for a particular vehicle.    Requires the &#39;ManageOrganisationGroups&#39;, &#39;ManageFleet&#39; or &#39;ManageOrganisationUsers&#39; permissions.
[**OrganisationGroupsUpdateOrganisationGroup**](OrganisationGroupsApi.md#organisationgroupsupdateorganisationgroup) | **PUT** /OrganisationGroups/UpdateOrganisationGroup | Update an organisation group.    Requires the &#39;ManageOrganisationGroups&#39; permissions.



## OrganisationGroupsCreateOrganisationGroup

> ApiResponseInt32 OrganisationGroupsCreateOrganisationGroup (string xChronosheetsAuth, InsertOrganisationGroupRequest request)

Create an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsCreateOrganisationGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new InsertOrganisationGroupRequest(); // InsertOrganisationGroupRequest | An Insert OrganisationGroup Request object containing values for the new OrganisationGroup to create

            try
            {
                // Create an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                ApiResponseInt32 result = apiInstance.OrganisationGroupsCreateOrganisationGroup(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsCreateOrganisationGroup: " + e.Message );
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
 **request** | [**InsertOrganisationGroupRequest**](InsertOrganisationGroupRequest.md)| An Insert OrganisationGroup Request object containing values for the new OrganisationGroup to create | 

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


## OrganisationGroupsDeleteOrganisationGroup

> ApiResponseBoolean OrganisationGroupsDeleteOrganisationGroup (int organisationGroupId, string xChronosheetsAuth)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsDeleteOrganisationGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var organisationGroupId = 56;  // int | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                ApiResponseBoolean result = apiInstance.OrganisationGroupsDeleteOrganisationGroup(organisationGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsDeleteOrganisationGroup: " + e.Message );
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
 **organisationGroupId** | **int**|  | 
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


## OrganisationGroupsGetOrganisationGroup

> ApiResponseOrganisationGroup OrganisationGroupsGetOrganisationGroup (int organisationGroupId, string xChronosheetsAuth)

Get a particular organisation group.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var organisationGroupId = 56;  // int | The ID of the OrganisationGroup you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular organisation group.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                ApiResponseOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroup(organisationGroupId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroup: " + e.Message );
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
 **organisationGroupId** | **int**| The ID of the OrganisationGroup you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseOrganisationGroup**](ApiResponseOrganisationGroup.md)

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


## OrganisationGroupsGetOrganisationGroups

> ApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroups (string xChronosheetsAuth)

Get a collection of organisation groups that are under your organisation.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of organisation groups that are under your organisation.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                ApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroups(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroups: " + e.Message );
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

[**ApiResponseListOrganisationGroup**](ApiResponseListOrganisationGroup.md)

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


## OrganisationGroupsGetOrganisationGroupsForJob

> ApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForJob (int jobId, string xChronosheetsAuth)

Get org groups for a particular job.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsForJobExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var jobId = 56;  // int | The ID of the job
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get org groups for a particular job.    Requires the 'ManageOrganisationGroups', 'ManageJobsAndTask', 'ManageClientsAndProjects' or 'ManageOrganisationUsers' permissions.
                ApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForJob(jobId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroupsForJob: " + e.Message );
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
 **jobId** | **int**| The ID of the job | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseListOrganisationGroup**](ApiResponseListOrganisationGroup.md)

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


## OrganisationGroupsGetOrganisationGroupsForVehicle

> ApiResponseListOrganisationGroup OrganisationGroupsGetOrganisationGroupsForVehicle (int vehicleId, string xChronosheetsAuth)

Get org groups for a particular vehicle.    Requires the 'ManageOrganisationGroups', 'ManageFleet' or 'ManageOrganisationUsers' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsGetOrganisationGroupsForVehicleExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var vehicleId = 56;  // int | The ID of the vehicle
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get org groups for a particular vehicle.    Requires the 'ManageOrganisationGroups', 'ManageFleet' or 'ManageOrganisationUsers' permissions.
                ApiResponseListOrganisationGroup result = apiInstance.OrganisationGroupsGetOrganisationGroupsForVehicle(vehicleId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsGetOrganisationGroupsForVehicle: " + e.Message );
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
 **vehicleId** | **int**| The ID of the vehicle | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseListOrganisationGroup**](ApiResponseListOrganisationGroup.md)

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


## OrganisationGroupsUpdateOrganisationGroup

> ApiResponseBoolean OrganisationGroupsUpdateOrganisationGroup (string xChronosheetsAuth, SaveOrganisationGroupRequest request)

Update an organisation group.    Requires the 'ManageOrganisationGroups' permissions.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGroupsUpdateOrganisationGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new OrganisationGroupsApi(Configuration.Default);
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var request = new SaveOrganisationGroupRequest(); // SaveOrganisationGroupRequest | A Save OrganisationGroup Request object containing updated fields.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update

            try
            {
                // Update an organisation group.    Requires the 'ManageOrganisationGroups' permissions.
                ApiResponseBoolean result = apiInstance.OrganisationGroupsUpdateOrganisationGroup(xChronosheetsAuth, request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OrganisationGroupsApi.OrganisationGroupsUpdateOrganisationGroup: " + e.Message );
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
 **request** | [**SaveOrganisationGroupRequest**](SaveOrganisationGroupRequest.md)| A Save OrganisationGroup Request object containing updated fields.  Make sure to specify the OrganisationGroup Id in the request object so that ChronoSheets knows which OrganisationGroup to update | 

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

