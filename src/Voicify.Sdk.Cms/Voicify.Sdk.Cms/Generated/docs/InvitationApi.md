# Voicify.Sdk.Cms.Api.InvitationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptInvite**](InvitationApi.md#acceptinvite) | **POST** /api/Invitation/accept/{invitationId} | Accepts the given invitation
[**DeclineInvite**](InvitationApi.md#declineinvite) | **POST** /api/Invitation/decline/{invitationId} | Accepts the given invitation
[**GetInvitations**](InvitationApi.md#getinvitations) | **GET** /api/Invitation | Gets all the user&#39;s pending invitations
[**RevokeInvite**](InvitationApi.md#revokeinvite) | **DELETE** /api/Invitation/{invitationId} | Revokes an invite that was already created
[**SendInvite**](InvitationApi.md#sendinvite) | **POST** /api/Invitation/{organizationId}/withRole | Sends an invitation for the given organization
[**SendInvite_0**](InvitationApi.md#sendinvite_0) | **POST** /api/Invitation/{organizationId} | 


<a name="acceptinvite"></a>
# **AcceptInvite**
> OrganizationMemberModel AcceptInvite (string invitationId)

Accepts the given invitation

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class AcceptInviteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();
            var invitationId = invitationId_example;  // string | 

            try
            {
                // Accepts the given invitation
                OrganizationMemberModel result = apiInstance.AcceptInvite(invitationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.AcceptInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 

### Return type

[**OrganizationMemberModel**](OrganizationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="declineinvite"></a>
# **DeclineInvite**
> InvitationModel DeclineInvite (string invitationId)

Accepts the given invitation

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class DeclineInviteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();
            var invitationId = invitationId_example;  // string | 

            try
            {
                // Accepts the given invitation
                InvitationModel result = apiInstance.DeclineInvite(invitationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.DeclineInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**|  | 

### Return type

[**InvitationModel**](InvitationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitations"></a>
# **GetInvitations**
> List<InvitationModel> GetInvitations ()

Gets all the user's pending invitations

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetInvitationsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();

            try
            {
                // Gets all the user's pending invitations
                List&lt;InvitationModel&gt; result = apiInstance.GetInvitations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.GetInvitations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InvitationModel>**](InvitationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokeinvite"></a>
# **RevokeInvite**
> InvitationModel RevokeInvite (string invitationId)

Revokes an invite that was already created

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RevokeInviteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();
            var invitationId = invitationId_example;  // string | The id of the invitation

            try
            {
                // Revokes an invite that was already created
                InvitationModel result = apiInstance.RevokeInvite(invitationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.RevokeInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationId** | **string**| The id of the invitation | 

### Return type

[**InvitationModel**](InvitationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvite"></a>
# **SendInvite**
> InvitationModel SendInvite (string organizationId, NewInvitationRequest model = null)

Sends an invitation for the given organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SendInviteExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();
            var organizationId = organizationId_example;  // string | 
            var model = new NewInvitationRequest(); // NewInvitationRequest |  (optional) 

            try
            {
                // Sends an invitation for the given organization
                InvitationModel result = apiInstance.SendInvite(organizationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.SendInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **model** | [**NewInvitationRequest**](NewInvitationRequest.md)|  | [optional] 

### Return type

[**InvitationModel**](InvitationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendinvite_0"></a>
# **SendInvite_0**
> InvitationModel SendInvite_0 (string organizationId, BasicInvitationRequest model = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SendInvite_0Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi();
            var organizationId = organizationId_example;  // string | 
            var model = new BasicInvitationRequest(); // BasicInvitationRequest |  (optional) 

            try
            {
                InvitationModel result = apiInstance.SendInvite_0(organizationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InvitationApi.SendInvite_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**|  | 
 **model** | [**BasicInvitationRequest**](BasicInvitationRequest.md)|  | [optional] 

### Return type

[**InvitationModel**](InvitationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

