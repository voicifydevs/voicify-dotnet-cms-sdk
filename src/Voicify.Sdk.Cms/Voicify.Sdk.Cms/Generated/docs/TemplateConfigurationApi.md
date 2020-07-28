# Voicify.Sdk.Cms.Api.TemplateConfigurationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTemplateConfigurationFromModel**](TemplateConfigurationApi.md#createtemplateconfigurationfrommodel) | **POST** /api/TemplateConfiguration | 
[**DeleteTemplateConfiguration**](TemplateConfigurationApi.md#deletetemplateconfiguration) | **DELETE** /api/TemplateConfiguration/{templateConfigurationId} | 
[**DisableTemplateConfiguration**](TemplateConfigurationApi.md#disabletemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/disable | 
[**EnableTemplateConfiguration**](TemplateConfigurationApi.md#enabletemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId}/enable | 
[**GetAvailableTemplateConfigurations**](TemplateConfigurationApi.md#getavailabletemplateconfigurations) | **GET** /api/TemplateConfiguration/{organizationId}/available | Gets the available template configs
[**GetOrganizationTemplateConfigurations**](TemplateConfigurationApi.md#getorganizationtemplateconfigurations) | **GET** /api/TemplateConfiguration/{organizationId} | 
[**UpdateTemplateConfiguration**](TemplateConfigurationApi.md#updatetemplateconfiguration) | **PUT** /api/TemplateConfiguration/{templateConfigurationId} | 


<a name="createtemplateconfigurationfrommodel"></a>
# **CreateTemplateConfigurationFromModel**
> TemplateConfigurationModel CreateTemplateConfigurationFromModel (TemplateConfigurationModel model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateTemplateConfigurationFromModelExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var model = new TemplateConfigurationModel(); // TemplateConfigurationModel |  (optional) 

            try
            {
                TemplateConfigurationModel result = apiInstance.CreateTemplateConfigurationFromModel(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.CreateTemplateConfigurationFromModel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**TemplateConfigurationModel**](TemplateConfigurationModel.md)|  | [optional] 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetemplateconfiguration"></a>
# **DeleteTemplateConfiguration**
> TemplateConfigurationModel DeleteTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteTemplateConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.DeleteTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.DeleteTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disabletemplateconfiguration"></a>
# **DisableTemplateConfiguration**
> TemplateConfigurationModel DisableTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableTemplateConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.DisableTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.DisableTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enabletemplateconfiguration"></a>
# **EnableTemplateConfiguration**
> TemplateConfigurationModel EnableTemplateConfiguration (string templateConfigurationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class EnableTemplateConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 

            try
            {
                TemplateConfigurationModel result = apiInstance.EnableTemplateConfiguration(templateConfigurationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.EnableTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getavailabletemplateconfigurations"></a>
# **GetAvailableTemplateConfigurations**
> List<TemplateConfigurationModel> GetAvailableTemplateConfigurations (string organizationId)

Gets the available template configs

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetAvailableTemplateConfigurationsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Gets the available template configs
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.GetAvailableTemplateConfigurations(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetAvailableTemplateConfigurations: " + e.Message );
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

[**List<TemplateConfigurationModel>**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationtemplateconfigurations"></a>
# **GetOrganizationTemplateConfigurations**
> List<TemplateConfigurationModel> GetOrganizationTemplateConfigurations (string organizationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetOrganizationTemplateConfigurationsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                List&lt;TemplateConfigurationModel&gt; result = apiInstance.GetOrganizationTemplateConfigurations(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.GetOrganizationTemplateConfigurations: " + e.Message );
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

[**List<TemplateConfigurationModel>**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetemplateconfiguration"></a>
# **UpdateTemplateConfiguration**
> TemplateConfigurationModel UpdateTemplateConfiguration (string templateConfigurationId, TemplateConfigurationModel model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateTemplateConfigurationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TemplateConfigurationApi();
            var templateConfigurationId = templateConfigurationId_example;  // string | 
            var model = new TemplateConfigurationModel(); // TemplateConfigurationModel |  (optional) 

            try
            {
                TemplateConfigurationModel result = apiInstance.UpdateTemplateConfiguration(templateConfigurationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TemplateConfigurationApi.UpdateTemplateConfiguration: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateConfigurationId** | **string**|  | 
 **model** | [**TemplateConfigurationModel**](TemplateConfigurationModel.md)|  | [optional] 

### Return type

[**TemplateConfigurationModel**](TemplateConfigurationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

