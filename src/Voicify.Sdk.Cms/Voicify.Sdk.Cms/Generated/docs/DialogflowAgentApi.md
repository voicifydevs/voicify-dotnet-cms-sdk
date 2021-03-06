# Voicify.Sdk.Cms.Api.DialogflowAgentApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDialogflowAgentsAsync**](DialogflowAgentApi.md#listdialogflowagentsasync) | **GET** /api/DialogflowAgent/Agents/{tokenId} | 


<a name="listdialogflowagentsasync"></a>
# **ListDialogflowAgentsAsync**
> List<DialogflowAgentInformation> ListDialogflowAgentsAsync (string tokenId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ListDialogflowAgentsAsyncExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DialogflowAgentApi();
            var tokenId = tokenId_example;  // string | 

            try
            {
                List&lt;DialogflowAgentInformation&gt; result = apiInstance.ListDialogflowAgentsAsync(tokenId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DialogflowAgentApi.ListDialogflowAgentsAsync: " + e.Message );
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

[**List<DialogflowAgentInformation>**](DialogflowAgentInformation.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

