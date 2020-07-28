# Voicify.Sdk.Cms.Api.SimpleChoiceApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFile**](SimpleChoiceApi.md#addaudiofile) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addAudioFile/{mediaItemId} | Adds an audio file to the given response
[**AddLargeImage**](SimpleChoiceApi.md#addlargeimage) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addLargeImage/{mediaItemId} | Adds a large image to the given response
[**AddSmallImage**](SimpleChoiceApi.md#addsmallimage) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addSmallImage/{mediaItemId} | Adds a small image item to the given response
[**AddVideoFile**](SimpleChoiceApi.md#addvideofile) | **PUT** /api/SimpleChoice/{simpleChoiceResponseId}/addVideoFile/{mediaItemId} | Adds a video file to the given response
[**AddWebhook**](SimpleChoiceApi.md#addwebhook) | **POST** /api/SimpleChoice/{simpleChoiceId}/webhooks/{webhookId} | 
[**BulkUpdateSimpleChoice**](SimpleChoiceApi.md#bulkupdatesimplechoice) | **PUT** /api/SimpleChoice/{simpleChoiceId}/bulkUpdate | 
[**BulkUpdateSimpleChoiceStub**](SimpleChoiceApi.md#bulkupdatesimplechoicestub) | **PUT** /api/SimpleChoice/{simpleChoiceId}/bulkUpdate/stub | 
[**CopyContentItem**](SimpleChoiceApi.md#copycontentitem) | **POST** /api/SimpleChoice/{simpleChoiceId}/copy | Copies the content item in the same application and feature
[**CreateFullContentItem**](SimpleChoiceApi.md#createfullcontentitem) | **POST** /api/SimpleChoice/full | Creates a new content item entity from a dto
[**CreateResponse**](SimpleChoiceApi.md#createresponse) | **POST** /api/SimpleChoice/{simpleChoiceId}/response | Creates a new response varation for the given message
[**CreateSimpleChoice**](SimpleChoiceApi.md#createsimplechoice) | **POST** /api/SimpleChoice | Creates a new simple choice entity
[**CreateSimpleChoiceStub**](SimpleChoiceApi.md#createsimplechoicestub) | **POST** /api/SimpleChoice/stub | Creates a new simple choice entity
[**CreateUserDefinedParameter**](SimpleChoiceApi.md#createuserdefinedparameter) | **POST** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters | 
[**DeleteResponse**](SimpleChoiceApi.md#deleteresponse) | **DELETE** /api/SimpleChoice/response/{simpleChoiceResponseId} | Deletes the given response
[**DeleteSimpleChoice**](SimpleChoiceApi.md#deletesimplechoice) | **DELETE** /api/SimpleChoice/{simpleChoiceId} | Delete the given simple choice
[**FindFullById**](SimpleChoiceApi.md#findfullbyid) | **GET** /api/SimpleChoice/full/{id} | Finds the full content item by id
[**GetByApplicationFeature**](SimpleChoiceApi.md#getbyapplicationfeature) | **GET** /api/SimpleChoice/byFeature/{applicationFeatureId} | Gets the content for the given application feature
[**GetMessagesForApplication**](SimpleChoiceApi.md#getmessagesforapplication) | **GET** /api/SimpleChoice/{applicationId} | Gets the simple choices content for the given application  regardless of module
[**GetMessagesForModule**](SimpleChoiceApi.md#getmessagesformodule) | **GET** /api/SimpleChoice/module/{applicationModuleId} | Gets the simple choices for the given application module
[**GetWebhooks**](SimpleChoiceApi.md#getwebhooks) | **GET** /api/SimpleChoice/{simpleChoiceId}/webhooks | 
[**MoveContentItemToApplicationFeature**](SimpleChoiceApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/SimpleChoice/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveUserDefinedParameter**](SimpleChoiceApi.md#removeuserdefinedparameter) | **DELETE** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](SimpleChoiceApi.md#removewebhook) | **DELETE** /api/SimpleChoice/webhook/{simpleChoiceWebhookId} | 
[**ToggleLive**](SimpleChoiceApi.md#togglelive) | **PUT** /api/SimpleChoice/{simpleChoiceId}/isLive | Toggles the given message as live or not
[**UpdateAttachedWebhook**](SimpleChoiceApi.md#updateattachedwebhook) | **PUT** /api/SimpleChoice/{simpleChoiceId}/webhooks/{webhookInstanceId} | 
[**UpdateFullContentItem**](SimpleChoiceApi.md#updatefullcontentitem) | **PUT** /api/SimpleChoice/{contentItemId}/full | Updates the content item from a specified dto
[**UpdateMessage**](SimpleChoiceApi.md#updatemessage) | **PUT** /api/SimpleChoice/{simpleChoiceId} | Updates the simple choice with the given fields  If you send null or no value for fields, they won&#39;t be updated
[**UpdateResponse**](SimpleChoiceApi.md#updateresponse) | **PUT** /api/SimpleChoice/response/{simpleChoiceResponseId} | Updates the given response
[**UpdateUserDefinedParameter**](SimpleChoiceApi.md#updateuserdefinedparameter) | **PUT** /api/SimpleChoice/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](SimpleChoiceApi.md#updatewebhookparameter) | **PUT** /api/SimpleChoice/webhook/{instanceWebhookId}/webhookParameters | 


<a name="addaudiofile"></a>
# **AddAudioFile**
> SimpleChoiceResponseModel AddAudioFile (string simpleChoiceResponseId, string mediaItemId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds an audio file to the given response
                SimpleChoiceResponseModel result = apiInstance.AddAudioFile(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddAudioFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlargeimage"></a>
# **AddLargeImage**
> SimpleChoiceResponseModel AddLargeImage (string simpleChoiceResponseId, string mediaItemId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a large image to the given response
                SimpleChoiceResponseModel result = apiInstance.AddLargeImage(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsmallimage"></a>
# **AddSmallImage**
> SimpleChoiceResponseModel AddSmallImage (string simpleChoiceResponseId, string mediaItemId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a small image item to the given response
                SimpleChoiceResponseModel result = apiInstance.AddSmallImage(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideofile"></a>
# **AddVideoFile**
> SimpleChoiceResponseModel AddVideoFile (string simpleChoiceResponseId, string mediaItemId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a video file to the given response
                SimpleChoiceResponseModel result = apiInstance.AddVideoFile(simpleChoiceResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> SimpleChoiceWebhookModel AddWebhook (string simpleChoiceId, string webhookId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.AddWebhook(simpleChoiceId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatesimplechoice"></a>
# **BulkUpdateSimpleChoice**
> SimpleChoiceModel BulkUpdateSimpleChoice (string simpleChoiceId, BulkUpdateSimpleChoiceRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateSimpleChoiceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var model = new BulkUpdateSimpleChoiceRequest(); // BulkUpdateSimpleChoiceRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.BulkUpdateSimpleChoice(simpleChoiceId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.BulkUpdateSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **model** | [**BulkUpdateSimpleChoiceRequest**](BulkUpdateSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatesimplechoicestub"></a>
# **BulkUpdateSimpleChoiceStub**
> SimpleChoiceModel BulkUpdateSimpleChoiceStub (string simpleChoiceId, BulkUpdateSimpleChoiceStubRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateSimpleChoiceStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var model = new BulkUpdateSimpleChoiceStubRequest(); // BulkUpdateSimpleChoiceStubRequest |  (optional) 

            try
            {
                SimpleChoiceModel result = apiInstance.BulkUpdateSimpleChoiceStub(simpleChoiceId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.BulkUpdateSimpleChoiceStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **model** | [**BulkUpdateSimpleChoiceStubRequest**](BulkUpdateSimpleChoiceStubRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copycontentitem"></a>
# **CopyContentItem**
> SimpleChoiceModel CopyContentItem (string simpleChoiceId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                // Copies the content item in the same application and feature
                SimpleChoiceModel result = apiInstance.CopyContentItem(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> SimpleChoiceModel CreateFullContentItem (SimpleChoiceModel model = null)

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

            var apiInstance = new SimpleChoiceApi();
            var model = new SimpleChoiceModel(); // SimpleChoiceModel |  (optional) 

            try
            {
                // Creates a new content item entity from a dto
                SimpleChoiceModel result = apiInstance.CreateFullContentItem(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**SimpleChoiceModel**](SimpleChoiceModel.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createresponse"></a>
# **CreateResponse**
> SimpleChoiceResponseModel CreateResponse (string simpleChoiceId, NewSimpleChoiceResponseRequest model = null)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var model = new NewSimpleChoiceResponseRequest(); // NewSimpleChoiceResponseRequest |  (optional) 

            try
            {
                // Creates a new response varation for the given message
                SimpleChoiceResponseModel result = apiInstance.CreateResponse(simpleChoiceId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **model** | [**NewSimpleChoiceResponseRequest**](NewSimpleChoiceResponseRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsimplechoice"></a>
# **CreateSimpleChoice**
> SimpleChoiceModel CreateSimpleChoice (NewSimpleChoiceRequest model = null)

Creates a new simple choice entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateSimpleChoiceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var model = new NewSimpleChoiceRequest(); // NewSimpleChoiceRequest |  (optional) 

            try
            {
                // Creates a new simple choice entity
                SimpleChoiceModel result = apiInstance.CreateSimpleChoice(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewSimpleChoiceRequest**](NewSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsimplechoicestub"></a>
# **CreateSimpleChoiceStub**
> SimpleChoiceModel CreateSimpleChoiceStub (NewSimpleChoiceStubRequest model = null)

Creates a new simple choice entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateSimpleChoiceStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var model = new NewSimpleChoiceStubRequest(); // NewSimpleChoiceStubRequest |  (optional) 

            try
            {
                // Creates a new simple choice entity
                SimpleChoiceModel result = apiInstance.CreateSimpleChoiceStub(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateSimpleChoiceStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewSimpleChoiceStubRequest**](NewSimpleChoiceStubRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuserdefinedparameter"></a>
# **CreateUserDefinedParameter**
> bool? CreateUserDefinedParameter (string instanceWebhookId, UserDefinedWebhookParameterCreateRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateUserDefinedParameterExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.CreateUserDefinedParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **request** | [**UserDefinedWebhookParameterCreateRequest**](UserDefinedWebhookParameterCreateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresponse"></a>
# **DeleteResponse**
> SimpleChoiceResponseModel DeleteResponse (string simpleChoiceResponseId)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 

            try
            {
                // Deletes the given response
                SimpleChoiceResponseModel result = apiInstance.DeleteResponse(simpleChoiceResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.DeleteResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesimplechoice"></a>
# **DeleteSimpleChoice**
> SimpleChoiceModel DeleteSimpleChoice (string simpleChoiceId)

Delete the given simple choice

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteSimpleChoiceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                // Delete the given simple choice
                SimpleChoiceModel result = apiInstance.DeleteSimpleChoice(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.DeleteSimpleChoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfullbyid"></a>
# **FindFullById**
> SimpleChoiceModel FindFullById (string id)

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

            var apiInstance = new SimpleChoiceApi();
            var id = id_example;  // string | 

            try
            {
                // Finds the full content item by id
                SimpleChoiceModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.FindFullById: " + e.Message );
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

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<SimpleChoiceModel> GetByApplicationFeature (string applicationFeatureId)

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

            var apiInstance = new SimpleChoiceApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetByApplicationFeature: " + e.Message );
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

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesforapplication"></a>
# **GetMessagesForApplication**
> List<SimpleChoiceModel> GetMessagesForApplication (string applicationId)

Gets the simple choices content for the given application  regardless of module

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

            var apiInstance = new SimpleChoiceApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the simple choices content for the given application  regardless of module
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetMessagesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetMessagesForApplication: " + e.Message );
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

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesformodule"></a>
# **GetMessagesForModule**
> List<SimpleChoiceModel> GetMessagesForModule (string applicationModuleId)

Gets the simple choices for the given application module

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

            var apiInstance = new SimpleChoiceApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                // Gets the simple choices for the given application module
                List&lt;SimpleChoiceModel&gt; result = apiInstance.GetMessagesForModule(applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetMessagesForModule: " + e.Message );
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

[**List<SimpleChoiceModel>**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<SimpleChoiceWebhookModel> GetWebhooks (string simpleChoiceId)



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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 

            try
            {
                List&lt;SimpleChoiceWebhookModel&gt; result = apiInstance.GetWebhooks(simpleChoiceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 

### Return type

[**List<SimpleChoiceWebhookModel>**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> SimpleChoiceModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



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

            var apiInstance = new SimpleChoiceApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                SimpleChoiceModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.MoveContentItemToApplicationFeature: " + e.Message );
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

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeuserdefinedparameter"></a>
# **RemoveUserDefinedParameter**
> bool? RemoveUserDefinedParameter (string instanceWebhookId, string parameterName)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveUserDefinedParameterExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.RemoveUserDefinedParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **parameterName** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removewebhook"></a>
# **RemoveWebhook**
> SimpleChoiceWebhookModel RemoveWebhook (string simpleChoiceWebhookId)



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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceWebhookId = simpleChoiceWebhookId_example;  // string | 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.RemoveWebhook(simpleChoiceWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceWebhookId** | **string**|  | 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="togglelive"></a>
# **ToggleLive**
> SimpleChoiceModel ToggleLive (string simpleChoiceId, ToggleLiveRequest model = null)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var model = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                // Toggles the given message as live or not
                SimpleChoiceModel result = apiInstance.ToggleLive(simpleChoiceId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.ToggleLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **model** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> SimpleChoiceWebhookModel UpdateAttachedWebhook (string simpleChoiceId, string webhookInstanceId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                SimpleChoiceWebhookModel result = apiInstance.UpdateAttachedWebhook(simpleChoiceId, webhookInstanceId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceWebhookModel**](SimpleChoiceWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> SimpleChoiceModel UpdateFullContentItem (string contentItemId, SimpleChoiceModel model = null)

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

            var apiInstance = new SimpleChoiceApi();
            var contentItemId = contentItemId_example;  // string | 
            var model = new SimpleChoiceModel(); // SimpleChoiceModel |  (optional) 

            try
            {
                // Updates the content item from a specified dto
                SimpleChoiceModel result = apiInstance.UpdateFullContentItem(contentItemId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **model** | [**SimpleChoiceModel**](SimpleChoiceModel.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessage"></a>
# **UpdateMessage**
> SimpleChoiceModel UpdateMessage (string simpleChoiceId, UpdateSimpleChoiceRequest model = null)

Updates the simple choice with the given fields  If you send null or no value for fields, they won't be updated

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceId = simpleChoiceId_example;  // string | 
            var model = new UpdateSimpleChoiceRequest(); // UpdateSimpleChoiceRequest |  (optional) 

            try
            {
                // Updates the simple choice with the given fields  If you send null or no value for fields, they won't be updated
                SimpleChoiceModel result = apiInstance.UpdateMessage(simpleChoiceId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceId** | **string**|  | 
 **model** | [**UpdateSimpleChoiceRequest**](UpdateSimpleChoiceRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceModel**](SimpleChoiceModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresponse"></a>
# **UpdateResponse**
> SimpleChoiceResponseModel UpdateResponse (string simpleChoiceResponseId, UpdateSimpleChoiceResponseRequest model = null)

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

            var apiInstance = new SimpleChoiceApi();
            var simpleChoiceResponseId = simpleChoiceResponseId_example;  // string | 
            var model = new UpdateSimpleChoiceResponseRequest(); // UpdateSimpleChoiceResponseRequest |  (optional) 

            try
            {
                // Updates the given response
                SimpleChoiceResponseModel result = apiInstance.UpdateResponse(simpleChoiceResponseId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **simpleChoiceResponseId** | **string**|  | 
 **model** | [**UpdateSimpleChoiceResponseRequest**](UpdateSimpleChoiceResponseRequest.md)|  | [optional] 

### Return type

[**SimpleChoiceResponseModel**](SimpleChoiceResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuserdefinedparameter"></a>
# **UpdateUserDefinedParameter**
> bool? UpdateUserDefinedParameter (string instanceWebhookId, UserDefinedWebhookParameterUpdateRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateUserDefinedParameterExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateUserDefinedParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **request** | [**UserDefinedWebhookParameterUpdateRequest**](UserDefinedWebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewebhookparameter"></a>
# **UpdateWebhookParameter**
> bool? UpdateWebhookParameter (string instanceWebhookId, WebhookParameterUpdateRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateWebhookParameterExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SimpleChoiceApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SimpleChoiceApi.UpdateWebhookParameter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instanceWebhookId** | **string**|  | 
 **request** | [**WebhookParameterUpdateRequest**](WebhookParameterUpdateRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

