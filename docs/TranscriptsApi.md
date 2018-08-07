# ChronoSheetsAPI.ChronoSheetsClientLibApi.TranscriptsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranscriptsGetMyTranscripts**](TranscriptsApi.md#transcriptsgetmytranscripts) | **GET** /api/Transcripts/GetMyTranscripts | Get my file transcripts.  Get audio to text transcripts that you&#39;ve created.


<a name="transcriptsgetmytranscripts"></a>
# **TranscriptsGetMyTranscripts**
> CSApiResponseForPaginatedListOrgReportTranscript TranscriptsGetMyTranscripts (DateTime? startDate, DateTime? endDate, int? skip, int? take, string keyword, string xChronosheetsAuth)

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
            var skip = 56;  // int? | Skip this many transcripts
            var take = 56;  // int? | Take this many transcripts
            var keyword = keyword_example;  // string | Search the text content of the transcript keywords
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get my file transcripts.  Get audio to text transcripts that you've created.
                CSApiResponseForPaginatedListOrgReportTranscript result = apiInstance.TranscriptsGetMyTranscripts(startDate, endDate, skip, take, keyword, xChronosheetsAuth);
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
 **skip** | **int?**| Skip this many transcripts | 
 **take** | **int?**| Take this many transcripts | 
 **keyword** | **string**| Search the text content of the transcript keywords | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseForPaginatedListOrgReportTranscript**](CSApiResponseForPaginatedListOrgReportTranscript.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

