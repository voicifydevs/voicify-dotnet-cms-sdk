# Voicify.Sdk.Cms.Api.SingleSignOnApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SignInWithSingleSignOn**](SingleSignOnApi.md#signinwithsinglesignon) | **POST** /api/SingleSignOn/signIn | Begins single sign in process
[**SignUpWithSingleSignOn**](SingleSignOnApi.md#signupwithsinglesignon) | **POST** /api/SingleSignOn/signUp | Begins sign up with SSO process


<a name="signinwithsinglesignon"></a>
# **SignInWithSingleSignOn**
> SingleSignOnResponse SignInWithSingleSignOn (SingleSignOnRequest request = null)

Begins single sign in process

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SignInWithSingleSignOnExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SingleSignOnApi();
            var request = new SingleSignOnRequest(); // SingleSignOnRequest |  (optional) 

            try
            {
                // Begins single sign in process
                SingleSignOnResponse result = apiInstance.SignInWithSingleSignOn(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnApi.SignInWithSingleSignOn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SingleSignOnRequest**](SingleSignOnRequest.md)|  | [optional] 

### Return type

[**SingleSignOnResponse**](SingleSignOnResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="signupwithsinglesignon"></a>
# **SignUpWithSingleSignOn**
> SingleSignOnResponse SignUpWithSingleSignOn (SingleSignOnRequest request = null)

Begins sign up with SSO process

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SignUpWithSingleSignOnExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SingleSignOnApi();
            var request = new SingleSignOnRequest(); // SingleSignOnRequest |  (optional) 

            try
            {
                // Begins sign up with SSO process
                SingleSignOnResponse result = apiInstance.SignUpWithSingleSignOn(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SingleSignOnApi.SignUpWithSingleSignOn: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SingleSignOnRequest**](SingleSignOnRequest.md)|  | [optional] 

### Return type

[**SingleSignOnResponse**](SingleSignOnResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

