# ChronoSheetsAPI.ChronoSheetsClientLibApi.TasksApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TasksCreateTask**](TasksApi.md#taskscreatetask) | **POST** /api/Tasks/CreateTask | Create a task.    Requires the &#39;ManageJobsAndTask&#39; permission.
[**TasksDeleteTask**](TasksApi.md#tasksdeletetask) | **DELETE** /api/Tasks/DeleteTask | Delete a task.    Requires the &#39;ManageJobsAndTask&#39; permission.
[**TasksGetTaskById**](TasksApi.md#tasksgettaskbyid) | **GET** /api/Tasks/GetTaskById | Get a particular task by Id.   Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
[**TasksGetTasks**](TasksApi.md#tasksgettasks) | **GET** /api/Tasks/GetTasks | Get tasks in your organisation.   Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
[**TasksGetTasksForJob**](TasksApi.md#tasksgettasksforjob) | **GET** /api/Tasks/GetTasksForJob | Get a collection of tasks for a particular Job, specified by JobId.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
[**TasksUpdateTask**](TasksApi.md#tasksupdatetask) | **PUT** /api/Tasks/UpdateTask | Update a task.    Requires the &#39;ManageJobsAndTask&#39; permission.


<a name="taskscreatetask"></a>
# **TasksCreateTask**
> CSApiResponseInt32 TasksCreateTask (CSInsertTaskRequest request, string xChronosheetsAuth)

Create a task.    Requires the 'ManageJobsAndTask' permission.

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
            var request = new CSInsertTaskRequest(); // CSInsertTaskRequest | An Insert Task Request object containing values for the new Task to create
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a task.    Requires the 'ManageJobsAndTask' permission.
                CSApiResponseInt32 result = apiInstance.TasksCreateTask(request, xChronosheetsAuth);
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
 **request** | [**CSInsertTaskRequest**](CSInsertTaskRequest.md)| An Insert Task Request object containing values for the new Task to create | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksdeletetask"></a>
# **TasksDeleteTask**
> CSApiResponseBoolean TasksDeleteTask (int? taskId, string xChronosheetsAuth)

Delete a task.    Requires the 'ManageJobsAndTask' permission.

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
            var taskId = 56;  // int? | The ID of the Task you want to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a task.    Requires the 'ManageJobsAndTask' permission.
                CSApiResponseBoolean result = apiInstance.TasksDeleteTask(taskId, xChronosheetsAuth);
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
 **taskId** | **int?**| The ID of the Task you want to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettaskbyid"></a>
# **TasksGetTaskById**
> CSApiResponseTimesheetTask TasksGetTaskById (int? taskId, string xChronosheetsAuth)

Get a particular task by Id.   Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.

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
            var taskId = 56;  // int? | The ID of the TimesheetTask you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular task by Id.   Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.
                CSApiResponseTimesheetTask result = apiInstance.TasksGetTaskById(taskId, xChronosheetsAuth);
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
 **taskId** | **int?**| The ID of the TimesheetTask you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseTimesheetTask**](CSApiResponseTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettasks"></a>
# **TasksGetTasks**
> CSApiResponseListTimesheetTask TasksGetTasks (string xChronosheetsAuth)

Get tasks in your organisation.   Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.

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
                // Get tasks in your organisation.   Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.
                CSApiResponseListTimesheetTask result = apiInstance.TasksGetTasks(xChronosheetsAuth);
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

[**CSApiResponseListTimesheetTask**](CSApiResponseListTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksgettasksforjob"></a>
# **TasksGetTasksForJob**
> CSApiResponseListTimesheetTask TasksGetTasksForJob (int? jobId, string xChronosheetsAuth)

Get a collection of tasks for a particular Job, specified by JobId.    Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.

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
                // Get a collection of tasks for a particular Job, specified by JobId.    Requires the 'SubmitTimesheets' or 'ManageJobsAndTask' permissions.
                CSApiResponseListTimesheetTask result = apiInstance.TasksGetTasksForJob(jobId, xChronosheetsAuth);
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

[**CSApiResponseListTimesheetTask**](CSApiResponseListTimesheetTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tasksupdatetask"></a>
# **TasksUpdateTask**
> CSApiResponseBoolean TasksUpdateTask (CSUpdateTaskRequest request, string xChronosheetsAuth)

Update a task.    Requires the 'ManageJobsAndTask' permission.

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
            var request = new CSUpdateTaskRequest(); // CSUpdateTaskRequest | An Update Task Request object containing updated fields.  Make sure to specify the Task Id in the request object so that ChronoSheets knows which Task to update
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a task.    Requires the 'ManageJobsAndTask' permission.
                CSApiResponseBoolean result = apiInstance.TasksUpdateTask(request, xChronosheetsAuth);
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
 **request** | [**CSUpdateTaskRequest**](CSUpdateTaskRequest.md)| An Update Task Request object containing updated fields.  Make sure to specify the Task Id in the request object so that ChronoSheets knows which Task to update | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

