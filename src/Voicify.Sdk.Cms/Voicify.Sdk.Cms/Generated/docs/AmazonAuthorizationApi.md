# Voicify.Sdk.Cms.Api.AmazonAuthorizationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AmazonAuthCallbackAsync**](AmazonAuthorizationApi.md#amazonauthcallbackasync) | **GET** /api/AmazonAuthorization/Callback | Handles the callback for amazon OAuth
[**GetAvailableCredentials**](AmazonAuthorizationApi.md#getavailablecredentials) | **GET** /api/AmazonAuthorization/Credentials/{organizationId} | Gets the available amazon credential information for a given organization
[**RemoveCredential**](AmazonAuthorizationApi.md#removecredential) | **DELETE** /api/AmazonAuthorization/Credentials/{tokenId} | Removes an amazon credential
[**RequestAuthenticationUrl**](AmazonAuthorizationApi.md#requestauthenticationurl) | **GET** /api/AmazonAuthorization/AuthorizationUrl | Gets the authentication url for amazon authorization


<a name="amazonauthcallbackasync"></a>
# **AmazonAuthCallbackAsync**
> bool? AmazonAuthCallbackAsync (string code = null, string state = null, string error = null)

Handles the callback for amazon OAuth

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AmazonAuthCallbackAsyncExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AmazonAuthorizationApi();
            var code = code_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional) 
            var error = error_example;  // string |  (optional) 

            try
            {
                // Handles the callback for amazon OAuth
                bool? result = apiInstance.AmazonAuthCallbackAsync(code, state, error);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.AmazonAuthCallbackAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**|  | [optional] 
 **state** | **string**|  | [optional] 
 **error** | **string**|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailablecredentials"></a>
# **GetAvailableCredentials**
> List<TokenResponse> GetAvailableCredentials (string organizationId)

Gets the available amazon credential information for a given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableCredentialsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AmazonAuthorizationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Gets the available amazon credential information for a given organization
                List&lt;TokenResponse&gt; result = apiInstance.GetAvailableCredentials(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.GetAvailableCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**List<TokenResponse>**](TokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removecredential"></a>
# **RemoveCredential**
> bool? RemoveCredential (string tokenId)

Removes an amazon credential

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveCredentialExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AmazonAuthorizationApi();
            var tokenId = tokenId_example;  // string | 

            try
            {
                // Removes an amazon credential
                bool? result = apiInstance.RemoveCredential(tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.RemoveCredential: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestauthenticationurl"></a>
# **RequestAuthenticationUrl**
> string RequestAuthenticationUrl (string organizationId = null, string applicationId = null, string salt = null)

Gets the authentication url for amazon authorization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RequestAuthenticationUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AmazonAuthorizationApi();
            var organizationId = organizationId_example;  // string |  (optional) 
            var applicationId = applicationId_example;  // string |  (optional) 
            var salt = salt_example;  // string |  (optional) 

            try
            {
                // Gets the authentication url for amazon authorization
                string result = apiInstance.RequestAuthenticationUrl(organizationId, applicationId, salt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AmazonAuthorizationApi.RequestAuthenticationUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | [optional] 
 **applicationId** | **string**|  | [optional] 
 **salt** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

