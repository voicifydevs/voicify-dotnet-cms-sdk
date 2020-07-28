# Voicify.Sdk.Cms.Api.UserApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangePassword**](UserApi.md#changepassword) | **PUT** /api/User/ChangePassword | Changes the current user&#39;s password
[**CreateApiUser**](UserApi.md#createapiuser) | **POST** /api/User/ApiUser | Create an api-only user, mainly for integration use
[**CreateUser**](UserApi.md#createuser) | **POST** /api/User | Creates the user.
[**GetCurrentUserData**](UserApi.md#getcurrentuserdata) | **GET** /api/User/me | Gets the current user&#39;s info
[**GetCurrentUserTermsAgreement**](UserApi.md#getcurrentusertermsagreement) | **GET** /api/User/terms | Gets the current user&#39;s terms agreement info
[**GetSingleSignOnAvailability**](UserApi.md#getsinglesignonavailability) | **GET** /api/User/useSso/{email} | Checks if sso is available for this user&#39;s email.
[**GetSystemUserRoles**](UserApi.md#getsystemuserroles) | **GET** /api/User/SystemRoles | 
[**RequestPasswordReset**](UserApi.md#requestpasswordreset) | **POST** /api/User/ResetPassword | Requests to reset the user&#39;s password
[**SetPassword**](UserApi.md#setpassword) | **PUT** /api/User/SetPassword | Sets the user&#39;s password based on the reset request
[**UpdateDetails**](UserApi.md#updatedetails) | **PUT** /api/User/UpdateDetails | 
[**UpdateProfileImage**](UserApi.md#updateprofileimage) | **POST** /api/User/UpdateImage | 


<a name="changepassword"></a>
# **ChangePassword**
> void ChangePassword (ChangePasswordRequest model = null)

Changes the current user's password

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class ChangePasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var model = new ChangePasswordRequest(); // ChangePasswordRequest |  (optional) 

            try
            {
                // Changes the current user's password
                apiInstance.ChangePassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.ChangePassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ChangePasswordRequest**](ChangePasswordRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapiuser"></a>
# **CreateApiUser**
> ApiUserModel CreateApiUser (NewApiUserRequest model = null)

Create an api-only user, mainly for integration use

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateApiUserExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var model = new NewApiUserRequest(); // NewApiUserRequest |  (optional) 

            try
            {
                // Create an api-only user, mainly for integration use
                ApiUserModel result = apiInstance.CreateApiUser(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateApiUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewApiUserRequest**](NewApiUserRequest.md)|  | [optional] 

### Return type

[**ApiUserModel**](ApiUserModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createuser"></a>
# **CreateUser**
> UserModel CreateUser (NewUserRequest model = null)

Creates the user.

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var model = new NewUserRequest(); // NewUserRequest | Model. (optional) 

            try
            {
                // Creates the user.
                UserModel result = apiInstance.CreateUser(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewUserRequest**](NewUserRequest.md)| Model. | [optional] 

### Return type

[**UserModel**](UserModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentuserdata"></a>
# **GetCurrentUserData**
> UserModel GetCurrentUserData ()

Gets the current user's info

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetCurrentUserDataExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Gets the current user's info
                UserModel result = apiInstance.GetCurrentUserData();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserData: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserModel**](UserModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcurrentusertermsagreement"></a>
# **GetCurrentUserTermsAgreement**
> UserTermAgreementModel GetCurrentUserTermsAgreement ()

Gets the current user's terms agreement info

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetCurrentUserTermsAgreementExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                // Gets the current user's terms agreement info
                UserTermAgreementModel result = apiInstance.GetCurrentUserTermsAgreement();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetCurrentUserTermsAgreement: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserTermAgreementModel**](UserTermAgreementModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsinglesignonavailability"></a>
# **GetSingleSignOnAvailability**
> bool? GetSingleSignOnAvailability (string email)

Checks if sso is available for this user's email.

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSingleSignOnAvailabilityExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var email = email_example;  // string | 

            try
            {
                // Checks if sso is available for this user's email.
                bool? result = apiInstance.GetSingleSignOnAvailability(email);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetSingleSignOnAvailability: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**|  | 

### Return type

**bool?**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemuserroles"></a>
# **GetSystemUserRoles**
> List<UserRoleModel> GetSystemUserRoles ()



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class GetSystemUserRolesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();

            try
            {
                List&lt;UserRoleModel&gt; result = apiInstance.GetSystemUserRoles();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.GetSystemUserRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<UserRoleModel>**](UserRoleModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestpasswordreset"></a>
# **RequestPasswordReset**
> PasswordResetModel RequestPasswordReset (ResetRequest model = null)

Requests to reset the user's password

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class RequestPasswordResetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var model = new ResetRequest(); // ResetRequest |  (optional) 

            try
            {
                // Requests to reset the user's password
                PasswordResetModel result = apiInstance.RequestPasswordReset(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.RequestPasswordReset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ResetRequest**](ResetRequest.md)|  | [optional] 

### Return type

[**PasswordResetModel**](PasswordResetModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpassword"></a>
# **SetPassword**
> void SetPassword (CreateNewPasswordRequest model = null)

Sets the user's password based on the reset request

### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class SetPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var model = new CreateNewPasswordRequest(); // CreateNewPasswordRequest |  (optional) 

            try
            {
                // Sets the user's password based on the reset request
                apiInstance.SetPassword(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.SetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**CreateNewPasswordRequest**](CreateNewPasswordRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedetails"></a>
# **UpdateDetails**
> void UpdateDetails (UpdateUserRequest model = null)



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

            var apiInstance = new UserApi();
            var model = new UpdateUserRequest(); // UpdateUserRequest |  (optional) 

            try
            {
                apiInstance.UpdateDetails(model);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**UpdateUserRequest**](UpdateUserRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateprofileimage"></a>
# **UpdateProfileImage**
> UserModel UpdateProfileImage (System.IO.Stream _file = null)



### Example
```csharp
using System;
using System.Diagnostics;
using Voicify.Sdk.Cms.Api;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Example
{
    public class UpdateProfileImageExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi();
            var _file = new System.IO.Stream(); // System.IO.Stream |  (optional) 

            try
            {
                UserModel result = apiInstance.UpdateProfileImage(_file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserApi.UpdateProfileImage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_file** | **System.IO.Stream**|  | [optional] 

### Return type

[**UserModel**](UserModel.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

