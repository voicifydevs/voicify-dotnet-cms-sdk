# Voicify.Sdk.Cms.Api.CustomRequestApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFile**](CustomRequestApi.md#addaudiofile) | **PUT** /api/CustomRequest/{customRequestResponseId}/addAudioFile/{mediaItemId} | Adds an audio file to the given response
[**AddLargeImage**](CustomRequestApi.md#addlargeimage) | **PUT** /api/CustomRequest/{customRequestResponseId}/addLargeImage/{mediaItemId} | Adds a large image to the given response
[**AddSmallImage**](CustomRequestApi.md#addsmallimage) | **PUT** /api/CustomRequest/{customRequestResponseId}/addSmallImage/{mediaItemId} | Adds a small image item to the given response
[**AddVideoFile**](CustomRequestApi.md#addvideofile) | **PUT** /api/CustomRequest/{customRequestResponseId}/addVideoFile/{mediaItemId} | Adds a video file to the given response
[**AddWebhook**](CustomRequestApi.md#addwebhook) | **POST** /api/CustomRequest/{customRequestId}/webhooks/{webhookId} | 
[**BulkUpdateCustomRequest**](CustomRequestApi.md#bulkupdatecustomrequest) | **PUT** /api/CustomRequest/{customRequestId}/bulkUpdate | 
[**BulkUpdateCustomRequestStub**](CustomRequestApi.md#bulkupdatecustomrequeststub) | **PUT** /api/CustomRequest/{customRequestId}/bulkUpdate/stub | 
[**CopyContentItem**](CustomRequestApi.md#copycontentitem) | **POST** /api/CustomRequest/{customRequestId}/copy | Copies the content item in the same application and feature
[**CreateCustomRequest**](CustomRequestApi.md#createcustomrequest) | **POST** /api/CustomRequest | Creates a new custom request entity
[**CreateCustomRequestStub**](CustomRequestApi.md#createcustomrequeststub) | **POST** /api/CustomRequest/stub | Creates a new custom request entity
[**CreateFullContentItem**](CustomRequestApi.md#createfullcontentitem) | **POST** /api/CustomRequest/full | Creates a new content item entity from a dto
[**CreateResponse**](CustomRequestApi.md#createresponse) | **POST** /api/CustomRequest/{customRequestId}/response | Creates a new response varation for the given message
[**DeleteCustomRequest**](CustomRequestApi.md#deletecustomrequest) | **DELETE** /api/CustomRequest/{customRequestId} | Delete the given custom request
[**DeleteResponse**](CustomRequestApi.md#deleteresponse) | **DELETE** /api/CustomRequest/response/{customRequestResponseId} | Deletes the given response
[**FindFullById**](CustomRequestApi.md#findfullbyid) | **GET** /api/CustomRequest/full/{id} | Finds the full content item by id
[**GetByApplicationFeature**](CustomRequestApi.md#getbyapplicationfeature) | **GET** /api/CustomRequest/byFeature/{applicationFeatureId} | Gets the content for the given application feature
[**GetMediaItemsForCustomRequest**](CustomRequestApi.md#getmediaitemsforcustomrequest) | **GET** /api/CustomRequest/response/{customRequestResponseId}/media | 
[**GetMessagesForApplication**](CustomRequestApi.md#getmessagesforapplication) | **GET** /api/CustomRequest/{applicationId} | Gets the custom requests content for the given application  regardless of module
[**GetMessagesForModule**](CustomRequestApi.md#getmessagesformodule) | **GET** /api/CustomRequest/module/{applicationModuleId} | Gets the custom requests for the given application module
[**GetWebhooks**](CustomRequestApi.md#getwebhooks) | **GET** /api/CustomRequest/{customRequestId}/webhooks | 
[**MoveContentItemToApplicationFeature**](CustomRequestApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/CustomRequest/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveWebhook**](CustomRequestApi.md#removewebhook) | **DELETE** /api/CustomRequest/webhook/{customRequestWebhookId} | 
[**ToggleLive**](CustomRequestApi.md#togglelive) | **PUT** /api/CustomRequest/{customRequestId}/isLive | Toggles the given message as live or not
[**UpdateAttachedWebhook**](CustomRequestApi.md#updateattachedwebhook) | **PUT** /api/CustomRequest/{customRequestId}/webhooks/{webhookInstanceId} | 
[**UpdateFullContentItem**](CustomRequestApi.md#updatefullcontentitem) | **PUT** /api/CustomRequest/{contentItemId}/full | Updates the content item from a specified dto
[**UpdateMessage**](CustomRequestApi.md#updatemessage) | **PUT** /api/CustomRequest/{customRequestId} | Updates the custom request with the given fields  If you send null or no value for fields, they won&#39;t be updated
[**UpdateResponse**](CustomRequestApi.md#updateresponse) | **PUT** /api/CustomRequest/response/{customRequestResponseId} | Updates the given response


<a name="addaudiofile"></a>
# **AddAudioFile**
> CustomRequestResponseModel AddAudioFile (string customRequestResponseId, string mediaItemId)

Adds an audio file to the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAudioFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds an audio file to the given response
                CustomRequestResponseModel result = apiInstance.AddAudioFile(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.AddAudioFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlargeimage"></a>
# **AddLargeImage**
> CustomRequestResponseModel AddLargeImage (string customRequestResponseId, string mediaItemId)

Adds a large image to the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddLargeImageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a large image to the given response
                CustomRequestResponseModel result = apiInstance.AddLargeImage(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsmallimage"></a>
# **AddSmallImage**
> CustomRequestResponseModel AddSmallImage (string customRequestResponseId, string mediaItemId)

Adds a small image item to the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddSmallImageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a small image item to the given response
                CustomRequestResponseModel result = apiInstance.AddSmallImage(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideofile"></a>
# **AddVideoFile**
> CustomRequestResponseModel AddVideoFile (string customRequestResponseId, string mediaItemId)

Adds a video file to the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddVideoFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a video file to the given response
                CustomRequestResponseModel result = apiInstance.AddVideoFile(customRequestResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> CustomRequestWebhookModel AddWebhook (string customRequestId, string webhookId, WebhookParametersRequest parameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                CustomRequestWebhookModel result = apiInstance.AddWebhook(customRequestId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatecustomrequest"></a>
# **BulkUpdateCustomRequest**
> CustomRequestModel BulkUpdateCustomRequest (string customRequestId, BulkUpdateCustomRequestRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateCustomRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var model = new BulkUpdateCustomRequestRequest(); // BulkUpdateCustomRequestRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.BulkUpdateCustomRequest(customRequestId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.BulkUpdateCustomRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **model** | [**BulkUpdateCustomRequestRequest**](BulkUpdateCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatecustomrequeststub"></a>
# **BulkUpdateCustomRequestStub**
> CustomRequestModel BulkUpdateCustomRequestStub (string customRequestId, BulkUpdateCustomRequestStubRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateCustomRequestStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var model = new BulkUpdateCustomRequestStubRequest(); // BulkUpdateCustomRequestStubRequest |  (optional) 

            try
            {
                CustomRequestModel result = apiInstance.BulkUpdateCustomRequestStub(customRequestId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.BulkUpdateCustomRequestStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **model** | [**BulkUpdateCustomRequestStubRequest**](BulkUpdateCustomRequestStubRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copycontentitem"></a>
# **CopyContentItem**
> CustomRequestModel CopyContentItem (string customRequestId)

Copies the content item in the same application and feature

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CopyContentItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                // Copies the content item in the same application and feature
                CustomRequestModel result = apiInstance.CopyContentItem(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomrequest"></a>
# **CreateCustomRequest**
> CustomRequestModel CreateCustomRequest (NewCustomRequestRequest model = null)

Creates a new custom request entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateCustomRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var model = new NewCustomRequestRequest(); // NewCustomRequestRequest |  (optional) 

            try
            {
                // Creates a new custom request entity
                CustomRequestModel result = apiInstance.CreateCustomRequest(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.CreateCustomRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewCustomRequestRequest**](NewCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustomrequeststub"></a>
# **CreateCustomRequestStub**
> CustomRequestModel CreateCustomRequestStub (NewCustomRequestStubRequest model = null)

Creates a new custom request entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateCustomRequestStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var model = new NewCustomRequestStubRequest(); // NewCustomRequestStubRequest |  (optional) 

            try
            {
                // Creates a new custom request entity
                CustomRequestModel result = apiInstance.CreateCustomRequestStub(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.CreateCustomRequestStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewCustomRequestStubRequest**](NewCustomRequestStubRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> CustomRequestModel CreateFullContentItem (CustomRequestModel model = null)

Creates a new content item entity from a dto

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateFullContentItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var model = new CustomRequestModel(); // CustomRequestModel |  (optional) 

            try
            {
                // Creates a new content item entity from a dto
                CustomRequestModel result = apiInstance.CreateFullContentItem(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**CustomRequestModel**](CustomRequestModel.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createresponse"></a>
# **CreateResponse**
> CustomRequestResponseModel CreateResponse (string customRequestId, NewCustomRequestResponseRequest model = null)

Creates a new response varation for the given message

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateResponseExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var model = new NewCustomRequestResponseRequest(); // NewCustomRequestResponseRequest |  (optional) 

            try
            {
                // Creates a new response varation for the given message
                CustomRequestResponseModel result = apiInstance.CreateResponse(customRequestId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.CreateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **model** | [**NewCustomRequestResponseRequest**](NewCustomRequestResponseRequest.md)|  | [optional] 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecustomrequest"></a>
# **DeleteCustomRequest**
> CustomRequestModel DeleteCustomRequest (string customRequestId)

Delete the given custom request

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteCustomRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                // Delete the given custom request
                CustomRequestModel result = apiInstance.DeleteCustomRequest(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.DeleteCustomRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresponse"></a>
# **DeleteResponse**
> CustomRequestResponseModel DeleteResponse (string customRequestResponseId)

Deletes the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteResponseExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 

            try
            {
                // Deletes the given response
                CustomRequestResponseModel result = apiInstance.DeleteResponse(customRequestResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.DeleteResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfullbyid"></a>
# **FindFullById**
> CustomRequestModel FindFullById (string id)

Finds the full content item by id

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindFullByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var id = id_example;  // string | 

            try
            {
                // Finds the full content item by id
                CustomRequestModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.FindFullById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<CustomRequestModel> GetByApplicationFeature (string applicationFeatureId)

Gets the content for the given application feature

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetByApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature
                List&lt;CustomRequestModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.GetByApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 

### Return type

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmediaitemsforcustomrequest"></a>
# **GetMediaItemsForCustomRequest**
> List<MediaItemModel> GetMediaItemsForCustomRequest (string customRequestResponseId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMediaItemsForCustomRequestExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 

            try
            {
                List&lt;MediaItemModel&gt; result = apiInstance.GetMediaItemsForCustomRequest(customRequestResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.GetMediaItemsForCustomRequest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 

### Return type

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesforapplication"></a>
# **GetMessagesForApplication**
> List<CustomRequestModel> GetMessagesForApplication (string applicationId)

Gets the custom requests content for the given application  regardless of module

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMessagesForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the custom requests content for the given application  regardless of module
                List&lt;CustomRequestModel&gt; result = apiInstance.GetMessagesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.GetMessagesForApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 

### Return type

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesformodule"></a>
# **GetMessagesForModule**
> List<CustomRequestModel> GetMessagesForModule (string applicationModuleId)

Gets the custom requests for the given application module

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMessagesForModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                // Gets the custom requests for the given application module
                List&lt;CustomRequestModel&gt; result = apiInstance.GetMessagesForModule(applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.GetMessagesForModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 

### Return type

[**List<CustomRequestModel>**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<CustomRequestWebhookModel> GetWebhooks (string customRequestId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 

            try
            {
                List&lt;CustomRequestWebhookModel&gt; result = apiInstance.GetWebhooks(customRequestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 

### Return type

[**List<CustomRequestWebhookModel>**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> CustomRequestModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class MoveContentItemToApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                CustomRequestModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.MoveContentItemToApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **applicationFeatureId** | **string**|  | 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removewebhook"></a>
# **RemoveWebhook**
> CustomRequestWebhookModel RemoveWebhook (string customRequestWebhookId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestWebhookId = customRequestWebhookId_example;  // string | 

            try
            {
                CustomRequestWebhookModel result = apiInstance.RemoveWebhook(customRequestWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestWebhookId** | **string**|  | 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="togglelive"></a>
# **ToggleLive**
> CustomRequestModel ToggleLive (string customRequestId, ToggleLiveRequest model = null)

Toggles the given message as live or not

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ToggleLiveExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var model = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                // Toggles the given message as live or not
                CustomRequestModel result = apiInstance.ToggleLive(customRequestId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.ToggleLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **model** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> CustomRequestWebhookModel UpdateAttachedWebhook (string customRequestId, string webhookInstanceId, WebhookParametersRequest parameters = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAttachedWebhookExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                CustomRequestWebhookModel result = apiInstance.UpdateAttachedWebhook(customRequestId, webhookInstanceId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**CustomRequestWebhookModel**](CustomRequestWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> CustomRequestModel UpdateFullContentItem (string contentItemId, CustomRequestModel model = null)

Updates the content item from a specified dto

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateFullContentItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var contentItemId = contentItemId_example;  // string | 
            var model = new CustomRequestModel(); // CustomRequestModel |  (optional) 

            try
            {
                // Updates the content item from a specified dto
                CustomRequestModel result = apiInstance.UpdateFullContentItem(contentItemId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **model** | [**CustomRequestModel**](CustomRequestModel.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessage"></a>
# **UpdateMessage**
> CustomRequestModel UpdateMessage (string customRequestId, UpdateCustomRequestRequest model = null)

Updates the custom request with the given fields  If you send null or no value for fields, they won't be updated

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMessageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestId = customRequestId_example;  // string | 
            var model = new UpdateCustomRequestRequest(); // UpdateCustomRequestRequest |  (optional) 

            try
            {
                // Updates the custom request with the given fields  If you send null or no value for fields, they won't be updated
                CustomRequestModel result = apiInstance.UpdateMessage(customRequestId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.UpdateMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestId** | **string**|  | 
 **model** | [**UpdateCustomRequestRequest**](UpdateCustomRequestRequest.md)|  | [optional] 

### Return type

[**CustomRequestModel**](CustomRequestModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresponse"></a>
# **UpdateResponse**
> CustomRequestResponseModel UpdateResponse (string customRequestResponseId, UpdateCustomRequestResponseRequest model = null)

Updates the given response

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateResponseExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CustomRequestApi();
            var customRequestResponseId = customRequestResponseId_example;  // string | 
            var model = new UpdateCustomRequestResponseRequest(); // UpdateCustomRequestResponseRequest |  (optional) 

            try
            {
                // Updates the given response
                CustomRequestResponseModel result = apiInstance.UpdateResponse(customRequestResponseId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomRequestApi.UpdateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customRequestResponseId** | **string**|  | 
 **model** | [**UpdateCustomRequestResponseRequest**](UpdateCustomRequestResponseRequest.md)|  | [optional] 

### Return type

[**CustomRequestResponseModel**](CustomRequestResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

