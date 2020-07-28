# Voicify.Sdk.Cms.Api.OrganizationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrganization**](OrganizationApi.md#createorganization) | **POST** /api/Organization | Creates a new Organization
[**GetDetailedMemberships**](OrganizationApi.md#getdetailedmemberships) | **GET** /api/Organization/{organizationId}/members/detailed | Gets the members of an organization
[**GetForUser**](OrganizationApi.md#getforuser) | **GET** /api/Organization | Gets the organization that the current user is a member of
[**GetMembers**](OrganizationApi.md#getmembers) | **GET** /api/Organization/{organizationId}/members | Gets the members of an organization
[**LeaveOrganization**](OrganizationApi.md#leaveorganization) | **DELETE** /api/Organization/{organizationId}/leave | Leaves the organization and deletes the current user member record
[**RegenerateOrganizationSecret**](OrganizationApi.md#regenerateorganizationsecret) | **PUT** /api/Organization/{organizationId}/regenerateSecrets | Regenerates the given org&#39;s secret used for authentication
[**RemoveMember**](OrganizationApi.md#removemember) | **DELETE** /api/Organization/members/{organizationMemberId}/remove | Removes a member of the organization
[**UpdateDetails**](OrganizationApi.md#updatedetails) | **PUT** /api/Organization/{organizationId} | Updates the organization&#39;s details
[**UpdateMemberRole**](OrganizationApi.md#updatememberrole) | **PUT** /api/Organization/members/{organizationMemberId}/role | Updates the role of a member of an organization


<a name="createorganization"></a>
# **CreateOrganization**
> OrganizationModel CreateOrganization (NewOrganizationRequest model = null)

Creates a new Organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var model = new NewOrganizationRequest(); // NewOrganizationRequest | The details of the organization (optional) 

            try
            {
                // Creates a new Organization
                OrganizationModel result = apiInstance.CreateOrganization(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.CreateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewOrganizationRequest**](NewOrganizationRequest.md)| The details of the organization | [optional] 

### Return type

[**OrganizationModel**](OrganizationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetailedmemberships"></a>
# **GetDetailedMemberships**
> List<MembershipModel> GetDetailedMemberships (string organizationId)

Gets the members of an organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetDetailedMembershipsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationId = organizationId_example;  // string | The id of the organization

            try
            {
                // Gets the members of an organization
                List&lt;MembershipModel&gt; result = apiInstance.GetDetailedMemberships(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetDetailedMemberships: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The id of the organization | 

### Return type

[**List<MembershipModel>**](MembershipModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getforuser"></a>
# **GetForUser**
> List<OrganizationModel> GetForUser ()

Gets the organization that the current user is a member of

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetForUserExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();

            try
            {
                // Gets the organization that the current user is a member of
                List&lt;OrganizationModel&gt; result = apiInstance.GetForUser();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetForUser: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<OrganizationModel>**](OrganizationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmembers"></a>
# **GetMembers**
> List<OrganizationMemberModel> GetMembers (string organizationId)

Gets the members of an organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetMembersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationId = organizationId_example;  // string | The id of the organization

            try
            {
                // Gets the members of an organization
                List&lt;OrganizationMemberModel&gt; result = apiInstance.GetMembers(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| The id of the organization | 

### Return type

[**List<OrganizationMemberModel>**](OrganizationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaveorganization"></a>
# **LeaveOrganization**
> OrganizationMemberModel LeaveOrganization (string organizationId)

Leaves the organization and deletes the current user member record

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class LeaveOrganizationExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Leaves the organization and deletes the current user member record
                OrganizationMemberModel result = apiInstance.LeaveOrganization(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.LeaveOrganization: " + e.Message );
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

[**OrganizationMemberModel**](OrganizationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regenerateorganizationsecret"></a>
# **RegenerateOrganizationSecret**
> OrganizationModel RegenerateOrganizationSecret (string organizationId)

Regenerates the given org's secret used for authentication

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RegenerateOrganizationSecretExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationId = organizationId_example;  // string | 

            try
            {
                // Regenerates the given org's secret used for authentication
                OrganizationModel result = apiInstance.RegenerateOrganizationSecret(organizationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.RegenerateOrganizationSecret: " + e.Message );
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

[**OrganizationModel**](OrganizationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removemember"></a>
# **RemoveMember**
> OrganizationMemberModel RemoveMember (string organizationMemberId)

Removes a member of the organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RemoveMemberExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationMemberId = organizationMemberId_example;  // string | The member id

            try
            {
                // Removes a member of the organization
                OrganizationMemberModel result = apiInstance.RemoveMember(organizationMemberId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.RemoveMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationMemberId** | **string**| The member id | 

### Return type

[**OrganizationMemberModel**](OrganizationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedetails"></a>
# **UpdateDetails**
> OrganizationModel UpdateDetails (string organizationId, UpdateOrganizationRequest model = null)

Updates the organization's details

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateDetailsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationId = organizationId_example;  // string | the id of the organization
            var model = new UpdateOrganizationRequest(); // UpdateOrganizationRequest | The information to update (optional) 

            try
            {
                // Updates the organization's details
                OrganizationModel result = apiInstance.UpdateDetails(organizationId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationId** | **string**| the id of the organization | 
 **model** | [**UpdateOrganizationRequest**](UpdateOrganizationRequest.md)| The information to update | [optional] 

### Return type

[**OrganizationModel**](OrganizationModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatememberrole"></a>
# **UpdateMemberRole**
> OrganizationMemberModel UpdateMemberRole (string organizationMemberId, MemberRoleUpdateRequest model = null)

Updates the role of a member of an organization

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateMemberRoleExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi();
            var organizationMemberId = organizationMemberId_example;  // string | The member id
            var model = new MemberRoleUpdateRequest(); // MemberRoleUpdateRequest | The role information (optional) 

            try
            {
                // Updates the role of a member of an organization
                OrganizationMemberModel result = apiInstance.UpdateMemberRole(organizationMemberId, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateMemberRole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **organizationMemberId** | **string**| The member id | 
 **model** | [**MemberRoleUpdateRequest**](MemberRoleUpdateRequest.md)| The role information | [optional] 

### Return type

[**OrganizationMemberModel**](OrganizationMemberModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

