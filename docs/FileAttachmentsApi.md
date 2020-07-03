# ChronoSheetsAPI.ChronoSheetsClientLibApi.FileAttachmentsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FileAttachmentsDeleteTimesheetFileAttachment**](FileAttachmentsApi.md#fileattachmentsdeletetimesheetfileattachment) | **DELETE** /FileAttachments/DeleteTimesheetFileAttachment | Delete a particular timesheet file attachment  Requires the &#39;SubmitTimesheets&#39; permission.
[**FileAttachmentsGetFileAttachmentById**](FileAttachmentsApi.md#fileattachmentsgetfileattachmentbyid) | **GET** /FileAttachments/GetFileAttachmentById | Get a particular file attachment by ID.  User must own the file attachment for access.
[**FileAttachmentsGetMyFileAttachments**](FileAttachmentsApi.md#fileattachmentsgetmyfileattachments) | **GET** /FileAttachments/GetMyFileAttachments | Get my file attachments.  Get files you&#39;ve attached to timesheets.



## FileAttachmentsDeleteTimesheetFileAttachment

> ApiResponseBoolean FileAttachmentsDeleteTimesheetFileAttachment (int fileAttachmentId, string xChronosheetsAuth)

Delete a particular timesheet file attachment  Requires the 'SubmitTimesheets' permission.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsDeleteTimesheetFileAttachmentExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FileAttachmentsApi(Configuration.Default);
            var fileAttachmentId = 56;  // int | The Id of the file attachment to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a particular timesheet file attachment  Requires the 'SubmitTimesheets' permission.
                ApiResponseBoolean result = apiInstance.FileAttachmentsDeleteTimesheetFileAttachment(fileAttachmentId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsDeleteTimesheetFileAttachment: " + e.Message );
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
 **fileAttachmentId** | **int**| The Id of the file attachment to delete | 
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


## FileAttachmentsGetFileAttachmentById

> ApiResponseTimesheetFileAttachment FileAttachmentsGetFileAttachmentById (int fileAttachmentId, string xChronosheetsAuth)

Get a particular file attachment by ID.  User must own the file attachment for access.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsGetFileAttachmentByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FileAttachmentsApi(Configuration.Default);
            var fileAttachmentId = 56;  // int | The ID of the file attachment
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular file attachment by ID.  User must own the file attachment for access.
                ApiResponseTimesheetFileAttachment result = apiInstance.FileAttachmentsGetFileAttachmentById(fileAttachmentId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsGetFileAttachmentById: " + e.Message );
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
 **fileAttachmentId** | **int**| The ID of the file attachment | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**ApiResponseTimesheetFileAttachment**](ApiResponseTimesheetFileAttachment.md)

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


## FileAttachmentsGetMyFileAttachments

> ApiResponseForPaginatedListTimesheetFileAttachment FileAttachmentsGetMyFileAttachments (DateTime startDate, DateTime endDate, string xChronosheetsAuth, int? skip = null, int? take = null)

Get my file attachments.  Get files you've attached to timesheets.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsGetMyFileAttachmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.chronosheets.com";
            var apiInstance = new FileAttachmentsApi(Configuration.Default);
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime | The Start date of the date range.  File attachments after this date will be obtained.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime | The End date of the date range.  File attachments before this date will be obtained.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many File attachments (optional) 
            var take = 56;  // int? | Take this many File attachments (optional) 

            try
            {
                // Get my file attachments.  Get files you've attached to timesheets.
                ApiResponseForPaginatedListTimesheetFileAttachment result = apiInstance.FileAttachmentsGetMyFileAttachments(startDate, endDate, xChronosheetsAuth, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsGetMyFileAttachments: " + e.Message );
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
 **startDate** | **DateTime**| The Start date of the date range.  File attachments after this date will be obtained. | 
 **endDate** | **DateTime**| The End date of the date range.  File attachments before this date will be obtained. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many File attachments | [optional] 
 **take** | **int?**| Take this many File attachments | [optional] 

### Return type

[**ApiResponseForPaginatedListTimesheetFileAttachment**](ApiResponseForPaginatedListTimesheetFileAttachment.md)

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

