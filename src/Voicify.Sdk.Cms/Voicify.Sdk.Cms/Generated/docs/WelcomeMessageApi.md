# Voicify.Sdk.Cms.Api.WelcomeMessageApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFileImage**](WelcomeMessageApi.md#addaudiofileimage) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/addAudioFile/{mediaItemId} | Adds an audio file to the welcome message
[**AddLargeImage**](WelcomeMessageApi.md#addlargeimage) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/addLargeImage/{mediaItemId} | Adds a large image to the welcome message
[**AddSmallImage**](WelcomeMessageApi.md#addsmallimage) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/addSmallImage/{mediaItemId} | Adds a small image to the welcome message
[**AddVideoFile**](WelcomeMessageApi.md#addvideofile) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/addVideoFile/{mediaItemId} | Adds a video file to the welcome message
[**AddWebhook**](WelcomeMessageApi.md#addwebhook) | **POST** /api/WelcomeMessage/{welcomeMessageId}/webhooks/{webhookId} | 
[**AddWelcomeMessage**](WelcomeMessageApi.md#addwelcomemessage) | **POST** /api/WelcomeMessage/{applicationId} | Adds a new welcome message to the given application
[**AddWelcomeMessageStub**](WelcomeMessageApi.md#addwelcomemessagestub) | **POST** /api/WelcomeMessage/{applicationId}/stub | Adds a new welcome message to the given application
[**CopyContentItem**](WelcomeMessageApi.md#copycontentitem) | **POST** /api/WelcomeMessage/{welcomeMessageId}/copy | Copies the content item in the same application and feature
[**CreateFullContentItem**](WelcomeMessageApi.md#createfullcontentitem) | **POST** /api/WelcomeMessage/full | Creates a new content item entity from a dto
[**CreateUserDefinedParameter**](WelcomeMessageApi.md#createuserdefinedparameter) | **POST** /api/WelcomeMessage/webhook/{instanceWebhookId}/userParameters | 
[**DeleteWelcomeMessage**](WelcomeMessageApi.md#deletewelcomemessage) | **DELETE** /api/WelcomeMessage/{welcomeMessageId} | Deletes the given message
[**FindFullById**](WelcomeMessageApi.md#findfullbyid) | **GET** /api/WelcomeMessage/full/{id} | Finds the full content item by id
[**GetByApplicationFeature**](WelcomeMessageApi.md#getbyapplicationfeature) | **GET** /api/WelcomeMessage/byFeature/{applicationFeatureId} | Gets the content for the given application feature
[**GetWebhooks**](WelcomeMessageApi.md#getwebhooks) | **GET** /api/WelcomeMessage/{welcomeMessageId}/webhooks | 
[**GetWelcomeMessagesForApplication**](WelcomeMessageApi.md#getwelcomemessagesforapplication) | **GET** /api/WelcomeMessage/{applicationId} | Gets the welcome messages for the given application
[**MoveContentItemToApplicationFeature**](WelcomeMessageApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/WelcomeMessage/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveUserDefinedParameter**](WelcomeMessageApi.md#removeuserdefinedparameter) | **DELETE** /api/WelcomeMessage/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](WelcomeMessageApi.md#removewebhook) | **DELETE** /api/WelcomeMessage/webhook/{welcomeMessageWebhookId} | 
[**ToggleIsLive**](WelcomeMessageApi.md#toggleislive) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/isLive | Toggles whether the given welcome Message is live or not
[**UpdateAttachedWebhook**](WelcomeMessageApi.md#updateattachedwebhook) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/webhooks/{webhookInstanceId} | 
[**UpdateFullContentItem**](WelcomeMessageApi.md#updatefullcontentitem) | **PUT** /api/WelcomeMessage/{contentItemId}/full | Updates the content item from a specified dto
[**UpdateUserDefinedParameter**](WelcomeMessageApi.md#updateuserdefinedparameter) | **PUT** /api/WelcomeMessage/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](WelcomeMessageApi.md#updatewebhookparameter) | **PUT** /api/WelcomeMessage/webhook/{instanceWebhookId}/webhookParameters | 
[**UpdateWelcomeMessage**](WelcomeMessageApi.md#updatewelcomemessage) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/update | Updates the content of the given welcome message id
[**UpdateWelcomeMessageStub**](WelcomeMessageApi.md#updatewelcomemessagestub) | **PUT** /api/WelcomeMessage/{welcomeMessageId}/update/stub | Updates the content of the given welcome message id


<a name="addaudiofileimage"></a>
# **AddAudioFileImage**
> WelcomeMessageModel AddAudioFileImage (string welcomeMessageId, string mediaItemId)

Adds an audio file to the welcome message

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAudioFileImageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds an audio file to the welcome message
                WelcomeMessageModel result = apiInstance.AddAudioFileImage(welcomeMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddAudioFileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlargeimage"></a>
# **AddLargeImage**
> WelcomeMessageModel AddLargeImage (string welcomeMessageId, string mediaItemId)

Adds a large image to the welcome message

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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a large image to the welcome message
                WelcomeMessageModel result = apiInstance.AddLargeImage(welcomeMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsmallimage"></a>
# **AddSmallImage**
> WelcomeMessageModel AddSmallImage (string welcomeMessageId, string mediaItemId)

Adds a small image to the welcome message

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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a small image to the welcome message
                WelcomeMessageModel result = apiInstance.AddSmallImage(welcomeMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideofile"></a>
# **AddVideoFile**
> WelcomeMessageModel AddVideoFile (string welcomeMessageId, string mediaItemId)

Adds a video file to the welcome message

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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a video file to the welcome message
                WelcomeMessageModel result = apiInstance.AddVideoFile(welcomeMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> WelcomeMessageWebhookModel AddWebhook (string welcomeMessageId, string webhookId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                WelcomeMessageWebhookModel result = apiInstance.AddWebhook(welcomeMessageId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageWebhookModel**](WelcomeMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwelcomemessage"></a>
# **AddWelcomeMessage**
> WelcomeMessageModel AddWelcomeMessage (string applicationId, NewWelcomeMessageRequest model = null)

Adds a new welcome message to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddWelcomeMessageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewWelcomeMessageRequest(); // NewWelcomeMessageRequest |  (optional) 

            try
            {
                // Adds a new welcome message to the given application
                WelcomeMessageModel result = apiInstance.AddWelcomeMessage(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddWelcomeMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewWelcomeMessageRequest**](NewWelcomeMessageRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwelcomemessagestub"></a>
# **AddWelcomeMessageStub**
> WelcomeMessageModel AddWelcomeMessageStub (string applicationId, NewWelcomeMessageStubRequest model = null)

Adds a new welcome message to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddWelcomeMessageStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewWelcomeMessageStubRequest(); // NewWelcomeMessageStubRequest |  (optional) 

            try
            {
                // Adds a new welcome message to the given application
                WelcomeMessageModel result = apiInstance.AddWelcomeMessageStub(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.AddWelcomeMessageStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewWelcomeMessageStubRequest**](NewWelcomeMessageStubRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copycontentitem"></a>
# **CopyContentItem**
> WelcomeMessageModel CopyContentItem (string welcomeMessageId)

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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 

            try
            {
                // Copies the content item in the same application and feature
                WelcomeMessageModel result = apiInstance.CopyContentItem(welcomeMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> WelcomeMessageModel CreateFullContentItem (WelcomeMessageModel model = null)

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

            var apiInstance = new WelcomeMessageApi();
            var model = new WelcomeMessageModel(); // WelcomeMessageModel |  (optional) 

            try
            {
                // Creates a new content item entity from a dto
                WelcomeMessageModel result = apiInstance.CreateFullContentItem(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**WelcomeMessageModel**](WelcomeMessageModel.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

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

            var apiInstance = new WelcomeMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.CreateUserDefinedParameter: " + e.Message );
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

<a name="deletewelcomemessage"></a>
# **DeleteWelcomeMessage**
> WelcomeMessageModel DeleteWelcomeMessage (string welcomeMessageId)

Deletes the given message

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteWelcomeMessageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 

            try
            {
                // Deletes the given message
                WelcomeMessageModel result = apiInstance.DeleteWelcomeMessage(welcomeMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.DeleteWelcomeMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfullbyid"></a>
# **FindFullById**
> WelcomeMessageModel FindFullById (string id)

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

            var apiInstance = new WelcomeMessageApi();
            var id = id_example;  // string | 

            try
            {
                // Finds the full content item by id
                WelcomeMessageModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.FindFullById: " + e.Message );
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

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<WelcomeMessageModel> GetByApplicationFeature (string applicationFeatureId)

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

            var apiInstance = new WelcomeMessageApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature
                List&lt;WelcomeMessageModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.GetByApplicationFeature: " + e.Message );
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

[**List<WelcomeMessageModel>**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<WelcomeMessageWebhookModel> GetWebhooks (string welcomeMessageId)



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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 

            try
            {
                List&lt;WelcomeMessageWebhookModel&gt; result = apiInstance.GetWebhooks(welcomeMessageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 

### Return type

[**List<WelcomeMessageWebhookModel>**](WelcomeMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwelcomemessagesforapplication"></a>
# **GetWelcomeMessagesForApplication**
> List<WelcomeMessageModel> GetWelcomeMessagesForApplication (string applicationId)

Gets the welcome messages for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetWelcomeMessagesForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the welcome messages for the given application
                List&lt;WelcomeMessageModel&gt; result = apiInstance.GetWelcomeMessagesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.GetWelcomeMessagesForApplication: " + e.Message );
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

[**List<WelcomeMessageModel>**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> WelcomeMessageModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



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

            var apiInstance = new WelcomeMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                WelcomeMessageModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.MoveContentItemToApplicationFeature: " + e.Message );
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

[**WelcomeMessageModel**](WelcomeMessageModel.md)

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

            var apiInstance = new WelcomeMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.RemoveUserDefinedParameter: " + e.Message );
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
> WelcomeMessageWebhookModel RemoveWebhook (string welcomeMessageWebhookId)



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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageWebhookId = welcomeMessageWebhookId_example;  // string | 

            try
            {
                WelcomeMessageWebhookModel result = apiInstance.RemoveWebhook(welcomeMessageWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageWebhookId** | **string**|  | 

### Return type

[**WelcomeMessageWebhookModel**](WelcomeMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toggleislive"></a>
# **ToggleIsLive**
> WelcomeMessageModel ToggleIsLive (string welcomeMessageId, ToggleLiveRequest model = null)

Toggles whether the given welcome Message is live or not

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ToggleIsLiveExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var model = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                // Toggles whether the given welcome Message is live or not
                WelcomeMessageModel result = apiInstance.ToggleIsLive(welcomeMessageId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.ToggleIsLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **model** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> WelcomeMessageWebhookModel UpdateAttachedWebhook (string welcomeMessageId, string webhookInstanceId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                WelcomeMessageWebhookModel result = apiInstance.UpdateAttachedWebhook(welcomeMessageId, webhookInstanceId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageWebhookModel**](WelcomeMessageWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> WelcomeMessageModel UpdateFullContentItem (string contentItemId, WelcomeMessageModel model = null)

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

            var apiInstance = new WelcomeMessageApi();
            var contentItemId = contentItemId_example;  // string | 
            var model = new WelcomeMessageModel(); // WelcomeMessageModel |  (optional) 

            try
            {
                // Updates the content item from a specified dto
                WelcomeMessageModel result = apiInstance.UpdateFullContentItem(contentItemId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **model** | [**WelcomeMessageModel**](WelcomeMessageModel.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

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

            var apiInstance = new WelcomeMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateUserDefinedParameter: " + e.Message );
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

            var apiInstance = new WelcomeMessageApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateWebhookParameter: " + e.Message );
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

<a name="updatewelcomemessage"></a>
# **UpdateWelcomeMessage**
> WelcomeMessageModel UpdateWelcomeMessage (string welcomeMessageId, UpdateWelcomeMessageRequest model = null)

Updates the content of the given welcome message id

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateWelcomeMessageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var model = new UpdateWelcomeMessageRequest(); // UpdateWelcomeMessageRequest |  (optional) 

            try
            {
                // Updates the content of the given welcome message id
                WelcomeMessageModel result = apiInstance.UpdateWelcomeMessage(welcomeMessageId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateWelcomeMessage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **model** | [**UpdateWelcomeMessageRequest**](UpdateWelcomeMessageRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatewelcomemessagestub"></a>
# **UpdateWelcomeMessageStub**
> WelcomeMessageModel UpdateWelcomeMessageStub (string welcomeMessageId, UpdateWelcomeMessageStubRequest model = null)

Updates the content of the given welcome message id

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateWelcomeMessageStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WelcomeMessageApi();
            var welcomeMessageId = welcomeMessageId_example;  // string | 
            var model = new UpdateWelcomeMessageStubRequest(); // UpdateWelcomeMessageStubRequest |  (optional) 

            try
            {
                // Updates the content of the given welcome message id
                WelcomeMessageModel result = apiInstance.UpdateWelcomeMessageStub(welcomeMessageId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WelcomeMessageApi.UpdateWelcomeMessageStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **welcomeMessageId** | **string**|  | 
 **model** | [**UpdateWelcomeMessageStubRequest**](UpdateWelcomeMessageStubRequest.md)|  | [optional] 

### Return type

[**WelcomeMessageModel**](WelcomeMessageModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

