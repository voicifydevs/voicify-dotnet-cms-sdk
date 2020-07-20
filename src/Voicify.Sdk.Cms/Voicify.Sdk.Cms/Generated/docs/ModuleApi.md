# Voicify.Sdk.Cms.Api.ModuleApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCustomModulesToApplication**](ModuleApi.md#addcustommodulestoapplication) | **PUT** /api/Module/addCustomModules/{applicationId} | Adds a collection of new modules to the given application
[**AddFeatureToGeneralModule**](ModuleApi.md#addfeaturetogeneralmodule) | **PUT** /api/Module/addUncategorizedFeature/{applicationId} | 
[**AddFeatureToModule**](ModuleApi.md#addfeaturetomodule) | **PUT** /api/Module/addFeature/{applicationModuleId} | Adds a feature to the given application module
[**AddModuleToApplication**](ModuleApi.md#addmoduletoapplication) | **PUT** /api/Module/addModule/{applicationId} | Adds a module to the given application
[**ChangeApplicationModuleOrder**](ModuleApi.md#changeapplicationmoduleorder) | **PUT** /api/Module/reorderModules/{applicationId} | 
[**CreateCustomModule**](ModuleApi.md#createcustommodule) | **POST** /api/Module/custom/{applicationId} | Creates a custom module for the given application
[**DisableApplicationModule**](ModuleApi.md#disableapplicationmodule) | **DELETE** /api/Module/{applicationModuleId}/disable | Disables the given application module
[**GetModulesForApplication**](ModuleApi.md#getmodulesforapplication) | **GET** /api/Module/{applicationId} | Gets the modules for the given application
[**GetSystemModules**](ModuleApi.md#getsystemmodules) | **GET** /api/Module/SystemModules | Gets all the system modules supported by voicify
[**UpdateApplicationModule**](ModuleApi.md#updateapplicationmodule) | **PUT** /api/Module/{applicationModuleId}/update | 


<a name="addcustommodulestoapplication"></a>
# **AddCustomModulesToApplication**
> void AddCustomModulesToApplication (string applicationId, List<NewModuleRequest> models = null)

Adds a collection of new modules to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddCustomModulesToApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var models = new List<NewModuleRequest>(); // List<NewModuleRequest> |  (optional) 

            try
            {
                // Adds a collection of new modules to the given application
                apiInstance.AddCustomModulesToApplication(applicationId, models);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.AddCustomModulesToApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **models** | [**List&lt;NewModuleRequest&gt;**](NewModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfeaturetogeneralmodule"></a>
# **AddFeatureToGeneralModule**
> void AddFeatureToGeneralModule (string applicationId, AddFeatureToModuleRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddFeatureToGeneralModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var model = new AddFeatureToModuleRequest(); // AddFeatureToModuleRequest |  (optional) 

            try
            {
                apiInstance.AddFeatureToGeneralModule(applicationId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.AddFeatureToGeneralModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**AddFeatureToModuleRequest**](AddFeatureToModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addfeaturetomodule"></a>
# **AddFeatureToModule**
> void AddFeatureToModule (string applicationModuleId, AddFeatureToModuleRequest model = null)

Adds a feature to the given application module

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddFeatureToModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 
            var model = new AddFeatureToModuleRequest(); // AddFeatureToModuleRequest |  (optional) 

            try
            {
                // Adds a feature to the given application module
                apiInstance.AddFeatureToModule(applicationModuleId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.AddFeatureToModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 
 **model** | [**AddFeatureToModuleRequest**](AddFeatureToModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmoduletoapplication"></a>
# **AddModuleToApplication**
> void AddModuleToApplication (string applicationId, AddModuleToApplicationRequest model = null)

Adds a module to the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AddModuleToApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var model = new AddModuleToApplicationRequest(); // AddModuleToApplicationRequest |  (optional) 

            try
            {
                // Adds a module to the given application
                apiInstance.AddModuleToApplication(applicationId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.AddModuleToApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**AddModuleToApplicationRequest**](AddModuleToApplicationRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="changeapplicationmoduleorder"></a>
# **ChangeApplicationModuleOrder**
> void ChangeApplicationModuleOrder (string applicationId, List<string> applicationModuleIds = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ChangeApplicationModuleOrderExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var applicationModuleIds = ;  // List<string> |  (optional) 

            try
            {
                apiInstance.ChangeApplicationModuleOrder(applicationId, applicationModuleIds);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.ChangeApplicationModuleOrder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **applicationModuleIds** | **List&lt;string&gt;**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createcustommodule"></a>
# **CreateCustomModule**
> void CreateCustomModule (string applicationId, NewModuleRequest model = null)

Creates a custom module for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateCustomModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewModuleRequest(); // NewModuleRequest |  (optional) 

            try
            {
                // Creates a custom module for the given application
                apiInstance.CreateCustomModule(applicationId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.CreateCustomModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewModuleRequest**](NewModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disableapplicationmodule"></a>
# **DisableApplicationModule**
> void DisableApplicationModule (string applicationModuleId)

Disables the given application module

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableApplicationModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 

            try
            {
                // Disables the given application module
                apiInstance.DisableApplicationModule(applicationModuleId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.DisableApplicationModule: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmodulesforapplication"></a>
# **GetModulesForApplication**
> void GetModulesForApplication (string applicationId)

Gets the modules for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetModulesForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the modules for the given application
                apiInstance.GetModulesForApplication(applicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.GetModulesForApplication: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemmodules"></a>
# **GetSystemModules**
> void GetSystemModules ()

Gets all the system modules supported by voicify

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSystemModulesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();

            try
            {
                // Gets all the system modules supported by voicify
                apiInstance.GetSystemModules();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.GetSystemModules: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplicationmodule"></a>
# **UpdateApplicationModule**
> void UpdateApplicationModule (string applicationModuleId, UpdateApplicationModuleRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateApplicationModuleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ModuleApi();
            var applicationModuleId = applicationModuleId_example;  // string | 
            var model = new UpdateApplicationModuleRequest(); // UpdateApplicationModuleRequest |  (optional) 

            try
            {
                apiInstance.UpdateApplicationModule(applicationModuleId, model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ModuleApi.UpdateApplicationModule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationModuleId** | **string**|  | 
 **model** | [**UpdateApplicationModuleRequest**](UpdateApplicationModuleRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

