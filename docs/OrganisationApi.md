# ChronoSheetsAPI.ChronoSheetsClientLibApi.OrganisationApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrganisationGetOrganisation**](OrganisationApi.md#organisationgetorganisation) | **GET** /api/Organisation/GetOrganisation | Get your organisation.  Requires &#39;OrganisationAdmin&#39; permission.
[**OrganisationUpdateOrganisation**](OrganisationApi.md#organisationupdateorganisation) | **POST** /api/Organisation/UpdateOrganisation | Update an organisation.  Requires &#39;OrganisationAdmin&#39; permission.


<a name="organisationgetorganisation"></a>
# **OrganisationGetOrganisation**
> CsApiApiResponseOrganisation OrganisationGetOrganisation (string xChronosheetsAuth)

Get your organisation.  Requires 'OrganisationAdmin' permission.

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
                // Get your organisation.  Requires 'OrganisationAdmin' permission.
                CsApiApiResponseOrganisation result = apiInstance.OrganisationGetOrganisation(xChronosheetsAuth);
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

[**CsApiApiResponseOrganisation**](CsApiApiResponseOrganisation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="organisationupdateorganisation"></a>
# **OrganisationUpdateOrganisation**
> CsApiApiResponseUpdateOrganisationResponse OrganisationUpdateOrganisation (CsApiUpdateOrganisationRequest request, string xChronosheetsAuth)

Update an organisation.  Requires 'OrganisationAdmin' permission.

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
            var request = new CsApiUpdateOrganisationRequest(); // CsApiUpdateOrganisationRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update an organisation.  Requires 'OrganisationAdmin' permission.
                CsApiApiResponseUpdateOrganisationResponse result = apiInstance.OrganisationUpdateOrganisation(request, xChronosheetsAuth);
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
 **request** | [**CsApiUpdateOrganisationRequest**](CsApiUpdateOrganisationRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseUpdateOrganisationResponse**](CsApiApiResponseUpdateOrganisationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

