# ChronoSheetsAPI.ChronoSheetsClientLibApi.FileAttachmentsApi

All URIs are relative to *https://api.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FileAttachmentsDeleteTimesheetFileAttachment**](FileAttachmentsApi.md#fileattachmentsdeletetimesheetfileattachment) | **DELETE** /FileAttachments/DeleteTimesheetFileAttachment | Delete a particular timesheet file attachment  Requires the &#39;SubmitTimesheets&#39; permission.
[**FileAttachmentsGetFileAttachmentById**](FileAttachmentsApi.md#fileattachmentsgetfileattachmentbyid) | **GET** /FileAttachments/GetFileAttachmentById | Get a particular file attachment by ID.  User must own the file attachment for access.
[**FileAttachmentsGetMyFileAttachments**](FileAttachmentsApi.md#fileattachmentsgetmyfileattachments) | **GET** /FileAttachments/GetMyFileAttachments | Get my file attachments.  Get files you&#39;ve attached to timesheets.


<a name="fileattachmentsdeletetimesheetfileattachment"></a>
# **FileAttachmentsDeleteTimesheetFileAttachment**
> CSApiResponseBoolean FileAttachmentsDeleteTimesheetFileAttachment (int? fileAttachmentId, string xChronosheetsAuth)

Delete a particular timesheet file attachment  Requires the 'SubmitTimesheets' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsDeleteTimesheetFileAttachmentExample
    {
        public void main()
        {
            var apiInstance = new FileAttachmentsApi();
            var fileAttachmentId = 56;  // int? | The Id of the file attachment to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a particular timesheet file attachment  Requires the 'SubmitTimesheets' permission.
                CSApiResponseBoolean result = apiInstance.FileAttachmentsDeleteTimesheetFileAttachment(fileAttachmentId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsDeleteTimesheetFileAttachment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileAttachmentId** | **int?**| The Id of the file attachment to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileattachmentsgetfileattachmentbyid"></a>
# **FileAttachmentsGetFileAttachmentById**
> CSApiResponseTimesheetFileAttachment FileAttachmentsGetFileAttachmentById (int? fileAttachmentId, string xChronosheetsAuth)

Get a particular file attachment by ID.  User must own the file attachment for access.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsGetFileAttachmentByIdExample
    {
        public void main()
        {
            var apiInstance = new FileAttachmentsApi();
            var fileAttachmentId = 56;  // int? | The ID of the file attachment
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular file attachment by ID.  User must own the file attachment for access.
                CSApiResponseTimesheetFileAttachment result = apiInstance.FileAttachmentsGetFileAttachmentById(fileAttachmentId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsGetFileAttachmentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileAttachmentId** | **int?**| The ID of the file attachment | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseTimesheetFileAttachment**](CSApiResponseTimesheetFileAttachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fileattachmentsgetmyfileattachments"></a>
# **FileAttachmentsGetMyFileAttachments**
> CSApiResponseForPaginatedListTimesheetFileAttachment FileAttachmentsGetMyFileAttachments (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null)

Get my file attachments.  Get files you've attached to timesheets.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class FileAttachmentsGetMyFileAttachmentsExample
    {
        public void main()
        {
            var apiInstance = new FileAttachmentsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The Start date of the date range.  File attachments after this date will be obtained.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The End date of the date range.  File attachments before this date will be obtained.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many File attachments (optional) 
            var take = 56;  // int? | Take this many File attachments (optional) 

            try
            {
                // Get my file attachments.  Get files you've attached to timesheets.
                CSApiResponseForPaginatedListTimesheetFileAttachment result = apiInstance.FileAttachmentsGetMyFileAttachments(startDate, endDate, xChronosheetsAuth, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileAttachmentsApi.FileAttachmentsGetMyFileAttachments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The Start date of the date range.  File attachments after this date will be obtained. | 
 **endDate** | **DateTime?**| The End date of the date range.  File attachments before this date will be obtained. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many File attachments | [optional] 
 **take** | **int?**| Take this many File attachments | [optional] 

### Return type

[**CSApiResponseForPaginatedListTimesheetFileAttachment**](CSApiResponseForPaginatedListTimesheetFileAttachment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

