# ChronoSheetsAPI.ChronoSheetsClientLibApi.TranscriptsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranscriptsGetMyTranscript**](TranscriptsApi.md#transcriptsgetmytranscript) | **GET** /api/Transcripts/GetMyTranscript | Get an audio to text transcript for a particular audio file attachment
[**TranscriptsGetMyTranscripts**](TranscriptsApi.md#transcriptsgetmytranscripts) | **GET** /api/Transcripts/GetMyTranscripts | Get my file transcripts.  Get audio to text transcripts that you&#39;ve created.


<a name="transcriptsgetmytranscript"></a>
# **TranscriptsGetMyTranscript**
> CSApiResponseForPaginatedTranscription TranscriptsGetMyTranscript (int? fileAttachmentId, string xChronosheetsAuth)

Get an audio to text transcript for a particular audio file attachment

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TranscriptsGetMyTranscriptExample
    {
        public void main()
        {
            var apiInstance = new TranscriptsApi();
            var fileAttachmentId = 56;  // int? | The ID of the file attachment that has a transcript.  It should be an audio file attachment.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get an audio to text transcript for a particular audio file attachment
                CSApiResponseForPaginatedTranscription result = apiInstance.TranscriptsGetMyTranscript(fileAttachmentId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranscriptsApi.TranscriptsGetMyTranscript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fileAttachmentId** | **int?**| The ID of the file attachment that has a transcript.  It should be an audio file attachment. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseForPaginatedTranscription**](CSApiResponseForPaginatedTranscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transcriptsgetmytranscripts"></a>
# **TranscriptsGetMyTranscripts**
> CSApiResponseForPaginatedListOrgReportTranscript TranscriptsGetMyTranscripts (DateTime? startDate, DateTime? endDate, string xChronosheetsAuth, int? skip = null, int? take = null, string keyword = null)

Get my file transcripts.  Get audio to text transcripts that you've created.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class TranscriptsGetMyTranscriptsExample
    {
        public void main()
        {
            var apiInstance = new TranscriptsApi();
            var startDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The Start date of the date range.  Transcripts after this date will be obtained.
            var endDate = 2013-10-20T19:20:30+01:00;  // DateTime? | The End date of the date range.  Transcripts before this date will be obtained.
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token
            var skip = 56;  // int? | Skip this many transcripts (optional) 
            var take = 56;  // int? | Take this many transcripts (optional) 
            var keyword = keyword_example;  // string | Search the text content of the transcript keywords (optional) 

            try
            {
                // Get my file transcripts.  Get audio to text transcripts that you've created.
                CSApiResponseForPaginatedListOrgReportTranscript result = apiInstance.TranscriptsGetMyTranscripts(startDate, endDate, xChronosheetsAuth, skip, take, keyword);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranscriptsApi.TranscriptsGetMyTranscripts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **DateTime?**| The Start date of the date range.  Transcripts after this date will be obtained. | 
 **endDate** | **DateTime?**| The End date of the date range.  Transcripts before this date will be obtained. | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 
 **skip** | **int?**| Skip this many transcripts | [optional] 
 **take** | **int?**| Take this many transcripts | [optional] 
 **keyword** | **string**| Search the text content of the transcript keywords | [optional] 

### Return type

[**CSApiResponseForPaginatedListOrgReportTranscript**](CSApiResponseForPaginatedListOrgReportTranscript.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

