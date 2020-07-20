# Voicify.Sdk.Cms.Api.AlexaSkillApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListAlexaSkills**](AlexaSkillApi.md#listalexaskills) | **GET** /api/AlexaSkill/Skills/{vendorId}/{tokenId} | Gets the list of alexa skills for the given vendor


<a name="listalexaskills"></a>
# **ListAlexaSkills**
> List<SkillSummary> ListAlexaSkills (string tokenId, string vendorId)

Gets the list of alexa skills for the given vendor

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ListAlexaSkillsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AlexaSkillApi();
            var tokenId = tokenId_example;  // string | 
            var vendorId = vendorId_example;  // string | 

            try
            {
                // Gets the list of alexa skills for the given vendor
                List&lt;SkillSummary&gt; result = apiInstance.ListAlexaSkills(tokenId, vendorId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AlexaSkillApi.ListAlexaSkills: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tokenId** | **string**|  | 
 **vendorId** | **string**|  | 

### Return type

[**List<SkillSummary>**](SkillSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

