# Voicify.Sdk.Cms.Api.ImportExportApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExportApplication**](ImportExportApi.md#exportapplication) | **GET** /api/ImportExport/export/application/{applicationId} | Exports the application
[**ExportApplicationFile**](ImportExportApi.md#exportapplicationfile) | **GET** /api/ImportExport/export/{applicationId} | Exports the application
[**ExportApplicationInteractionModel**](ImportExportApi.md#exportapplicationinteractionmodel) | **GET** /api/ImportExport/export/interactionModel/{applicationId} | Exports the application&#39;s interaction model only
[**ExportApplicationInteractionModelFile**](ImportExportApi.md#exportapplicationinteractionmodelfile) | **GET** /api/ImportExport/export/interactionModel/{applicationId}/file | Exports the application&#39;s interaction model to file
[**ExportContent**](ImportExportApi.md#exportcontent) | **POST** /api/ImportExport/export/content | Exports custom content based off of request
[**ExportContentToFile**](ImportExportApi.md#exportcontenttofile) | **POST** /api/ImportExport/export/contentToFile | Exports custom content based off of request
[**ImportIntoApplication**](ImportExportApi.md#importintoapplication) | **POST** /api/ImportExport/import/intoApplication/{applicationId} | Imports the application
[**ImportIntoApplicationFeature**](ImportExportApi.md#importintoapplicationfeature) | **POST** /api/ImportExport/import/intoApplicationFeature/{applicationFeatureId} | Import content to a feature with an export model
[**ImportIntoApplicationFeatureFromFile**](ImportExportApi.md#importintoapplicationfeaturefromfile) | **POST** /api/ImportExport/import/intoApplicationFeatureFromFile/{applicationFeatureId} | Import content to a feature by file
[**ImportIntoApplicationFromFile**](ImportExportApi.md#importintoapplicationfromfile) | **POST** /api/ImportExport/import/intoApplicationFromFile/{applicationId} | Uploads the file and saves the media item to the application


<a name="exportapplication"></a>
# **ExportApplication**
> ExportModel ExportApplication (string applicationId)

Exports the application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Exports the application
                ExportModel result = apiInstance.ExportApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportApplication: " + e.Message );
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

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportapplicationfile"></a>
# **ExportApplicationFile**
> byte[] ExportApplicationFile (string applicationId)

Exports the application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportApplicationFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Exports the application
                byte[] result = apiInstance.ExportApplicationFile(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportApplicationFile: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportapplicationinteractionmodel"></a>
# **ExportApplicationInteractionModel**
> ExportModel ExportApplicationInteractionModel (string applicationId)

Exports the application's interaction model only

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportApplicationInteractionModelExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Exports the application's interaction model only
                ExportModel result = apiInstance.ExportApplicationInteractionModel(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportApplicationInteractionModel: " + e.Message );
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

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportapplicationinteractionmodelfile"></a>
# **ExportApplicationInteractionModelFile**
> byte[] ExportApplicationInteractionModelFile (string applicationId)

Exports the application's interaction model to file

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportApplicationInteractionModelFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Exports the application's interaction model to file
                byte[] result = apiInstance.ExportApplicationInteractionModelFile(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportApplicationInteractionModelFile: " + e.Message );
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

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcontent"></a>
# **ExportContent**
> ExportModel ExportContent (BulkContentRequest request = null)

Exports custom content based off of request

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportContentExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var request = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                // Exports custom content based off of request
                ExportModel result = apiInstance.ExportContent(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

[**ExportModel**](ExportModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exportcontenttofile"></a>
# **ExportContentToFile**
> byte[] ExportContentToFile (BulkContentRequest request = null)

Exports custom content based off of request

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ExportContentToFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var request = new BulkContentRequest(); // BulkContentRequest |  (optional) 

            try
            {
                // Exports custom content based off of request
                byte[] result = apiInstance.ExportContentToFile(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ExportContentToFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**BulkContentRequest**](BulkContentRequest.md)|  | [optional] 

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importintoapplication"></a>
# **ImportIntoApplication**
> string ImportIntoApplication (string applicationId, ExportModel exportModel = null)

Imports the application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ImportIntoApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 
            var exportModel = new ExportModel(); // ExportModel |  (optional) 

            try
            {
                // Imports the application
                string result = apiInstance.ImportIntoApplication(applicationId, exportModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ImportIntoApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **exportModel** | [**ExportModel**](ExportModel.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importintoapplicationfeature"></a>
# **ImportIntoApplicationFeature**
> string ImportIntoApplicationFeature (string applicationFeatureId, ExportModel exportModel = null)

Import content to a feature with an export model

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ImportIntoApplicationFeatureExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var exportModel = new ExportModel(); // ExportModel |  (optional) 

            try
            {
                // Import content to a feature with an export model
                string result = apiInstance.ImportIntoApplicationFeature(applicationFeatureId, exportModel);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ImportIntoApplicationFeature: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **exportModel** | [**ExportModel**](ExportModel.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importintoapplicationfeaturefromfile"></a>
# **ImportIntoApplicationFeatureFromFile**
> string ImportIntoApplicationFeatureFromFile (string applicationFeatureId, System.IO.Stream _file = null)

Import content to a feature by file

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ImportIntoApplicationFeatureFromFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationFeatureId = applicationFeatureId_example;  // string | 
            var _file = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Import content to a feature by file
                string result = apiInstance.ImportIntoApplicationFeatureFromFile(applicationFeatureId, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ImportIntoApplicationFeatureFromFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationFeatureId** | **string**|  | 
 **_file** | **System.IO.Stream**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importintoapplicationfromfile"></a>
# **ImportIntoApplicationFromFile**
> string ImportIntoApplicationFromFile (string applicationId, System.IO.Stream _file = null)

Uploads the file and saves the media item to the application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ImportIntoApplicationFromFileExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ImportExportApi();
            var applicationId = applicationId_example;  // string | 
            var _file = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Uploads the file and saves the media item to the application
                string result = apiInstance.ImportIntoApplicationFromFile(applicationId, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ImportExportApi.ImportIntoApplicationFromFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **_file** | **System.IO.Stream**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

