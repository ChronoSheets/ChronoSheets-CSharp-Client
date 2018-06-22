# ChronoSheetsAPI.ChronoSheetsClientLibApi.ClientsApi

All URIs are relative to *https://www.chronosheets.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientsCreateClient**](ClientsApi.md#clientscreateclient) | **PUT** /api/Clients/CreateClient | Create a client
[**ClientsGetClient**](ClientsApi.md#clientsgetclient) | **GET** /api/Clients/GetClient | Get a particular client
[**ClientsGetClients**](ClientsApi.md#clientsgetclients) | **GET** /api/Clients/GetClients | Get a collection of clients that are under your organisation
[**ClientsUpdateClient**](ClientsApi.md#clientsupdateclient) | **POST** /api/Clients/UpdateClient | Update a client


<a name="clientscreateclient"></a>
# **ClientsCreateClient**
> CsApiApiResponseInt32 ClientsCreateClient (CsApiInsertClientRequest request, string xChronosheetsAuth)

Create a client

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ClientsCreateClientExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var request = new CsApiInsertClientRequest(); // CsApiInsertClientRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Create a client
                CsApiApiResponseInt32 result = apiInstance.ClientsCreateClient(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsCreateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiInsertClientRequest**](CsApiInsertClientRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseInt32**](CsApiApiResponseInt32.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsgetclient"></a>
# **ClientsGetClient**
> CsApiApiResponseClient ClientsGetClient (int? clientId, string xChronosheetsAuth)

Get a particular client

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ClientsGetClientExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var clientId = 56;  // int? | The ID of the client you want to get
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a particular client
                CsApiApiResponseClient result = apiInstance.ClientsGetClient(clientId, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsGetClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int?**| The ID of the client you want to get | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseClient**](CsApiApiResponseClient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsgetclients"></a>
# **ClientsGetClients**
> CsApiApiResponseListClient ClientsGetClients (string xChronosheetsAuth)

Get a collection of clients that are under your organisation

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ClientsGetClientsExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Get a collection of clients that are under your organisation
                CsApiApiResponseListClient result = apiInstance.ClientsGetClients(xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsGetClients: " + e.Message );
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

[**CsApiApiResponseListClient**](CsApiApiResponseListClient.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="clientsupdateclient"></a>
# **ClientsUpdateClient**
> CsApiApiResponseBoolean ClientsUpdateClient (CsApiSaveClientRequest request, string xChronosheetsAuth)

Update a client

### Example
```csharp
using System;
using System.Diagnostics;
using ChronoSheetsAPI.ChronoSheetsClientLibApi;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace Example
{
    public class ClientsUpdateClientExample
    {
        public void main()
        {
            var apiInstance = new ClientsApi();
            var request = new CsApiSaveClientRequest(); // CsApiSaveClientRequest | 
            var xChronosheetsAuth = xChronosheetsAuth_example;  // string | The ChronoSheets Auth Token

            try
            {
                // Update a client
                CsApiApiResponseBoolean result = apiInstance.ClientsUpdateClient(request, xChronosheetsAuth);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientsApi.ClientsUpdateClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CsApiSaveClientRequest**](CsApiSaveClientRequest.md)|  | 
 **xChronosheetsAuth** | **string**| The ChronoSheets Auth Token | 

### Return type

[**CsApiApiResponseBoolean**](CsApiApiResponseBoolean.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json, text/json, application/xml, text/xml, multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

