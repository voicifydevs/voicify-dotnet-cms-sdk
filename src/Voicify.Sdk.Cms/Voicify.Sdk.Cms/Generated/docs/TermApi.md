# Voicify.Sdk.Cms.Api.TermApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTermAgreement**](TermApi.md#addtermagreement) | **POST** /api/Term/agreement | 
[**GetLatestTerm**](TermApi.md#getlatestterm) | **GET** /api/Term/latest | 


<a name="addtermagreement"></a>
# **AddTermAgreement**
> UserTermModel AddTermAgreement (NewUserTermRequestModel model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddTermAgreementExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TermApi();
            var model = new NewUserTermRequestModel(); // NewUserTermRequestModel |  (optional) 

            try
            {
                UserTermModel result = apiInstance.AddTermAgreement(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.AddTermAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewUserTermRequestModel**](NewUserTermRequestModel.md)|  | [optional] 

### Return type

[**UserTermModel**](UserTermModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlatestterm"></a>
# **GetLatestTerm**
> TermModel GetLatestTerm ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetLatestTermExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TermApi();

            try
            {
                TermModel result = apiInstance.GetLatestTerm();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TermApi.GetLatestTerm: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TermModel**](TermModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

