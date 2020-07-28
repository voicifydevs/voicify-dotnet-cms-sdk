# Voicify.Sdk.Cms.Api.SsmlApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Build**](SsmlApi.md#build) | **POST** /api/Ssml/build | 
[**Parse**](SsmlApi.md#parse) | **POST** /api/Ssml/parse | 
[**Segment**](SsmlApi.md#segment) | **POST** /api/Ssml/segment | 
[**SegmentAndBuild**](SsmlApi.md#segmentandbuild) | **POST** /api/Ssml/segmentAndBuild | 
[**SegmentAndBuild_0**](SsmlApi.md#segmentandbuild_0) | **POST** /api/Ssml/segmentAndBuildMulti | 
[**SsmlToSpeech**](SsmlApi.md#ssmltospeech) | **POST** /api/Ssml/toSpeech/{assistant} | 
[**ValidateAlexaSsml**](SsmlApi.md#validatealexassml) | **POST** /api/Ssml/validate/alexa | 
[**ValidateGoogleSsml**](SsmlApi.md#validategooglessml) | **POST** /api/Ssml/validate/google | 
[**ValidateSsml**](SsmlApi.md#validatessml) | **POST** /api/Ssml/validate | 


<a name="build"></a>
# **Build**
> string Build (SsmlElement element = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class BuildExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var element = new SsmlElement(); // SsmlElement |  (optional) 

            try
            {
                string result = apiInstance.Build(element);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.Build: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **element** | [**SsmlElement**](SsmlElement.md)|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="parse"></a>
# **Parse**
> SsmlElement Parse (SsmlRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ParseExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 

            try
            {
                SsmlElement result = apiInstance.Parse(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.Parse: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 

### Return type

[**SsmlElement**](SsmlElement.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segment"></a>
# **Segment**
> List<SsmlElement> Segment (SsmlRequest request = null, string tag = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SegmentExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 
            var tag = tag_example;  // string |  (optional) 

            try
            {
                List&lt;SsmlElement&gt; result = apiInstance.Segment(request, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.Segment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 
 **tag** | **string**|  | [optional] 

### Return type

[**List<SsmlElement>**](SsmlElement.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segmentandbuild"></a>
# **SegmentAndBuild**
> List<string> SegmentAndBuild (SsmlRequest request = null, string tag = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SegmentAndBuildExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 
            var tag = tag_example;  // string |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.SegmentAndBuild(request, tag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.SegmentAndBuild: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 
 **tag** | **string**|  | [optional] 

### Return type

**List<string>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="segmentandbuild_0"></a>
# **SegmentAndBuild_0**
> List<string> SegmentAndBuild_0 (SsmlRequest request = null, List<string> tags = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SegmentAndBuild_0Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 
            var tags = new List<string>(); // List<string> |  (optional) 

            try
            {
                List&lt;string&gt; result = apiInstance.SegmentAndBuild_0(request, tags);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.SegmentAndBuild_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 
 **tags** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

**List<string>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssmltospeech"></a>
# **SsmlToSpeech**
> List<SpeechOutput> SsmlToSpeech (string assistant, SsmlRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SsmlToSpeechExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var assistant = assistant_example;  // string | 
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 

            try
            {
                List&lt;SpeechOutput&gt; result = apiInstance.SsmlToSpeech(assistant, request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.SsmlToSpeech: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **assistant** | **string**|  | 
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 

### Return type

[**List<SpeechOutput>**](SpeechOutput.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatealexassml"></a>
# **ValidateAlexaSsml**
> bool? ValidateAlexaSsml (SsmlRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ValidateAlexaSsmlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ValidateAlexaSsml(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.ValidateAlexaSsml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validategooglessml"></a>
# **ValidateGoogleSsml**
> bool? ValidateGoogleSsml (SsmlRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ValidateGoogleSsmlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ValidateGoogleSsml(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.ValidateGoogleSsml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatessml"></a>
# **ValidateSsml**
> bool? ValidateSsml (SsmlRequest request = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ValidateSsmlExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SsmlApi();
            var request = new SsmlRequest(); // SsmlRequest |  (optional) 

            try
            {
                bool? result = apiInstance.ValidateSsml(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsmlApi.ValidateSsml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**SsmlRequest**](SsmlRequest.md)|  | [optional] 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

