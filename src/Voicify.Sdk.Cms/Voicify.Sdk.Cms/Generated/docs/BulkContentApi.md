# Voicify.Sdk.Cms.Api.BulkContentApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCopyContentToApplicationFeature**](BulkContentApi.md#bulkcopycontenttoapplicationfeature) | **PUT** /api/BulkContent/CopyToFeature/{applicationFeatureId} | 
[**BulkMoveContentToApplicationFeature**](BulkContentApi.md#bulkmovecontenttoapplicationfeature) | **PUT** /api/BulkContent/MoveToFeature/{applicationFeatureId} | 
[**DeleteContentInBulk**](BulkContentApi.md#deletecontentinbulk) | **PUT** /api/BulkContent/Delete | 


<a name="bulkcopycontenttoapplicationfeature"></a>
# **BulkCopyContentToApplicationFeature**
> string BulkCopyContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkCopyContentToApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BulkContentApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var request = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.BulkCopyContentToApplicationFeature(applicationFeatureId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.BulkCopyContentToApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **request** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkmovecontenttoapplicationfeature"></a>
# **BulkMoveContentToApplicationFeature**
> string BulkMoveContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkMoveContentToApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BulkContentApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var request = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.BulkMoveContentToApplicationFeature(applicationFeatureId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.BulkMoveContentToApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **request** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontentinbulk"></a>
# **DeleteContentInBulk**
> string DeleteContentInBulk (BulkContentRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteContentInBulkExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BulkContentApi();
            var request = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                string result = apiInstance.DeleteContentInBulk(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BulkContentApi.DeleteContentInBulk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

