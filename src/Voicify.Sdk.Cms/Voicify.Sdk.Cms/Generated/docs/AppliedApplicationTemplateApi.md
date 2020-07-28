# Voicify.Sdk.Cms.Api.AppliedApplicationTemplateApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddAppliedTemplateToApp**](AppliedApplicationTemplateApi.md#addappliedtemplatetoapp) | **POST** /api/AppliedApplicationTemplate/{applicationId}/add/{templateConfigurationId} | 
[**DeleteAppliedTemplate**](AppliedApplicationTemplateApi.md#deleteappliedtemplate) | **DELETE** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**FindAppliedTemplateById**](AppliedApplicationTemplateApi.md#findappliedtemplatebyid) | **GET** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 
[**GetAppliedTemplatesForApplication**](AppliedApplicationTemplateApi.md#getappliedtemplatesforapplication) | **GET** /api/AppliedApplicationTemplate/forApp/{applicationId} | 
[**UpdateAppliedTemplate**](AppliedApplicationTemplateApi.md#updateappliedtemplate) | **PUT** /api/AppliedApplicationTemplate/{appliedApplicationTemplateFormId} | 


<a name="addappliedtemplatetoapp"></a>
# **AddAppliedTemplateToApp**
> AppliedApplicationTemplateFormModel AddAppliedTemplateToApp (string applicationId, string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddAppliedTemplateToAppExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AppliedApplicationTemplateApi();
            var applicationId = applicationId_example;  // string | 
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.AddAppliedTemplateToApp(applicationId, templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.AddAppliedTemplateToApp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **templateConfigurationId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteappliedtemplate"></a>
# **DeleteAppliedTemplate**
> AppliedApplicationTemplateFormModel DeleteAppliedTemplate (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteAppliedTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.DeleteAppliedTemplate(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.DeleteAppliedTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findappliedtemplatebyid"></a>
# **FindAppliedTemplateById**
> AppliedApplicationTemplateFormModel FindAppliedTemplateById (string appliedApplicationTemplateFormId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindAppliedTemplateByIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.FindAppliedTemplateById(appliedApplicationTemplateFormId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.FindAppliedTemplateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getappliedtemplatesforapplication"></a>
# **GetAppliedTemplatesForApplication**
> List<AppliedApplicationTemplateFormModel> GetAppliedTemplatesForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAppliedTemplatesForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AppliedApplicationTemplateApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;AppliedApplicationTemplateFormModel&gt; result = apiInstance.GetAppliedTemplatesForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.GetAppliedTemplatesForApplication: " + e.Message );
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

[**List<AppliedApplicationTemplateFormModel>**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateappliedtemplate"></a>
# **UpdateAppliedTemplate**
> AppliedApplicationTemplateFormModel UpdateAppliedTemplate (string appliedApplicationTemplateFormId, UpdateAppliedApplicationTemplateFormRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateAppliedTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AppliedApplicationTemplateApi();
            var appliedApplicationTemplateFormId = appliedApplicationTemplateFormId_example;  // string | 
            var model = new UpdateAppliedApplicationTemplateFormRequest(); // UpdateAppliedApplicationTemplateFormRequest |  (optional) 

            try
            {
                AppliedApplicationTemplateFormModel result = apiInstance.UpdateAppliedTemplate(appliedApplicationTemplateFormId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppliedApplicationTemplateApi.UpdateAppliedTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **appliedApplicationTemplateFormId** | **string**|  | 
 **model** | [**UpdateAppliedApplicationTemplateFormRequest**](UpdateAppliedApplicationTemplateFormRequest.md)|  | [optional] 

### Return type

[**AppliedApplicationTemplateFormModel**](AppliedApplicationTemplateFormModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

