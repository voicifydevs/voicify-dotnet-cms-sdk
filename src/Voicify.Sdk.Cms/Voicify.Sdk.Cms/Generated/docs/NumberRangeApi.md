# Voicify.Sdk.Cms.Api.NumberRangeApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFile**](NumberRangeApi.md#addaudiofile) | **PUT** /api/NumberRange/{numberRangeResponseId}/addAudioFile/{mediaItemId} | Adds an audio file to the given response
[**AddLargeImage**](NumberRangeApi.md#addlargeimage) | **PUT** /api/NumberRange/{numberRangeResponseId}/addLargeImage/{mediaItemId} | Adds a large image to the given response
[**AddSmallImage**](NumberRangeApi.md#addsmallimage) | **PUT** /api/NumberRange/{numberRangeResponseId}/addSmallImage/{mediaItemId} | Adds a small image item to the given response
[**AddVideoFile**](NumberRangeApi.md#addvideofile) | **PUT** /api/NumberRange/{numberRangeResponseId}/addVideoFile/{mediaItemId} | Adds a video file to the given response
[**AddWebhook**](NumberRangeApi.md#addwebhook) | **POST** /api/NumberRange/{numberRangeId}/webhooks/{webhookId} | 
[**BulkUpdateNumberRange**](NumberRangeApi.md#bulkupdatenumberrange) | **PUT** /api/NumberRange/{numberRangeId}/bulkUpdate | 
[**BulkUpdateNumberRangeStub**](NumberRangeApi.md#bulkupdatenumberrangestub) | **PUT** /api/NumberRange/{numberRangeId}/bulkUpdate/stub | 
[**CopyContentItem**](NumberRangeApi.md#copycontentitem) | **POST** /api/NumberRange/{numberRangeId}/copy | Copies the content item in the same application and feature
[**CreateFullContentItem**](NumberRangeApi.md#createfullcontentitem) | **POST** /api/NumberRange/full | Creates a new content item entity from a dto
[**CreateNumberRange**](NumberRangeApi.md#createnumberrange) | **POST** /api/NumberRange | Creates a new number range entity
[**CreateNumberRangeStub**](NumberRangeApi.md#createnumberrangestub) | **POST** /api/NumberRange/stub | Creates a new number range entity
[**CreateResponse**](NumberRangeApi.md#createresponse) | **POST** /api/NumberRange/{numberRangeId}/response | Creates a new response varation for the given message
[**CreateUserDefinedParameter**](NumberRangeApi.md#createuserdefinedparameter) | **POST** /api/NumberRange/webhook/{instanceWebhookId}/userParameters | 
[**DeleteNumberRange**](NumberRangeApi.md#deletenumberrange) | **DELETE** /api/NumberRange/{numberRangeId} | Delete the given number range
[**DeleteResponse**](NumberRangeApi.md#deleteresponse) | **DELETE** /api/NumberRange/response/{numberRangeResponseId} | Deletes the given response
[**FindFullById**](NumberRangeApi.md#findfullbyid) | **GET** /api/NumberRange/full/{id} | Finds the full content item by id
[**GetByApplicationFeature**](NumberRangeApi.md#getbyapplicationfeature) | **GET** /api/NumberRange/byFeature/{applicationFeatureId} | Gets the content for the given application feature
[**GetMessagesForApplication**](NumberRangeApi.md#getmessagesforapplication) | **GET** /api/NumberRange/{applicationId} | Gets the number ranges content for the given application  regardless of module
[**GetMessagesForModule**](NumberRangeApi.md#getmessagesformodule) | **GET** /api/NumberRange/module/{applicationModuleId} | Gets the number ranges for the given application module
[**GetWebhooks**](NumberRangeApi.md#getwebhooks) | **GET** /api/NumberRange/{numberRangeId}/webhooks | 
[**MoveContentItemToApplicationFeature**](NumberRangeApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/NumberRange/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveUserDefinedParameter**](NumberRangeApi.md#removeuserdefinedparameter) | **DELETE** /api/NumberRange/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](NumberRangeApi.md#removewebhook) | **DELETE** /api/NumberRange/webhook/{numberRangeWebhookId} | 
[**ToggleLive**](NumberRangeApi.md#togglelive) | **PUT** /api/NumberRange/{numberRangeId}/isLive | Toggles the given message as live or not
[**UpdateAttachedWebhook**](NumberRangeApi.md#updateattachedwebhook) | **PUT** /api/NumberRange/{numberRangeId}/webhooks/{webhookInstanceId} | 
[**UpdateFullContentItem**](NumberRangeApi.md#updatefullcontentitem) | **PUT** /api/NumberRange/{contentItemId}/full | Updates the content item from a specified dto
[**UpdateMessage**](NumberRangeApi.md#updatemessage) | **PUT** /api/NumberRange/{numberRangeId} | Updates the number range with the given fields  If you send null or no value for fields, they won&#39;t be updated
[**UpdateResponse**](NumberRangeApi.md#updateresponse) | **PUT** /api/NumberRange/response/{numberRangeResponseId} | Updates the given response
[**UpdateUserDefinedParameter**](NumberRangeApi.md#updateuserdefinedparameter) | **PUT** /api/NumberRange/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](NumberRangeApi.md#updatewebhookparameter) | **PUT** /api/NumberRange/webhook/{instanceWebhookId}/webhookParameters | 


<a name="addaudiofile"></a>
# **AddAudioFile**
> NumberRangeResponseModel AddAudioFile (string numberRangeResponseId, string mediaItemId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds an audio file to the given response
                NumberRangeResponseModel result = apiInstance.AddAudioFile(numberRangeResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.AddAudioFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlargeimage"></a>
# **AddLargeImage**
> NumberRangeResponseModel AddLargeImage (string numberRangeResponseId, string mediaItemId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a large image to the given response
                NumberRangeResponseModel result = apiInstance.AddLargeImage(numberRangeResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsmallimage"></a>
# **AddSmallImage**
> NumberRangeResponseModel AddSmallImage (string numberRangeResponseId, string mediaItemId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a small image item to the given response
                NumberRangeResponseModel result = apiInstance.AddSmallImage(numberRangeResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideofile"></a>
# **AddVideoFile**
> NumberRangeResponseModel AddVideoFile (string numberRangeResponseId, string mediaItemId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a video file to the given response
                NumberRangeResponseModel result = apiInstance.AddVideoFile(numberRangeResponseId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> NumberRangeWebhookModel AddWebhook (string numberRangeId, string webhookId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                NumberRangeWebhookModel result = apiInstance.AddWebhook(numberRangeId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**NumberRangeWebhookModel**](NumberRangeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatenumberrange"></a>
# **BulkUpdateNumberRange**
> NumberRangeModel BulkUpdateNumberRange (string numberRangeId, BulkUpdateNumberRangeRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateNumberRangeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var model = new BulkUpdateNumberRangeRequest(); // BulkUpdateNumberRangeRequest |  (optional) 

            try
            {
                NumberRangeModel result = apiInstance.BulkUpdateNumberRange(numberRangeId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.BulkUpdateNumberRange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **model** | [**BulkUpdateNumberRangeRequest**](BulkUpdateNumberRangeRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatenumberrangestub"></a>
# **BulkUpdateNumberRangeStub**
> NumberRangeModel BulkUpdateNumberRangeStub (string numberRangeId, BulkUpdateNumberRangeStubRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateNumberRangeStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var model = new BulkUpdateNumberRangeStubRequest(); // BulkUpdateNumberRangeStubRequest |  (optional) 

            try
            {
                NumberRangeModel result = apiInstance.BulkUpdateNumberRangeStub(numberRangeId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.BulkUpdateNumberRangeStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **model** | [**BulkUpdateNumberRangeStubRequest**](BulkUpdateNumberRangeStubRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copycontentitem"></a>
# **CopyContentItem**
> NumberRangeModel CopyContentItem (string numberRangeId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 

            try
            {
                // Copies the content item in the same application and feature
                NumberRangeModel result = apiInstance.CopyContentItem(numberRangeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> NumberRangeModel CreateFullContentItem (NumberRangeModel model = null)

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

            var apiInstance = new NumberRangeApi();
            var model = new NumberRangeModel(); // NumberRangeModel |  (optional) 

            try
            {
                // Creates a new content item entity from a dto
                NumberRangeModel result = apiInstance.CreateFullContentItem(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NumberRangeModel**](NumberRangeModel.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnumberrange"></a>
# **CreateNumberRange**
> NumberRangeModel CreateNumberRange (NewNumberRangeRequest model = null)

Creates a new number range entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateNumberRangeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NumberRangeApi();
            var model = new NewNumberRangeRequest(); // NewNumberRangeRequest |  (optional) 

            try
            {
                // Creates a new number range entity
                NumberRangeModel result = apiInstance.CreateNumberRange(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CreateNumberRange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewNumberRangeRequest**](NewNumberRangeRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createnumberrangestub"></a>
# **CreateNumberRangeStub**
> NumberRangeModel CreateNumberRangeStub (NewNumberRangeStubRequest model = null)

Creates a new number range entity

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateNumberRangeStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NumberRangeApi();
            var model = new NewNumberRangeStubRequest(); // NewNumberRangeStubRequest |  (optional) 

            try
            {
                // Creates a new number range entity
                NumberRangeModel result = apiInstance.CreateNumberRangeStub(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CreateNumberRangeStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewNumberRangeStubRequest**](NewNumberRangeStubRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createresponse"></a>
# **CreateResponse**
> NumberRangeResponseModel CreateResponse (string numberRangeId, NewNumberRangeResponseRequest model = null)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var model = new NewNumberRangeResponseRequest(); // NewNumberRangeResponseRequest |  (optional) 

            try
            {
                // Creates a new response varation for the given message
                NumberRangeResponseModel result = apiInstance.CreateResponse(numberRangeId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CreateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **model** | [**NewNumberRangeResponseRequest**](NewNumberRangeResponseRequest.md)|  | [optional] 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

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

            var apiInstance = new NumberRangeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.CreateUserDefinedParameter: " + e.Message );
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

<a name="deletenumberrange"></a>
# **DeleteNumberRange**
> NumberRangeModel DeleteNumberRange (string numberRangeId)

Delete the given number range

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteNumberRangeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 

            try
            {
                // Delete the given number range
                NumberRangeModel result = apiInstance.DeleteNumberRange(numberRangeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.DeleteNumberRange: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresponse"></a>
# **DeleteResponse**
> NumberRangeResponseModel DeleteResponse (string numberRangeResponseId)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 

            try
            {
                // Deletes the given response
                NumberRangeResponseModel result = apiInstance.DeleteResponse(numberRangeResponseId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.DeleteResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfullbyid"></a>
# **FindFullById**
> NumberRangeModel FindFullById (string id)

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

            var apiInstance = new NumberRangeApi();
            var id = id_example;  // string | 

            try
            {
                // Finds the full content item by id
                NumberRangeModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.FindFullById: " + e.Message );
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

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<NumberRangeModel> GetByApplicationFeature (string applicationFeatureId)

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

            var apiInstance = new NumberRangeApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature
                List&lt;NumberRangeModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.GetByApplicationFeature: " + e.Message );
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

[**List<NumberRangeModel>**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesforapplication"></a>
# **GetMessagesForApplication**
> List<NumberRangeModel> GetMessagesForApplication (string applicationId)

Gets the number ranges content for the given application  regardless of module

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

            var apiInstance = new NumberRangeApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the number ranges content for the given application  regardless of module
                List&lt;NumberRangeModel&gt; result = apiInstance.GetMessagesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.GetMessagesForApplication: " + e.Message );
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

[**List<NumberRangeModel>**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmessagesformodule"></a>
# **GetMessagesForModule**
> List<NumberRangeModel> GetMessagesForModule (string applicationModuleId)

Gets the number ranges for the given application module

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

            var apiInstance = new NumberRangeApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                // Gets the number ranges for the given application module
                List&lt;NumberRangeModel&gt; result = apiInstance.GetMessagesForModule(applicationModuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.GetMessagesForModule: " + e.Message );
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

[**List<NumberRangeModel>**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<NumberRangeWebhookModel> GetWebhooks (string numberRangeId)



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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 

            try
            {
                List&lt;NumberRangeWebhookModel&gt; result = apiInstance.GetWebhooks(numberRangeId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 

### Return type

[**List<NumberRangeWebhookModel>**](NumberRangeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> NumberRangeModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



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

            var apiInstance = new NumberRangeApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                NumberRangeModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.MoveContentItemToApplicationFeature: " + e.Message );
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

[**NumberRangeModel**](NumberRangeModel.md)

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

            var apiInstance = new NumberRangeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.RemoveUserDefinedParameter: " + e.Message );
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
> NumberRangeWebhookModel RemoveWebhook (string numberRangeWebhookId)



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

            var apiInstance = new NumberRangeApi();
            var numberRangeWebhookId = numberRangeWebhookId_example;  // string | 

            try
            {
                NumberRangeWebhookModel result = apiInstance.RemoveWebhook(numberRangeWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeWebhookId** | **string**|  | 

### Return type

[**NumberRangeWebhookModel**](NumberRangeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="togglelive"></a>
# **ToggleLive**
> NumberRangeModel ToggleLive (string numberRangeId, ToggleLiveRequest model = null)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var model = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                // Toggles the given message as live or not
                NumberRangeModel result = apiInstance.ToggleLive(numberRangeId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.ToggleLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **model** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> NumberRangeWebhookModel UpdateAttachedWebhook (string numberRangeId, string webhookInstanceId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                NumberRangeWebhookModel result = apiInstance.UpdateAttachedWebhook(numberRangeId, webhookInstanceId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**NumberRangeWebhookModel**](NumberRangeWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> NumberRangeModel UpdateFullContentItem (string contentItemId, NumberRangeModel model = null)

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

            var apiInstance = new NumberRangeApi();
            var contentItemId = contentItemId_example;  // string | 
            var model = new NumberRangeModel(); // NumberRangeModel |  (optional) 

            try
            {
                // Updates the content item from a specified dto
                NumberRangeModel result = apiInstance.UpdateFullContentItem(contentItemId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **model** | [**NumberRangeModel**](NumberRangeModel.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemessage"></a>
# **UpdateMessage**
> NumberRangeModel UpdateMessage (string numberRangeId, UpdateNumberRangeRequest model = null)

Updates the number range with the given fields  If you send null or no value for fields, they won't be updated

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

            var apiInstance = new NumberRangeApi();
            var numberRangeId = numberRangeId_example;  // string | 
            var model = new UpdateNumberRangeRequest(); // UpdateNumberRangeRequest |  (optional) 

            try
            {
                // Updates the number range with the given fields  If you send null or no value for fields, they won't be updated
                NumberRangeModel result = apiInstance.UpdateMessage(numberRangeId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeId** | **string**|  | 
 **model** | [**UpdateNumberRangeRequest**](UpdateNumberRangeRequest.md)|  | [optional] 

### Return type

[**NumberRangeModel**](NumberRangeModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresponse"></a>
# **UpdateResponse**
> NumberRangeResponseModel UpdateResponse (string numberRangeResponseId, UpdateNumberRangeResponseRequest model = null)

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

            var apiInstance = new NumberRangeApi();
            var numberRangeResponseId = numberRangeResponseId_example;  // string | 
            var model = new UpdateNumberRangeResponseRequest(); // UpdateNumberRangeResponseRequest |  (optional) 

            try
            {
                // Updates the given response
                NumberRangeResponseModel result = apiInstance.UpdateResponse(numberRangeResponseId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateResponse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **numberRangeResponseId** | **string**|  | 
 **model** | [**UpdateNumberRangeResponseRequest**](UpdateNumberRangeResponseRequest.md)|  | [optional] 

### Return type

[**NumberRangeResponseModel**](NumberRangeResponseModel.md)

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

            var apiInstance = new NumberRangeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateUserDefinedParameter: " + e.Message );
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

            var apiInstance = new NumberRangeApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NumberRangeApi.UpdateWebhookParameter: " + e.Message );
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

