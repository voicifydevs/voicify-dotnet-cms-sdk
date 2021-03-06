# Voicify.Sdk.Cms.Api.FollowUpApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateFollowUp**](FollowUpApi.md#createfollowup) | **POST** /api/FollowUp/{applicationId} | 
[**DeleteFollowUp**](FollowUpApi.md#deletefollowup) | **DELETE** /api/FollowUp/{followUpId} | 
[**FindChildContentContainer**](FollowUpApi.md#findchildcontentcontainer) | **GET** /api/FollowUp/find/{followUpId}/children | 
[**FindFollowUp**](FollowUpApi.md#findfollowup) | **GET** /api/FollowUp/find/{followUpId} | 
[**GetForApplication**](FollowUpApi.md#getforapplication) | **GET** /api/FollowUp/{applicationId} | 
[**GetParentContentItems**](FollowUpApi.md#getparentcontentitems) | **GET** /api/FollowUp/parents/{featureTypeId}/{contentId}/content | 
[**GetParentsOfContent**](FollowUpApi.md#getparentsofcontent) | **GET** /api/FollowUp/parents/{featureTypeId}/{contentId} | 
[**UpdateFollowUp**](FollowUpApi.md#updatefollowup) | **PUT** /api/FollowUp | 


<a name="createfollowup"></a>
# **CreateFollowUp**
> FollowUpModel CreateFollowUp (string applicationId, CreateFollowUpRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateFollowUpExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var applicationId = applicationId_example;  // string | 
            var model = new CreateFollowUpRequest(); // CreateFollowUpRequest |  (optional) 

            try
            {
                FollowUpModel result = apiInstance.CreateFollowUp(applicationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.CreateFollowUp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**|  | 
 **model** | [**CreateFollowUpRequest**](CreateFollowUpRequest.md)|  | [optional] 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefollowup"></a>
# **DeleteFollowUp**
> FollowUpModel DeleteFollowUp (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeleteFollowUpExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                FollowUpModel result = apiInstance.DeleteFollowUp(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.DeleteFollowUp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findchildcontentcontainer"></a>
# **FindChildContentContainer**
> ChildContentContainerModel FindChildContentContainer (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindChildContentContainerExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                ChildContentContainerModel result = apiInstance.FindChildContentContainer(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.FindChildContentContainer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**ChildContentContainerModel**](ChildContentContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="findfollowup"></a>
# **FindFollowUp**
> FollowUpModel FindFollowUp (string followUpId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class FindFollowUpExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var followUpId = followUpId_example;  // string | 

            try
            {
                FollowUpModel result = apiInstance.FindFollowUp(followUpId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.FindFollowUp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **followUpId** | **string**|  | 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getforapplication"></a>
# **GetForApplication**
> List<FollowUpModel> GetForApplication (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetForApplicationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                List&lt;FollowUpModel&gt; result = apiInstance.GetForApplication(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.GetForApplication: " + e.Message );
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

[**List<FollowUpModel>**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentcontentitems"></a>
# **GetParentContentItems**
> ParentContentContainerModel GetParentContentItems (string featureTypeId, string contentId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetParentContentItemsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var featureTypeId = featureTypeId_example;  // string | 
            var contentId = contentId_example;  // string | 

            try
            {
                ParentContentContainerModel result = apiInstance.GetParentContentItems(featureTypeId, contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.GetParentContentItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureTypeId** | **string**|  | 
 **contentId** | **string**|  | 

### Return type

[**ParentContentContainerModel**](ParentContentContainerModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getparentsofcontent"></a>
# **GetParentsOfContent**
> List<FollowUpModel> GetParentsOfContent (string featureTypeId, string contentId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetParentsOfContentExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var featureTypeId = featureTypeId_example;  // string | 
            var contentId = contentId_example;  // string | 

            try
            {
                List&lt;FollowUpModel&gt; result = apiInstance.GetParentsOfContent(featureTypeId, contentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.GetParentsOfContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **featureTypeId** | **string**|  | 
 **contentId** | **string**|  | 

### Return type

[**List<FollowUpModel>**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefollowup"></a>
# **UpdateFollowUp**
> FollowUpModel UpdateFollowUp (UpdateFollowUpRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateFollowUpExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FollowUpApi();
            var model = new UpdateFollowUpRequest(); // UpdateFollowUpRequest |  (optional) 

            try
            {
                FollowUpModel result = apiInstance.UpdateFollowUp(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FollowUpApi.UpdateFollowUp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**UpdateFollowUpRequest**](UpdateFollowUpRequest.md)|  | [optional] 

### Return type

[**FollowUpModel**](FollowUpModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

