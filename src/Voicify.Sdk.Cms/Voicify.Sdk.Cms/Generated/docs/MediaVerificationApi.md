# Voicify.Sdk.Cms.Api.MediaVerificationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetContentItemsForMediaItem**](MediaVerificationApi.md#getcontentitemsformediaitem) | **GET** /api/MediaVerification/contentItems/{mediaItemId} | 


<a name="getcontentitemsformediaitem"></a>
# **GetContentItemsForMediaItem**
> MediaContentItems GetContentItemsForMediaItem (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetContentItemsForMediaItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaVerificationApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaContentItems result = apiInstance.GetContentItemsForMediaItem(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaVerificationApi.GetContentItemsForMediaItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaContentItems**](MediaContentItems.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

