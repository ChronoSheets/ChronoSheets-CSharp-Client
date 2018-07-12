# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGetOrganisation**](OrganisationApi.md#organisationgetorganisation) | **GET** /api/Organisation/GetOrganisation | Get your organisation.    Requires &#39;OrganisationAdmin&#39; permission.
[**OrganisationUpdateOrganisation**](OrganisationApi.md#organisationupdateorganisation) | **PUT** /api/Organisation/UpdateOrganisation | Update an organisation.    Requires &#39;OrganisationAdmin&#39; permission.


<a name="organisationgetorganisation"></a>
# **OrganisationGetOrganisation**
> CSApiResponseOrganisation OrganisationGetOrganisation (string xChronosheetsAuth)

Get your organisation.    Requires 'OrganisationAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationGetOrganisationExample
    {
        public void main()
        {
            var apiInstance = new OrganisationApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get your organisation.    Requires 'OrganisationAdmin' permission.
                CSApiResponseOrganisation result = apiInstance.OrganisationGetOrganisation(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.OrganisationGetOrganisation: " + e.Message );
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

[**CSApiResponseOrganisation**](CSApiResponseOrganisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationupdateorganisation"></a>
# **OrganisationUpdateOrganisation**
> CSApiResponseUpdateOrganisationResponse OrganisationUpdateOrganisation (CSUpdateOrganisationRequest request, string xChronosheetsAuth)

Update an organisation.    Requires 'OrganisationAdmin' permission.

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class OrganisationUpdateOrganisationExample
    {
        public void main()
        {
            var apiInstance = new OrganisationApi();
            var request = new CSUpdateOrganisationRequest(); // CSUpdateOrganisationRequest | An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update an organisation.    Requires 'OrganisationAdmin' permission.
                CSApiResponseUpdateOrganisationResponse result = apiInstance.OrganisationUpdateOrganisation(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganisationApi.OrganisationUpdateOrganisation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CSUpdateOrganisationRequest**](CSUpdateOrganisationRequest.md)| An Update Organsation Request object containing updated fields.  Make sure to specify the Organsation Id in the request object so that ChronoSheets knows which Organsation to update | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CSApiResponseUpdateOrganisationResponse**](CSApiResponseUpdateOrganisationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

