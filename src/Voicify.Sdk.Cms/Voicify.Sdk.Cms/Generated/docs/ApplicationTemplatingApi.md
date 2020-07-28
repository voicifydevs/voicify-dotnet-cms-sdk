# Voicify.Sdk.Cms.Api.ApplicationTemplatingApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppliedApplicationTemplateForm**](ApplicationTemplatingApi.md#addappliedapplicationtemplateform) | **POST** /api/ApplicationTemplating/{applicationId}/addAppliedApplicationTemplateForm | 
[**CreateApplicationFromForms**](ApplicationTemplatingApi.md#createapplicationfromforms) | **POST** /api/ApplicationTemplating/CreateFromForm | 
[**RemoveAppliedApplicationTemplateForm**](ApplicationTemplatingApi.md#removeappliedapplicationtemplateform) | **DELETE** /api/ApplicationTemplating/{applicationId}/RemoveAppliedApplicationTemplateForm/{applicationTemplateFormId} | 
[**UpdateAppliedApplicationTemplateForm**](ApplicationTemplatingApi.md#updateappliedapplicationtemplateform) | **PUT** /api/ApplicationTemplating/{applicationId}/UpdateAppliedApplicationTemplateForm/{applicationTemplateFormId} | 


<a name="addappliedapplicationtemplateform"></a>
# **AddAppliedApplicationTemplateForm**
> AppliedApplicationTemplateFormModel AddAppliedApplicationTemplateForm (string applicationId, CompleteTemplateFormModel request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedApplicationTemplateFormExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var request = new CompleteTemplateFormModel(); // CompleteTemplateFormModel |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.AddAppliedApplicationTemplateForm(applicationId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.AddAppliedApplicationTemplateForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **request** | [**CompleteTemplateFormModel**](CompleteTemplateFormModel.md)|  | [optional] 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplicationfromforms"></a>
# **CreateApplicationFromForms**
> ApplicationModel CreateApplicationFromForms (CreateApplicationFromCompletedFormsRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateApplicationFromFormsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationTemplatingApi();
            var request = new CreateApplicationFromCompletedFormsRequest(); // CreateApplicationFromCompletedFormsRequest |  (optional) 

            try
            {
                ApplicationModel result = apiInstance.CreateApplicationFromForms(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.CreateApplicationFromForms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateApplicationFromCompletedFormsRequest**](CreateApplicationFromCompletedFormsRequest.md)|  | [optional] 

### Return type

[**ApplicationModel**](ApplicationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removeappliedapplicationtemplateform"></a>
# **RemoveAppliedApplicationTemplateForm**
> AppliedApplicationTemplateFormModel RemoveAppliedApplicationTemplateForm (string applicationId, string applicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveAppliedApplicationTemplateFormExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.RemoveAppliedApplicationTemplateForm(applicationId, applicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.RemoveAppliedApplicationTemplateForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappliedapplicationtemplateform"></a>
# **UpdateAppliedApplicationTemplateForm**
> AppliedApplicationTemplateFormModel UpdateAppliedApplicationTemplateForm (string applicationId, string applicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedApplicationTemplateFormExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ApplicationTemplatingApi();
            var applicationId = applicationId_example;  // string | 
            var applicationTemplateFormId = applicationTemplateFormId_example;  // string | 
            var request = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.UpdateAppliedApplicationTemplateForm(applicationId, applicationTemplateFormId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationTemplatingApi.UpdateAppliedApplicationTemplateForm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationTemplateFormId** | **string**|  | 
 **request** | [**UpdateAppliedApplicationTemplateFormRequest**](UpdateAppliedApplicationTemplateFormRequest.md)|  | [optional] 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

