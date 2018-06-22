# ChronoSheetsAPI.ChronoSheetsClientLibApi.TasksApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TasksCreateTask**](TasksApi.md#taskscreatetask) | **PUT** /api/Tasks/CreateTask | Create a task
[**TasksDeleteTask**](TasksApi.md#tasksdeletetask) | **DELETE** /api/Tasks/DeleteTask | Delete a task
[**TasksGetTaskById**](TasksApi.md#tasksgettaskbyid) | **GET** /api/Tasks/GetTaskById | Get a particular task by id
[**TasksGetTasks**](TasksApi.md#tasksgettasks) | **GET** /api/Tasks/GetTasks | Get tasks in your organisation
[**TasksGetTasksForJob**](TasksApi.md#tasksgettasksforjob) | **GET** /api/Tasks/GetTasksForJob | Get tasks for a particular job
[**TasksUpdateTask**](TasksApi.md#tasksupdatetask) | **POST** /api/Tasks/UpdateTask | Update a task


<a name="taskscreatetask"></a>
# **TasksCreateTask**
> CsApiApiResponseInt32 TasksCreateTask (CsApiInsertTaskRequest request, string xChronosheetsAuth)

Create a task

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksCreateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var request = new CsApiInsertTaskRequest(); // CsApiInsertTaskRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a task
                CsApiApiResponseInt32 result = apiInstance.TasksCreateTask(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksCreateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertTaskRequest**](CsApiInsertTaskRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksdeletetask"></a>
# **TasksDeleteTask**
> CsApiApiResponseBoolean TasksDeleteTask (int? taskId, string xChronosheetsAuth)

Delete a task

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksDeleteTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a task
                CsApiApiResponseBoolean result = apiInstance.TasksDeleteTask(taskId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksDeleteTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettaskbyid"></a>
# **TasksGetTaskById**
> CsApiApiResponseTimesheetTask TasksGetTaskById (int? taskId, string xChronosheetsAuth)

Get a particular task by id

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksGetTaskByIdExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var taskId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular task by id
                CsApiApiResponseTimesheetTask result = apiInstance.TasksGetTaskById(taskId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTaskById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseTimesheetTask**](CsApiApiResponseTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettasks"></a>
# **TasksGetTasks**
> CsApiApiResponseListTimesheetTask TasksGetTasks (string xChronosheetsAuth)

Get tasks in your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksGetTasksExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get tasks in your organisation
                CsApiApiResponseListTimesheetTask result = apiInstance.TasksGetTasks(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTasks: " + e.Message );
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

[**CsApiApiResponseListTimesheetTask**](CsApiApiResponseListTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettasksforjob"></a>
# **TasksGetTasksForJob**
> CsApiApiResponseListTimesheetTask TasksGetTasksForJob (int? jobId, string xChronosheetsAuth)

Get tasks for a particular job

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksGetTasksForJobExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var jobId = 56;  // int? | The ID of the job
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get tasks for a particular job
                CsApiApiResponseListTimesheetTask result = apiInstance.TasksGetTasksForJob(jobId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksGetTasksForJob: " + e.Message );
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

[**CsApiApiResponseListTimesheetTask**](CsApiApiResponseListTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksupdatetask"></a>
# **TasksUpdateTask**
> CsApiApiResponseBoolean TasksUpdateTask (CsApiUpdateTaskRequest request, string xChronosheetsAuth)

Update a task

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TasksUpdateTaskExample
    {
        public void main()
        {
            var apiInstance = new TasksApi();
            var request = new CsApiUpdateTaskRequest(); // CsApiUpdateTaskRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a task
                CsApiApiResponseBoolean result = apiInstance.TasksUpdateTask(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.TasksUpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiUpdateTaskRequest**](CsApiUpdateTaskRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

