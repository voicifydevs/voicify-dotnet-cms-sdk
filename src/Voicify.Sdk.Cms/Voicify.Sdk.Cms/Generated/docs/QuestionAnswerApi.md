# Voicify.Sdk.Cms.Api.QuestionAnswerApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAudioFileImage**](QuestionAnswerApi.md#addaudiofileimage) | **PUT** /api/QuestionAnswer/{answerMessageId}/addAudioFile/{mediaItemId} | Adds an audio file to the answer message
[**AddLargeImage**](QuestionAnswerApi.md#addlargeimage) | **PUT** /api/QuestionAnswer/{answerMessageId}/addLargeImage/{mediaItemId} | Adds a large image to the answer message
[**AddOrUpdateRequiredPhrases**](QuestionAnswerApi.md#addorupdaterequiredphrases) | **PUT** /api/QuestionAnswer/{contentItemId}/RequiredPhrases | Adds required user phrases to a quesiton answer item.
[**AddSmallImage**](QuestionAnswerApi.md#addsmallimage) | **PUT** /api/QuestionAnswer/{answerMessageId}/addSmallImage/{mediaItemId} | Adds a small image to the answer message
[**AddVideoFile**](QuestionAnswerApi.md#addvideofile) | **PUT** /api/QuestionAnswer/{answerMessageId}/addVideoFile/{mediaItemId} | Adds a video file to the answer message
[**AddWebhook**](QuestionAnswerApi.md#addwebhook) | **POST** /api/QuestionAnswer/{questionAnswerId}/webhooks/{webhookId} | Add a webhook to a question answer item
[**BulkUpdate**](QuestionAnswerApi.md#bulkupdate) | **PUT** /api/QuestionAnswer/{questionAnswerId}/bulkUpdate | Bulk updates the question answer and the internal variations
[**BulkUpdateStub**](QuestionAnswerApi.md#bulkupdatestub) | **PUT** /api/QuestionAnswer/{questionAnswerId}/bulkUpdate/stub | Bulk updates the question answer and the internal variations
[**CopyContentItem**](QuestionAnswerApi.md#copycontentitem) | **POST** /api/QuestionAnswer/{questionAnswerId}/copy | Copies the content item in the same application and feature
[**CountByApplicationFeature**](QuestionAnswerApi.md#countbyapplicationfeature) | **GET** /api/QuestionAnswer/byFeature/{applicationFeatureId}/count | Gets the content for the given application feature with skip/take
[**Create**](QuestionAnswerApi.md#create) | **POST** /api/QuestionAnswer | Create a new FAQ
[**CreateAnswer**](QuestionAnswerApi.md#createanswer) | **POST** /api/QuestionAnswer/{questionAnswerId}/Answer | Add an answer to the FAQ set
[**CreateFullContentItem**](QuestionAnswerApi.md#createfullcontentitem) | **POST** /api/QuestionAnswer/full | Creates a new content item entity from a dto
[**CreateQuestion**](QuestionAnswerApi.md#createquestion) | **POST** /api/QuestionAnswer/{questionAnswerId}/Question | Add a question to the FAQ set
[**CreateStub**](QuestionAnswerApi.md#createstub) | **POST** /api/QuestionAnswer/stub | Create a new FAQ
[**CreateUserDefinedParameter**](QuestionAnswerApi.md#createuserdefinedparameter) | **POST** /api/QuestionAnswer/webhook/{instanceWebhookId}/userParameters | 
[**Delete**](QuestionAnswerApi.md#delete) | **DELETE** /api/QuestionAnswer/{questionAnswerId} | Delete an FAQ
[**DeleteAnswer**](QuestionAnswerApi.md#deleteanswer) | **DELETE** /api/QuestionAnswer/answer/{answerId} | Delete an answer
[**DeleteQuestion**](QuestionAnswerApi.md#deletequestion) | **DELETE** /api/QuestionAnswer/question/{questionId} | Delete a question
[**EditAnswer**](QuestionAnswerApi.md#editanswer) | **PUT** /api/QuestionAnswer/Answer/{answerId} | Edit a given Answer
[**EditQuestion**](QuestionAnswerApi.md#editquestion) | **PUT** /api/QuestionAnswer/Question/{questionId} | Edit a given question
[**FindFullById**](QuestionAnswerApi.md#findfullbyid) | **GET** /api/QuestionAnswer/full/{id} | Finds the full content item by id
[**Get**](QuestionAnswerApi.md#get) | **GET** /api/QuestionAnswer/{questionAnswerId} | Get an FAQ by its ID
[**GetAllByApplicationFeature**](QuestionAnswerApi.md#getallbyapplicationfeature) | **GET** /api/QuestionAnswer/byFeature/{applicationFeatureId} | Gets the content for the given application feature
[**GetByApplicationFeature**](QuestionAnswerApi.md#getbyapplicationfeature) | **GET** /api/QuestionAnswer/byFeature/{applicationFeatureId}/paginated | Gets the content for the given application feature with skip/take
[**GetQuestionAnswersForApplication**](QuestionAnswerApi.md#getquestionanswersforapplication) | **GET** /api/QuestionAnswer/{applicationId}/faqs | Get the FAQs for a given application
[**GetWebhooks**](QuestionAnswerApi.md#getwebhooks) | **GET** /api/QuestionAnswer/{questionAnswerId}/webhooks | Get the webhooks associated with a question answer item
[**MoveContentItemToApplicationFeature**](QuestionAnswerApi.md#movecontentitemtoapplicationfeature) | **PUT** /api/QuestionAnswer/{contentItemId}/MoveToFeature/{applicationFeatureId} | 
[**RemoveUserDefinedParameter**](QuestionAnswerApi.md#removeuserdefinedparameter) | **DELETE** /api/QuestionAnswer/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](QuestionAnswerApi.md#removewebhook) | **DELETE** /api/QuestionAnswer/webhook/{questionAnswerWebhookId} | Delete a webhook from a question answer item
[**ToggleIsLive**](QuestionAnswerApi.md#toggleislive) | **PUT** /api/QuestionAnswer/{questionAnswerId}/isLive | Toggles whether the given FAQ is live or not
[**UpdateAttachedWebhook**](QuestionAnswerApi.md#updateattachedwebhook) | **PUT** /api/QuestionAnswer/{questionAnswerId}/webhooks/{instanceWebhookId} | Update a webhook on a question answer item
[**UpdateFullContentItem**](QuestionAnswerApi.md#updatefullcontentitem) | **PUT** /api/QuestionAnswer/{contentItemId}/full | Updates the content item from a specified dto
[**UpdateUserDefinedParameter**](QuestionAnswerApi.md#updateuserdefinedparameter) | **PUT** /api/QuestionAnswer/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](QuestionAnswerApi.md#updatewebhookparameter) | **PUT** /api/QuestionAnswer/webhook/{instanceWebhookId}/webhookParameters | 


<a name="addaudiofileimage"></a>
# **AddAudioFileImage**
> AnswerModel AddAudioFileImage (string answerMessageId, string mediaItemId)

Adds an audio file to the answer message

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

            var apiInstance = new QuestionAnswerApi();
            var answerMessageId = answerMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds an audio file to the answer message
                AnswerModel result = apiInstance.AddAudioFileImage(answerMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddAudioFileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlargeimage"></a>
# **AddLargeImage**
> AnswerModel AddLargeImage (string answerMessageId, string mediaItemId)

Adds a large image to the answer message

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

            var apiInstance = new QuestionAnswerApi();
            var answerMessageId = answerMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a large image to the answer message
                AnswerModel result = apiInstance.AddLargeImage(answerMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddLargeImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addorupdaterequiredphrases"></a>
# **AddOrUpdateRequiredPhrases**
> QuestionAnswerModel AddOrUpdateRequiredPhrases (string contentItemId, RequiredPhrasesRequest request = null)

Adds required user phrases to a quesiton answer item.

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddOrUpdateRequiredPhrasesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var contentItemId = contentItemId_example;  // string | 
            var request = new RequiredPhrasesRequest(); // RequiredPhrasesRequest |  (optional) 

            try
            {
                // Adds required user phrases to a quesiton answer item.
                QuestionAnswerModel result = apiInstance.AddOrUpdateRequiredPhrases(contentItemId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddOrUpdateRequiredPhrases: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **request** | [**RequiredPhrasesRequest**](RequiredPhrasesRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addsmallimage"></a>
# **AddSmallImage**
> AnswerModel AddSmallImage (string answerMessageId, string mediaItemId)

Adds a small image to the answer message

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

            var apiInstance = new QuestionAnswerApi();
            var answerMessageId = answerMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a small image to the answer message
                AnswerModel result = apiInstance.AddSmallImage(answerMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddSmallImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addvideofile"></a>
# **AddVideoFile**
> AnswerModel AddVideoFile (string answerMessageId, string mediaItemId)

Adds a video file to the answer message

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

            var apiInstance = new QuestionAnswerApi();
            var answerMessageId = answerMessageId_example;  // string | 
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Adds a video file to the answer message
                AnswerModel result = apiInstance.AddVideoFile(answerMessageId, mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddVideoFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerMessageId** | **string**|  | 
 **mediaItemId** | **string**|  | 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> QuestionAnswerWebhookModel AddWebhook (string questionAnswerId, string webhookId, WebhookParametersRequest parameters = null)

Add a webhook to a question answer item

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                // Add a webhook to a question answer item
                QuestionAnswerWebhookModel result = apiInstance.AddWebhook(questionAnswerId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerWebhookModel**](QuestionAnswerWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdate"></a>
# **BulkUpdate**
> QuestionAnswerModel BulkUpdate (string questionAnswerId, BulkQuestionAnswerUpdateRequest model = null)

Bulk updates the question answer and the internal variations

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var model = new BulkQuestionAnswerUpdateRequest(); // BulkQuestionAnswerUpdateRequest |  (optional) 

            try
            {
                // Bulk updates the question answer and the internal variations
                QuestionAnswerModel result = apiInstance.BulkUpdate(questionAnswerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.BulkUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **model** | [**BulkQuestionAnswerUpdateRequest**](BulkQuestionAnswerUpdateRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkupdatestub"></a>
# **BulkUpdateStub**
> QuestionAnswerModel BulkUpdateStub (string questionAnswerId, BulkQuestionAnswerUpdateStubRequest model = null)

Bulk updates the question answer and the internal variations

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkUpdateStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var model = new BulkQuestionAnswerUpdateStubRequest(); // BulkQuestionAnswerUpdateStubRequest |  (optional) 

            try
            {
                // Bulk updates the question answer and the internal variations
                QuestionAnswerModel result = apiInstance.BulkUpdateStub(questionAnswerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.BulkUpdateStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **model** | [**BulkQuestionAnswerUpdateStubRequest**](BulkQuestionAnswerUpdateStubRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="copycontentitem"></a>
# **CopyContentItem**
> QuestionAnswerModel CopyContentItem (string questionAnswerId)

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 

            try
            {
                // Copies the content item in the same application and feature
                QuestionAnswerModel result = apiInstance.CopyContentItem(questionAnswerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CopyContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="countbyapplicationfeature"></a>
# **CountByApplicationFeature**
> int? CountByApplicationFeature (string applicationFeatureId)

Gets the content for the given application feature with skip/take

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CountByApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature with skip/take
                int? result = apiInstance.CountByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CountByApplicationFeature: " + e.Message );
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

**int?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> QuestionAnswerModel Create (NewQuestionAnswerRequest model = null)

Create a new FAQ

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var model = new NewQuestionAnswerRequest(); // NewQuestionAnswerRequest | Initial question and answer (optional) 

            try
            {
                // Create a new FAQ
                QuestionAnswerModel result = apiInstance.Create(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewQuestionAnswerRequest**](NewQuestionAnswerRequest.md)| Initial question and answer | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createanswer"></a>
# **CreateAnswer**
> AnswerModel CreateAnswer (string questionAnswerId, CreateAnswerRequest model = null)

Add an answer to the FAQ set

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateAnswerExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var model = new CreateAnswerRequest(); // CreateAnswerRequest |  (optional) 

            try
            {
                // Add an answer to the FAQ set
                AnswerModel result = apiInstance.CreateAnswer(questionAnswerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CreateAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **model** | [**CreateAnswerRequest**](CreateAnswerRequest.md)|  | [optional] 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfullcontentitem"></a>
# **CreateFullContentItem**
> QuestionAnswerModel CreateFullContentItem (QuestionAnswerModel model = null)

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

            var apiInstance = new QuestionAnswerApi();
            var model = new QuestionAnswerModel(); // QuestionAnswerModel |  (optional) 

            try
            {
                // Creates a new content item entity from a dto
                QuestionAnswerModel result = apiInstance.CreateFullContentItem(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CreateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**QuestionAnswerModel**](QuestionAnswerModel.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createquestion"></a>
# **CreateQuestion**
> QuestionModel CreateQuestion (string questionAnswerId, CreateQuestionRequest model = null)

Add a question to the FAQ set

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateQuestionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var model = new CreateQuestionRequest(); // CreateQuestionRequest |  (optional) 

            try
            {
                // Add a question to the FAQ set
                QuestionModel result = apiInstance.CreateQuestion(questionAnswerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CreateQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **model** | [**CreateQuestionRequest**](CreateQuestionRequest.md)|  | [optional] 

### Return type

[**QuestionModel**](QuestionModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createstub"></a>
# **CreateStub**
> QuestionAnswerModel CreateStub (NewQuestionAnswerStubRequest model = null)

Create a new FAQ

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateStubExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var model = new NewQuestionAnswerStubRequest(); // NewQuestionAnswerStubRequest | Initial question and answer (optional) 

            try
            {
                // Create a new FAQ
                QuestionAnswerModel result = apiInstance.CreateStub(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CreateStub: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewQuestionAnswerStubRequest**](NewQuestionAnswerStubRequest.md)| Initial question and answer | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

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

            var apiInstance = new QuestionAnswerApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.CreateUserDefinedParameter: " + e.Message );
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

<a name="delete"></a>
# **Delete**
> QuestionAnswerModel Delete (string questionAnswerId)

Delete an FAQ

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 

            try
            {
                // Delete an FAQ
                QuestionAnswerModel result = apiInstance.Delete(questionAnswerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteanswer"></a>
# **DeleteAnswer**
> AnswerModel DeleteAnswer (string answerId)

Delete an answer

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteAnswerExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var answerId = answerId_example;  // string | 

            try
            {
                // Delete an answer
                AnswerModel result = apiInstance.DeleteAnswer(answerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.DeleteAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerId** | **string**|  | 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequestion"></a>
# **DeleteQuestion**
> QuestionModel DeleteQuestion (string questionId)

Delete a question

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteQuestionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionId = questionId_example;  // string | 

            try
            {
                // Delete a question
                QuestionModel result = apiInstance.DeleteQuestion(questionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.DeleteQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**|  | 

### Return type

[**QuestionModel**](QuestionModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editanswer"></a>
# **EditAnswer**
> AnswerModel EditAnswer (string answerId, UpdateAnswerRequest model = null)

Edit a given Answer

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class EditAnswerExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var answerId = answerId_example;  // string | 
            var model = new UpdateAnswerRequest(); // UpdateAnswerRequest |  (optional) 

            try
            {
                // Edit a given Answer
                AnswerModel result = apiInstance.EditAnswer(answerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.EditAnswer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **answerId** | **string**|  | 
 **model** | [**UpdateAnswerRequest**](UpdateAnswerRequest.md)|  | [optional] 

### Return type

[**AnswerModel**](AnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="editquestion"></a>
# **EditQuestion**
> QuestionModel EditQuestion (string questionId, UpdateQuestionRequest model = null)

Edit a given question

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class EditQuestionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionId = questionId_example;  // string | 
            var model = new UpdateQuestionRequest(); // UpdateQuestionRequest |  (optional) 

            try
            {
                // Edit a given question
                QuestionModel result = apiInstance.EditQuestion(questionId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.EditQuestion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionId** | **string**|  | 
 **model** | [**UpdateQuestionRequest**](UpdateQuestionRequest.md)|  | [optional] 

### Return type

[**QuestionModel**](QuestionModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfullbyid"></a>
# **FindFullById**
> QuestionAnswerModel FindFullById (string id)

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

            var apiInstance = new QuestionAnswerApi();
            var id = id_example;  // string | 

            try
            {
                // Finds the full content item by id
                QuestionAnswerModel result = apiInstance.FindFullById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.FindFullById: " + e.Message );
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

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> QuestionAnswerModel Get (string questionAnswerId)

Get an FAQ by its ID

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 

            try
            {
                // Get an FAQ by its ID
                QuestionAnswerModel result = apiInstance.Get(questionAnswerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getallbyapplicationfeature"></a>
# **GetAllByApplicationFeature**
> List<QuestionAnswerModel> GetAllByApplicationFeature (string applicationFeatureId)

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
    public class GetAllByApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                // Gets the content for the given application feature
                List&lt;QuestionAnswerModel&gt; result = apiInstance.GetAllByApplicationFeature(applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.GetAllByApplicationFeature: " + e.Message );
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

[**List<QuestionAnswerModel>**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyapplicationfeature"></a>
# **GetByApplicationFeature**
> List<QuestionAnswerModel> GetByApplicationFeature (string applicationFeatureId, string sortBy = null, int? skip = null, int? take = null)

Gets the content for the given application feature with skip/take

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

            var apiInstance = new QuestionAnswerApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var sortBy = sortBy_example;  // string |  (optional) 
            var skip = 56;  // int? |  (optional) 
            var take = 56;  // int? |  (optional) 

            try
            {
                // Gets the content for the given application feature with skip/take
                List&lt;QuestionAnswerModel&gt; result = apiInstance.GetByApplicationFeature(applicationFeatureId, sortBy, skip, take);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.GetByApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **sortBy** | **string**|  | [optional] 
 **skip** | **int?**|  | [optional] 
 **take** | **int?**|  | [optional] 

### Return type

[**List<QuestionAnswerModel>**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getquestionanswersforapplication"></a>
# **GetQuestionAnswersForApplication**
> List<QuestionAnswerModel> GetQuestionAnswersForApplication (string applicationId)

Get the FAQs for a given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetQuestionAnswersForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new QuestionAnswerApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Get the FAQs for a given application
                List&lt;QuestionAnswerModel&gt; result = apiInstance.GetQuestionAnswersForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.GetQuestionAnswersForApplication: " + e.Message );
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

[**List<QuestionAnswerModel>**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<QuestionAnswerWebhookModel> GetWebhooks (string questionAnswerId)

Get the webhooks associated with a question answer item

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 

            try
            {
                // Get the webhooks associated with a question answer item
                List&lt;QuestionAnswerWebhookModel&gt; result = apiInstance.GetWebhooks(questionAnswerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.GetWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 

### Return type

[**List<QuestionAnswerWebhookModel>**](QuestionAnswerWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecontentitemtoapplicationfeature"></a>
# **MoveContentItemToApplicationFeature**
> QuestionAnswerModel MoveContentItemToApplicationFeature (string contentItemId, string applicationFeatureId)



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

            var apiInstance = new QuestionAnswerApi();
            var contentItemId = contentItemId_example;  // string | 
            var applicationFeatureId = applicationFeatureId_example;  // string | 

            try
            {
                QuestionAnswerModel result = apiInstance.MoveContentItemToApplicationFeature(contentItemId, applicationFeatureId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.MoveContentItemToApplicationFeature: " + e.Message );
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

[**QuestionAnswerModel**](QuestionAnswerModel.md)

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

            var apiInstance = new QuestionAnswerApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.RemoveUserDefinedParameter: " + e.Message );
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
> QuestionAnswerWebhookModel RemoveWebhook (string questionAnswerWebhookId)

Delete a webhook from a question answer item

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerWebhookId = questionAnswerWebhookId_example;  // string | 

            try
            {
                // Delete a webhook from a question answer item
                QuestionAnswerWebhookModel result = apiInstance.RemoveWebhook(questionAnswerWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerWebhookId** | **string**|  | 

### Return type

[**QuestionAnswerWebhookModel**](QuestionAnswerWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toggleislive"></a>
# **ToggleIsLive**
> QuestionAnswerModel ToggleIsLive (string questionAnswerId, ToggleLiveRequest model = null)

Toggles whether the given FAQ is live or not

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var model = new ToggleLiveRequest(); // ToggleLiveRequest |  (optional) 

            try
            {
                // Toggles whether the given FAQ is live or not
                QuestionAnswerModel result = apiInstance.ToggleIsLive(questionAnswerId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.ToggleIsLive: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **model** | [**ToggleLiveRequest**](ToggleLiveRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> QuestionAnswerWebhookModel UpdateAttachedWebhook (string questionAnswerId, string instanceWebhookId, WebhookParametersRequest parameters = null)

Update a webhook on a question answer item

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

            var apiInstance = new QuestionAnswerApi();
            var questionAnswerId = questionAnswerId_example;  // string | 
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                // Update a webhook on a question answer item
                QuestionAnswerWebhookModel result = apiInstance.UpdateAttachedWebhook(questionAnswerId, instanceWebhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **questionAnswerId** | **string**|  | 
 **instanceWebhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**QuestionAnswerWebhookModel**](QuestionAnswerWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefullcontentitem"></a>
# **UpdateFullContentItem**
> QuestionAnswerModel UpdateFullContentItem (string contentItemId, QuestionAnswerModel model = null)

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

            var apiInstance = new QuestionAnswerApi();
            var contentItemId = contentItemId_example;  // string | 
            var model = new QuestionAnswerModel(); // QuestionAnswerModel |  (optional) 

            try
            {
                // Updates the content item from a specified dto
                QuestionAnswerModel result = apiInstance.UpdateFullContentItem(contentItemId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.UpdateFullContentItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentItemId** | **string**|  | 
 **model** | [**QuestionAnswerModel**](QuestionAnswerModel.md)|  | [optional] 

### Return type

[**QuestionAnswerModel**](QuestionAnswerModel.md)

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

            var apiInstance = new QuestionAnswerApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.UpdateUserDefinedParameter: " + e.Message );
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

            var apiInstance = new QuestionAnswerApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QuestionAnswerApi.UpdateWebhookParameter: " + e.Message );
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

