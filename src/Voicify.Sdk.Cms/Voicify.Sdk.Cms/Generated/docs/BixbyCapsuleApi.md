# Voicify.Sdk.Cms.Api.BixbyCapsuleApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApplicationBixbyProperties**](BixbyCapsuleApi.md#getapplicationbixbyproperties) | **GET** /api/BixbyCapsule/capsuleProperties/{applicationId} | 
[**GetBaseBixbyCapsuleTemplate**](BixbyCapsuleApi.md#getbasebixbycapsuletemplate) | **GET** /api/BixbyCapsule/baseCapsuleTemplate | 


<a name="getapplicationbixbyproperties"></a>
# **GetApplicationBixbyProperties**
> byte[] GetApplicationBixbyProperties (string applicationId)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetApplicationBixbyPropertiesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyCapsuleApi();
            var applicationId = applicationId_example;  // string | 

            try
            {
                byte[] result = apiInstance.GetApplicationBixbyProperties(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyCapsuleApi.GetApplicationBixbyProperties: " + e.Message );
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

<a name="getbasebixbycapsuletemplate"></a>
# **GetBaseBixbyCapsuleTemplate**
> byte[] GetBaseBixbyCapsuleTemplate ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetBaseBixbyCapsuleTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BixbyCapsuleApi();

            try
            {
                byte[] result = apiInstance.GetBaseBixbyCapsuleTemplate();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BixbyCapsuleApi.GetBaseBixbyCapsuleTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

