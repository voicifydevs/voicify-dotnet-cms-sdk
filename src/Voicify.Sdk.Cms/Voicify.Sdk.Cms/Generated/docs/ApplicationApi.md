# Voicify.Sdk.Cms.Api.ApplicationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMemberAsync**](ApplicationApi.md#addmemberasync) | **POST** /api/Application/{applicationId}/members | Adds a member to the given application
[**AddWebhook**](ApplicationApi.md#addwebhook) | **POST** /api/Application/{applicationId}/webhooks/{webhookId} | 
[**BulkAddMemberAsync**](ApplicationApi.md#bulkaddmemberasync) | **POST** /api/Application/{applicationId}/members/bulkAdd | Adds a member to the given application
[**CreateApplicationWithSampleContent**](ApplicationApi.md#createapplicationwithsamplecontent) | **POST** /api/Application/{organizationId}/withSamples | Creates a new Application with some sample content for the given organization
[**CreateEmptyApplication**](ApplicationApi.md#createemptyapplication) | **POST** /api/Application/{organizationId} | Creates a new Application for the given organization
[**CreateUserDefinedParameter**](ApplicationApi.md#createuserdefinedparameter) | **POST** /api/Application/webhook/{instanceWebhookId}/userParameters | 
[**DeleteApplication**](ApplicationApi.md#deleteapplication) | **DELETE** /api/Application/{applicationId} | 
[**DisableApplication**](ApplicationApi.md#disableapplication) | **DELETE** /api/Application/{applicationId}/disable | 
[**EnableApplication**](ApplicationApi.md#enableapplication) | **PUT** /api/Application/{applicationId}/enable | 
[**FindApplication**](ApplicationApi.md#findapplication) | **GET** /api/Application/find/{applicationId} | Gets a single application by id
[**FindApplicationWithFeatures**](ApplicationApi.md#findapplicationwithfeatures) | **GET** /api/Application/find/{applicationId}/withFeatures | Gets a single application with all its features by id
[**GetAppConversationCount**](ApplicationApi.md#getappconversationcount) | **GET** /api/Application/{applicationId}/conversationCount | 
[**GetAppConversationCounts**](ApplicationApi.md#getappconversationcounts) | **GET** /api/Application/{organizationId}/apps/conversationCounts | 
[**GetAppMembers**](ApplicationApi.md#getappmembers) | **GET** /api/Application/{applicationId}/members | Gets the members of the application
[**GetApplicationsForOrganization**](ApplicationApi.md#getapplicationsfororganization) | **GET** /api/Application/{organizationId} | Gets the applications from the given organization
[**GetApplicationsWithFeaturesForOrganization**](ApplicationApi.md#getapplicationswithfeaturesfororganization) | **GET** /api/Application/{organizationId}/withFeatures | Gets the applications from the given organization
[**GetFulfillmentEndpoints**](ApplicationApi.md#getfulfillmentendpoints) | **GET** /api/Application/{applicationId}/fulfillmentEndpoints | 
[**GetWebhooks**](ApplicationApi.md#getwebhooks) | **GET** /api/Application/{applicationId}/webhooks | 
[**RemoveMember**](ApplicationApi.md#removemember) | **DELETE** /api/Application/members/{applicationMemberId} | Removes the given user from the app
[**RemoveUserDefinedParameter**](ApplicationApi.md#removeuserdefinedparameter) | **DELETE** /api/Application/webhook/{instanceWebhookId}/userParameters/{parameterName} | 
[**RemoveWebhook**](ApplicationApi.md#removewebhook) | **DELETE** /api/Application/webhook/{applicationWebhookId} | 
[**SetImage**](ApplicationApi.md#setimage) | **PUT** /api/Application/{applicationId}/setImage/{imageItemId} | 
[**SetInitialPriority**](ApplicationApi.md#setinitialpriority) | **POST** /api/Application/setInitialPriority | 
[**ToggleAllowsTemplate**](ApplicationApi.md#toggleallowstemplate) | **PUT** /api/Application/{applicationId}/toggleAllowsTemplate | Toggles the template status of an application
[**UpdateAlexaFallbackSensitivity**](ApplicationApi.md#updatealexafallbacksensitivity) | **PUT** /api/Application/{applicationId}/alexaFallbackSensitivity/{sensitivityLevel} | 
[**UpdateApplicationInformation**](ApplicationApi.md#updateapplicationinformation) | **PUT** /api/Application/{applicationId} | Updates an application&#39;s information
[**UpdateAttachedWebhook**](ApplicationApi.md#updateattachedwebhook) | **PUT** /api/Application/{applicationId}/webhooks/{webhookInstanceId} | 
[**UpdateDefaultLangauge**](ApplicationApi.md#updatedefaultlangauge) | **PUT** /api/Application/{applicationId}/defaultLanguage/{languageId} | 
[**UpdateLangauges**](ApplicationApi.md#updatelangauges) | **PUT** /api/Application/{applicationId}/languages | 
[**UpdateMemberRole**](ApplicationApi.md#updatememberrole) | **PUT** /api/Application/members/{applicationMemberId} | Updates the given member&#39;s role
[**UpdateUserDefinedParameter**](ApplicationApi.md#updateuserdefinedparameter) | **PUT** /api/Application/webhook/{instanceWebhookId}/userParameters | 
[**UpdateWebhookParameter**](ApplicationApi.md#updatewebhookparameter) | **PUT** /api/Application/webhook/{instanceWebhookId}/webhookParameters | 


<a name="addmemberasync"></a>
# **AddMemberAsync**
> ApplicationMemberModel AddMemberAsync (string applicationId, NewApplicationMemberRequest model = null)

Adds a member to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddMemberAsyncExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewApplicationMemberRequest(); // NewApplicationMemberRequest |  (optional) 

            try
            {
                // Adds a member to the given application
                ApplicationMemberModel result = apiInstance.AddMemberAsync(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddMemberAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewApplicationMemberRequest**](NewApplicationMemberRequest.md)|  | [optional] 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addwebhook"></a>
# **AddWebhook**
> ApplicationWebhookModel AddWebhook (string applicationId, string webhookId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var webhookId = webhookId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationWebhookModel result = apiInstance.AddWebhook(applicationId, webhookId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **webhookId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkaddmemberasync"></a>
# **BulkAddMemberAsync**
> List<ApplicationMemberModel> BulkAddMemberAsync (string applicationId, NewBulkApplicationMemberRequest model = null)

Adds a member to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BulkAddMemberAsyncExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewBulkApplicationMemberRequest(); // NewBulkApplicationMemberRequest |  (optional) 

            try
            {
                // Adds a member to the given application
                List&lt;ApplicationMemberModel&gt; result = apiInstance.BulkAddMemberAsync(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.BulkAddMemberAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewBulkApplicationMemberRequest**](NewBulkApplicationMemberRequest.md)|  | [optional] 

### Return type

[**List<ApplicationMemberModel>**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplicationwithsamplecontent"></a>
# **CreateApplicationWithSampleContent**
> ApplicationModel CreateApplicationWithSampleContent (string organizationId, NewApplicationRequest model = null)

Creates a new Application with some sample content for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateApplicationWithSampleContentExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | Organization ID
            var model = new NewApplicationRequest(); // NewApplicationRequest | request model (optional) 

            try
            {
                // Creates a new Application with some sample content for the given organization
                ApplicationModel result = apiInstance.CreateApplicationWithSampleContent(organizationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CreateApplicationWithSampleContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization ID | 
 **model** | [**NewApplicationRequest**](NewApplicationRequest.md)| request model | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createemptyapplication"></a>
# **CreateEmptyApplication**
> ApplicationModel CreateEmptyApplication (string organizationId, NewApplicationRequest model = null)

Creates a new Application for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateEmptyApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | Organization ID
            var model = new NewApplicationRequest(); // NewApplicationRequest | request model (optional) 

            try
            {
                // Creates a new Application for the given organization
                ApplicationModel result = apiInstance.CreateEmptyApplication(organizationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CreateEmptyApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| Organization ID | 
 **model** | [**NewApplicationRequest**](NewApplicationRequest.md)| request model | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterCreateRequest(); // UserDefinedWebhookParameterCreateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.CreateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.CreateUserDefinedParameter: " + e.Message );
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

<a name="deleteapplication"></a>
# **DeleteApplication**
> ApplicationModel DeleteApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.DeleteApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteApplication: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disableapplication"></a>
# **DisableApplication**
> ApplicationModel DisableApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.DisableApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.DisableApplication: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enableapplication"></a>
# **EnableApplication**
> ApplicationModel EnableApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class EnableApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.EnableApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.EnableApplication: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findapplication"></a>
# **FindApplication**
> ApplicationModel FindApplication (string applicationId)

Gets a single application by id

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets a single application by id
                ApplicationModel result = apiInstance.FindApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.FindApplication: " + e.Message );
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

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findapplicationwithfeatures"></a>
# **FindApplicationWithFeatures**
> ApplicationWithFeaturesModel FindApplicationWithFeatures (string applicationId)

Gets a single application with all its features by id

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindApplicationWithFeaturesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets a single application with all its features by id
                ApplicationWithFeaturesModel result = apiInstance.FindApplicationWithFeatures(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.FindApplicationWithFeatures: " + e.Message );
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

[**ApplicationWithFeaturesModel**](ApplicationWithFeaturesModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappconversationcount"></a>
# **GetAppConversationCount**
> ApplicationConversationCountModel GetAppConversationCount (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppConversationCountExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationConversationCountModel result = apiInstance.GetAppConversationCount(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetAppConversationCount: " + e.Message );
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

[**ApplicationConversationCountModel**](ApplicationConversationCountModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappconversationcounts"></a>
# **GetAppConversationCounts**
> List<ApplicationConversationCountModel> GetAppConversationCounts (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppConversationCountsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;ApplicationConversationCountModel&gt; result = apiInstance.GetAppConversationCounts(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetAppConversationCounts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 

### Return type

[**List<ApplicationConversationCountModel>**](ApplicationConversationCountModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappmembers"></a>
# **GetAppMembers**
> List<ApplicationMemberModel> GetAppMembers (string applicationId)

Gets the members of the application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppMembersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the members of the application
                List&lt;ApplicationMemberModel&gt; result = apiInstance.GetAppMembers(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetAppMembers: " + e.Message );
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

[**List<ApplicationMemberModel>**](ApplicationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationsfororganization"></a>
# **GetApplicationsForOrganization**
> List<ApplicationModel> GetApplicationsForOrganization (string organizationId)

Gets the applications from the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationsForOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | The organization Id

            try
            {
                // Gets the applications from the given organization
                List&lt;ApplicationModel&gt; result = apiInstance.GetApplicationsForOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationsForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The organization Id | 

### Return type

[**List<ApplicationModel>**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationswithfeaturesfororganization"></a>
# **GetApplicationsWithFeaturesForOrganization**
> List<ApplicationWithFeaturesModel> GetApplicationsWithFeaturesForOrganization (string organizationId)

Gets the applications from the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationsWithFeaturesForOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var organizationId = organizationId_example;  // string | The organization Id

            try
            {
                // Gets the applications from the given organization
                List&lt;ApplicationWithFeaturesModel&gt; result = apiInstance.GetApplicationsWithFeaturesForOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetApplicationsWithFeaturesForOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The organization Id | 

### Return type

[**List<ApplicationWithFeaturesModel>**](ApplicationWithFeaturesModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfulfillmentendpoints"></a>
# **GetFulfillmentEndpoints**
> ApplicationFulfillmentEndpoints GetFulfillmentEndpoints (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetFulfillmentEndpointsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                ApplicationFulfillmentEndpoints result = apiInstance.GetFulfillmentEndpoints(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetFulfillmentEndpoints: " + e.Message );
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

[**ApplicationFulfillmentEndpoints**](ApplicationFulfillmentEndpoints.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> List<ApplicationWebhookModel> GetWebhooks (string applicationId)



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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;ApplicationWebhookModel&gt; result = apiInstance.GetWebhooks(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.GetWebhooks: " + e.Message );
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

[**List<ApplicationWebhookModel>**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removemember"></a>
# **RemoveMember**
> ApplicationMemberModel RemoveMember (string applicationMemberId)

Removes the given user from the app

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationMemberId = applicationMemberId_example;  // string | 

            try
            {
                // Removes the given user from the app
                ApplicationMemberModel result = apiInstance.RemoveMember(applicationMemberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RemoveMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationMemberId** | **string**|  | 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var parameterName = parameterName_example;  // string | 

            try
            {
                bool? result = apiInstance.RemoveUserDefinedParameter(instanceWebhookId, parameterName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RemoveUserDefinedParameter: " + e.Message );
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
> ApplicationWebhookModel RemoveWebhook (string applicationWebhookId)



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

            var apiInstance = new ApplicationApi();
            var applicationWebhookId = applicationWebhookId_example;  // string | 

            try
            {
                ApplicationWebhookModel result = apiInstance.RemoveWebhook(applicationWebhookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.RemoveWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationWebhookId** | **string**|  | 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setimage"></a>
# **SetImage**
> ApplicationModel SetImage (string applicationId, string imageItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SetImageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var imageItemId = imageItemId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.SetImage(applicationId, imageItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.SetImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **imageItemId** | **string**|  | 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setinitialpriority"></a>
# **SetInitialPriority**
> bool? SetInitialPriority ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SetInitialPriorityExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();

            try
            {
                bool? result = apiInstance.SetInitialPriority();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.SetInitialPriority: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toggleallowstemplate"></a>
# **ToggleAllowsTemplate**
> ApplicationModel ToggleAllowsTemplate (string applicationId, ToggleTemplateRequest request = null)

Toggles the template status of an application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ToggleAllowsTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var request = new ToggleTemplateRequest(); // ToggleTemplateRequest |  (optional) 

            try
            {
                // Toggles the template status of an application
                ApplicationModel result = apiInstance.ToggleAllowsTemplate(applicationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ToggleAllowsTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **request** | [**ToggleTemplateRequest**](ToggleTemplateRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatealexafallbacksensitivity"></a>
# **UpdateAlexaFallbackSensitivity**
> bool? UpdateAlexaFallbackSensitivity (string applicationId, string sensitivityLevel)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAlexaFallbackSensitivityExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var sensitivityLevel = sensitivityLevel_example;  // string | 

            try
            {
                bool? result = apiInstance.UpdateAlexaFallbackSensitivity(applicationId, sensitivityLevel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateAlexaFallbackSensitivity: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **sensitivityLevel** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplicationinformation"></a>
# **UpdateApplicationInformation**
> ApplicationModel UpdateApplicationInformation (string applicationId, UpdateApplicationRequest model = null)

Updates an application's information

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateApplicationInformationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | The application id
            var model = new UpdateApplicationRequest(); // UpdateApplicationRequest | Information to update (optional) 

            try
            {
                // Updates an application's information
                ApplicationModel result = apiInstance.UpdateApplicationInformation(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateApplicationInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| The application id | 
 **model** | [**UpdateApplicationRequest**](UpdateApplicationRequest.md)| Information to update | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateattachedwebhook"></a>
# **UpdateAttachedWebhook**
> ApplicationWebhookModel UpdateAttachedWebhook (string applicationId, string webhookInstanceId, WebhookParametersRequest parameters = null)



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

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var webhookInstanceId = webhookInstanceId_example;  // string | 
            var parameters = new WebhookParametersRequest(); // WebhookParametersRequest |  (optional) 

            try
            {
                ApplicationWebhookModel result = apiInstance.UpdateAttachedWebhook(applicationId, webhookInstanceId, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateAttachedWebhook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **webhookInstanceId** | **string**|  | 
 **parameters** | [**WebhookParametersRequest**](WebhookParametersRequest.md)|  | [optional] 

### Return type

[**ApplicationWebhookModel**](ApplicationWebhookModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedefaultlangauge"></a>
# **UpdateDefaultLangauge**
> ApplicationModel UpdateDefaultLangauge (string applicationId, string languageId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateDefaultLangaugeExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var languageId = languageId_example;  // string | 

            try
            {
                ApplicationModel result = apiInstance.UpdateDefaultLangauge(applicationId, languageId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateDefaultLangauge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **languageId** | **string**|  | 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelangauges"></a>
# **UpdateLangauges**
> ApplicationModel UpdateLangauges (string applicationId, List<string> languageIds = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateLangaugesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationId = applicationId_example;  // string | 
            var languageIds = ;  // List<string> |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.UpdateLangauges(applicationId, languageIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateLangauges: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **languageIds** | **List&lt;string&gt;**|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatememberrole"></a>
# **UpdateMemberRole**
> ApplicationMemberModel UpdateMemberRole (string applicationMemberId, MemberRoleUpdateRequest model = null)

Updates the given member's role

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMemberRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationApi();
            var applicationMemberId = applicationMemberId_example;  // string | 
            var model = new MemberRoleUpdateRequest(); // MemberRoleUpdateRequest |  (optional) 

            try
            {
                // Updates the given member's role
                ApplicationMemberModel result = apiInstance.UpdateMemberRole(applicationMemberId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateMemberRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationMemberId** | **string**|  | 
 **model** | [**MemberRoleUpdateRequest**](MemberRoleUpdateRequest.md)|  | [optional] 

### Return type

[**ApplicationMemberModel**](ApplicationMemberModel.md)

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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new UserDefinedWebhookParameterUpdateRequest(); // UserDefinedWebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateUserDefinedParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateUserDefinedParameter: " + e.Message );
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

            var apiInstance = new ApplicationApi();
            var instanceWebhookId = instanceWebhookId_example;  // string | 
            var request = new WebhookParameterUpdateRequest(); // WebhookParameterUpdateRequest |  (optional) 

            try
            {
                bool? result = apiInstance.UpdateWebhookParameter(instanceWebhookId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateWebhookParameter: " + e.Message );
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

