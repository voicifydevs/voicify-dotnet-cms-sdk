# Voicify.Sdk.Cms.Api.AuthenticationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Authenticate**](AuthenticationApi.md#authenticate) | **POST** /api/Authentication | Authenticate the specified model.  Model is from query string to ensure oauth standards
[**TestAdminAuth**](AuthenticationApi.md#testadminauth) | **GET** /api/Authentication/test/admin | Endpoint for testing if the user is authenticated and an admin
[**TestAuth**](AuthenticationApi.md#testauth) | **GET** /api/Authentication/test | Endpoint for testing if a user is authenticated


<a name="authenticate"></a>
# **Authenticate**
> AuthenticationResponse Authenticate (string clientId, string clientSecret, string grantType, string username, string password = null, string refreshToken = null)

Authenticate the specified model.  Model is from query string to ensure oauth standards

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AuthenticateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string | 
            var username = username_example;  // string | 
            var password = password_example;  // string |  (optional) 
            var refreshToken = refreshToken_example;  // string |  (optional) 

            try
            {
                // Authenticate the specified model.  Model is from query string to ensure oauth standards
                AuthenticationResponse result = apiInstance.Authenticate(clientId, clientSecret, grantType, username, password, refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.Authenticate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **string**|  | 
 **clientSecret** | **string**|  | 
 **grantType** | **string**|  | 
 **username** | **string**|  | 
 **password** | **string**|  | [optional] 
 **refreshToken** | **string**|  | [optional] 

### Return type

[**AuthenticationResponse**](AuthenticationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testadminauth"></a>
# **TestAdminAuth**
> void TestAdminAuth ()

Endpoint for testing if the user is authenticated and an admin

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class TestAdminAuthExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // Endpoint for testing if the user is authenticated and an admin
                apiInstance.TestAdminAuth();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.TestAdminAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="testauth"></a>
# **TestAuth**
> void TestAuth ()

Endpoint for testing if a user is authenticated

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class TestAuthExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AuthenticationApi();

            try
            {
                // Endpoint for testing if a user is authenticated
                apiInstance.TestAuth();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.TestAuth: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

