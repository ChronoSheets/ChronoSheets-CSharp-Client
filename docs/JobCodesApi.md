# ChronoSheetsAPI.ChronoSheetsClientLibApi.JobCodesApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JobCodesCreateJobCode**](JobCodesApi.md#jobcodescreatejobcode) | **PUT** /api/JobCodes/CreateJobCode | Create a job code
[**JobCodesDeleteJobCode**](JobCodesApi.md#jobcodesdeletejobcode) | **DELETE** /api/JobCodes/DeleteJobCode | Delete a job code
[**JobCodesGetJobCodeById**](JobCodesApi.md#jobcodesgetjobcodebyid) | **GET** /api/JobCodes/GetJobCodeById | Get a particular job code by job code id
[**JobCodesGetJobCodes**](JobCodesApi.md#jobcodesgetjobcodes) | **GET** /api/JobCodes/GetJobCodes | Get job codes for your organisation
[**JobCodesUpdateJobCode**](JobCodesApi.md#jobcodesupdatejobcode) | **POST** /api/JobCodes/UpdateJobCode | Update a job code


<a name="jobcodescreatejobcode"></a>
# **JobCodesCreateJobCode**
> CSApiResponseInt32 JobCodesCreateJobCode (CSInsertJobCodeRequest request, string xChronosheetsAuth)

Create a job code

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class JobCodesCreateJobCodeExample
    {
        public void main()
        {
            var apiInstance = new JobCodesApi();
            var request = new CSInsertJobCodeRequest(); // CSInsertJobCodeRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a job code
                CSApiResponseInt32 result = apiInstance.JobCodesCreateJobCode(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobCodesApi.JobCodesCreateJobCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSInsertJobCodeRequest**](CSInsertJobCodeRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseInt32**](CSApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobcodesdeletejobcode"></a>
# **JobCodesDeleteJobCode**
> CSApiResponseBoolean JobCodesDeleteJobCode (int? jobCodeId, string xChronosheetsAuth)

Delete a job code

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class JobCodesDeleteJobCodeExample
    {
        public void main()
        {
            var apiInstance = new JobCodesApi();
            var jobCodeId = 56;  // int? | The ID of the job code your want to delete
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Delete a job code
                CSApiResponseBoolean result = apiInstance.JobCodesDeleteJobCode(jobCodeId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobCodesApi.JobCodesDeleteJobCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobCodeId** | **int?**| The ID of the job code your want to delete | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobcodesgetjobcodebyid"></a>
# **JobCodesGetJobCodeById**
> CSApiResponseJobCode JobCodesGetJobCodeById (int? jobCodeId, string xChronosheetsAuth)

Get a particular job code by job code id

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class JobCodesGetJobCodeByIdExample
    {
        public void main()
        {
            var apiInstance = new JobCodesApi();
            var jobCodeId = 56;  // int? | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular job code by job code id
                CSApiResponseJobCode result = apiInstance.JobCodesGetJobCodeById(jobCodeId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobCodesApi.JobCodesGetJobCodeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobCodeId** | **int?**|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseJobCode**](CSApiResponseJobCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobcodesgetjobcodes"></a>
# **JobCodesGetJobCodes**
> CSApiResponseListJobCode JobCodesGetJobCodes (string xChronosheetsAuth)

Get job codes for your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class JobCodesGetJobCodesExample
    {
        public void main()
        {
            var apiInstance = new JobCodesApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get job codes for your organisation
                CSApiResponseListJobCode result = apiInstance.JobCodesGetJobCodes(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobCodesApi.JobCodesGetJobCodes: " + e.Message );
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

[**CSApiResponseListJobCode**](CSApiResponseListJobCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="jobcodesupdatejobcode"></a>
# **JobCodesUpdateJobCode**
> CSApiResponseBoolean JobCodesUpdateJobCode (CSUpdateJobCodeRequest request, string xChronosheetsAuth)

Update a job code

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class JobCodesUpdateJobCodeExample
    {
        public void main()
        {
            var apiInstance = new JobCodesApi();
            var request = new CSUpdateJobCodeRequest(); // CSUpdateJobCodeRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a job code
                CSApiResponseBoolean result = apiInstance.JobCodesUpdateJobCode(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JobCodesApi.JobCodesUpdateJobCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSUpdateJobCodeRequest**](CSUpdateJobCodeRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseBoolean**](CSApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

