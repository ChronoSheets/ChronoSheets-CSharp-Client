# ChronoSheetsAPI.ChronoSheetsClientLibApi.ProjectsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ProjectsCreateProject**](ProjectsApi.md#projectscreateproject) | **PUT** /api/Projects/CreateProject | Create a project
[**ProjectsGetProjectById**](ProjectsApi.md#projectsgetprojectbyid) | **GET** /api/Projects/GetProjectById | Get project by Id
[**ProjectsGetProjectsForClient**](ProjectsApi.md#projectsgetprojectsforclient) | **GET** /api/Projects/GetProjectsForClient | Get projects for a particular client
[**ProjectsUpdateProject**](ProjectsApi.md#projectsupdateproject) | **POST** /api/Projects/UpdateProject | Update a project


<a name="projectscreateproject"></a>
# **ProjectsCreateProject**
> CsApiApiResponseInt32 ProjectsCreateProject (CsApiInsertProjectRequest request, string xChronosheetsAuth)

Create a project

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ProjectsCreateProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var request = new CsApiInsertProjectRequest(); // CsApiInsertProjectRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a project
                CsApiApiResponseInt32 result = apiInstance.ProjectsCreateProject(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsCreateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertProjectRequest**](CsApiInsertProjectRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsgetprojectbyid"></a>
# **ProjectsGetProjectById**
> CsApiApiResponseProject ProjectsGetProjectById (int? projectId, string xChronosheetsAuth)

Get project by Id

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ProjectsGetProjectByIdExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var projectId = 56;  // int? | The ID of the project
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get project by Id
                CsApiApiResponseProject result = apiInstance.ProjectsGetProjectById(projectId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetProjectById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **projectId** | **int?**| The ID of the project | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseProject**](CsApiApiResponseProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsgetprojectsforclient"></a>
# **ProjectsGetProjectsForClient**
> CsApiApiResponseListProject ProjectsGetProjectsForClient (int? clientId, string xChronosheetsAuth)

Get projects for a particular client

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ProjectsGetProjectsForClientExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var clientId = 56;  // int? | The ID of the client
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get projects for a particular client
                CsApiApiResponseListProject result = apiInstance.ProjectsGetProjectsForClient(clientId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsGetProjectsForClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**| The ID of the client | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseListProject**](CsApiApiResponseListProject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="projectsupdateproject"></a>
# **ProjectsUpdateProject**
> CsApiApiResponseBoolean ProjectsUpdateProject (CsApiUpdateProjectRequest request, string xChronosheetsAuth)

Update a project

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ProjectsUpdateProjectExample
    {
        public void main()
        {
            var apiInstance = new ProjectsApi();
            var request = new CsApiUpdateProjectRequest(); // CsApiUpdateProjectRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a project
                CsApiApiResponseBoolean result = apiInstance.ProjectsUpdateProject(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProjectsApi.ProjectsUpdateProject: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiUpdateProjectRequest**](CsApiUpdateProjectRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

