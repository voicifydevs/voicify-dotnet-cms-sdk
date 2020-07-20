# Voicify.Sdk.Cms.Api.MediaItemApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConvertToSsml**](MediaItemApi.md#converttossml) | **POST** /api/MediaItem/convert/ssml/{mediaItemId} | 
[**CreateMediaItem**](MediaItemApi.md#createmediaitem) | **POST** /api/MediaItem/{applicationId}/upload | Uploads the file and saves the media item to the application
[**CreateMediaItem_0**](MediaItemApi.md#createmediaitem_0) | **POST** /api/MediaItem/{applicationId} | 
[**DeleteMediaItem**](MediaItemApi.md#deletemediaitem) | **DELETE** /api/MediaItem/{mediaItemId} | Deletes the given media item
[**DisableMediaItem**](MediaItemApi.md#disablemediaitem) | **DELETE** /api/MediaItem/{mediaItemId}/disable | Deletes the given media item
[**GetDisabledMediaItemsForApplication**](MediaItemApi.md#getdisabledmediaitemsforapplication) | **GET** /api/MediaItem/{applicationId}/disabled | Gets deleted media items for the given application
[**GetMediaItemsForApplication**](MediaItemApi.md#getmediaitemsforapplication) | **GET** /api/MediaItem/{applicationId} | Gets the media items for the given application
[**GetOrganizationUploadUrl**](MediaItemApi.md#getorganizationuploadurl) | **GET** /api/MediaItem/{organizationId}/orgUploadUrl | 
[**GetUploadUrl**](MediaItemApi.md#getuploadurl) | **GET** /api/MediaItem/{applicationId}/uploadUrl | 
[**UpdateMediaItem**](MediaItemApi.md#updatemediaitem) | **PUT** /api/MediaItem/{mediaItemId} | 


<a name="converttossml"></a>
# **ConvertToSsml**
> MediaItemModel ConvertToSsml (string mediaItemId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ConvertToSsmlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                MediaItemModel result = apiInstance.ConvertToSsml(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.ConvertToSsml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmediaitem"></a>
# **CreateMediaItem**
> MediaItemModel CreateMediaItem (string applicationId, string name = null, System.IO.Stream _file = null)

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
    public class CreateMediaItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var _file = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                // Uploads the file and saves the media item to the application
                MediaItemModel result = apiInstance.CreateMediaItem(applicationId, name, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.CreateMediaItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **_file** | **System.IO.Stream**|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createmediaitem_0"></a>
# **CreateMediaItem_0**
> MediaItemModel CreateMediaItem_0 (string applicationId, NewMediaItemRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateMediaItem_0Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var model = new NewMediaItemRequest(); // NewMediaItemRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.CreateMediaItem_0(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.CreateMediaItem_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**NewMediaItemRequest**](NewMediaItemRequest.md)|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemediaitem"></a>
# **DeleteMediaItem**
> MediaItemModel DeleteMediaItem (string mediaItemId)

Deletes the given media item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteMediaItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Deletes the given media item
                MediaItemModel result = apiInstance.DeleteMediaItem(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.DeleteMediaItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablemediaitem"></a>
# **DisableMediaItem**
> MediaItemModel DisableMediaItem (string mediaItemId)

Deletes the given media item

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DisableMediaItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 

            try
            {
                // Deletes the given media item
                MediaItemModel result = apiInstance.DisableMediaItem(mediaItemId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.DisableMediaItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdisabledmediaitemsforapplication"></a>
# **GetDisabledMediaItemsForApplication**
> List<MediaItemModel> GetDisabledMediaItemsForApplication (string applicationId)

Gets deleted media items for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetDisabledMediaItemsForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets deleted media items for the given application
                List&lt;MediaItemModel&gt; result = apiInstance.GetDisabledMediaItemsForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetDisabledMediaItemsForApplication: " + e.Message );
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

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmediaitemsforapplication"></a>
# **GetMediaItemsForApplication**
> List<MediaItemModel> GetMediaItemsForApplication (string applicationId)

Gets the media items for the given application

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMediaItemsForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                // Gets the media items for the given application
                List&lt;MediaItemModel&gt; result = apiInstance.GetMediaItemsForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetMediaItemsForApplication: " + e.Message );
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

[**List<MediaItemModel>**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorganizationuploadurl"></a>
# **GetOrganizationUploadUrl**
> string GetOrganizationUploadUrl (string organizationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetOrganizationUploadUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var organizationId = organizationId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var fileName = fileName_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.GetOrganizationUploadUrl(organizationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetOrganizationUploadUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuploadurl"></a>
# **GetUploadUrl**
> string GetUploadUrl (string applicationId, string name = null, string fileName = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetUploadUrlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var applicationId = applicationId_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var fileName = fileName_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.GetUploadUrl(applicationId, name, fileName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.GetUploadUrl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **name** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemediaitem"></a>
# **UpdateMediaItem**
> MediaItemModel UpdateMediaItem (string mediaItemId, UpdateMediaItemRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMediaItemExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MediaItemApi();
            var mediaItemId = mediaItemId_example;  // string | 
            var request = new UpdateMediaItemRequest(); // UpdateMediaItemRequest |  (optional) 

            try
            {
                MediaItemModel result = apiInstance.UpdateMediaItem(mediaItemId, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MediaItemApi.UpdateMediaItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mediaItemId** | **string**|  | 
 **request** | [**UpdateMediaItemRequest**](UpdateMediaItemRequest.md)|  | [optional] 

### Return type

[**MediaItemModel**](MediaItemModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

