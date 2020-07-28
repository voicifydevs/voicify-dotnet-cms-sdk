/* 
 * Voicify CMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: V1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Voicify.Sdk.Cms.Client;
using Voicify.Sdk.Core.Models.Model;

namespace Voicify.Sdk.Cms.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVoicifyNotificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        List<UserVoicifyNotificationModel> GetUnreadNotifications ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        ApiResponse<List<UserVoicifyNotificationModel>> GetUnreadNotificationsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        List<UserVoicifyNotificationModel> GetUserNotifications ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        ApiResponse<List<UserVoicifyNotificationModel>> GetUserNotificationsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        List<UserVoicifyNotificationModel> MarkAllAsRead ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        ApiResponse<List<UserVoicifyNotificationModel>> MarkAllAsReadWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>UserVoicifyNotificationModel</returns>
        UserVoicifyNotificationModel MarkAsRead (string notificationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of UserVoicifyNotificationModel</returns>
        ApiResponse<UserVoicifyNotificationModel> MarkAsReadWithHttpInfo (string notificationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> GetUnreadNotificationsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> GetUnreadNotificationsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> GetUserNotificationsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> GetUserNotificationsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> MarkAllAsReadAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> MarkAllAsReadAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Task of UserVoicifyNotificationModel</returns>
        System.Threading.Tasks.Task<UserVoicifyNotificationModel> MarkAsReadAsync (string notificationId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Task of ApiResponse (UserVoicifyNotificationModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserVoicifyNotificationModel>> MarkAsReadAsyncWithHttpInfo (string notificationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VoicifyNotificationApi : IVoicifyNotificationApi
    {
        private Voicify.Sdk.Cms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicifyNotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VoicifyNotificationApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Cms.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Cms.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicifyNotificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VoicifyNotificationApi(Voicify.Sdk.Cms.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Voicify.Sdk.Cms.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Voicify.Sdk.Cms.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Voicify.Sdk.Cms.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Voicify.Sdk.Cms.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        public List<UserVoicifyNotificationModel> GetUnreadNotifications ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = GetUnreadNotificationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public ApiResponse< List<UserVoicifyNotificationModel> > GetUnreadNotificationsWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUnreadNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> GetUnreadNotificationsAsync ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = await GetUnreadNotificationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> GetUnreadNotificationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/unread";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUnreadNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        public List<UserVoicifyNotificationModel> GetUserNotifications ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = GetUserNotificationsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public ApiResponse< List<UserVoicifyNotificationModel> > GetUserNotificationsWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/all";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> GetUserNotificationsAsync ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = await GetUserNotificationsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> GetUserNotificationsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/all";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUserNotifications", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;UserVoicifyNotificationModel&gt;</returns>
        public List<UserVoicifyNotificationModel> MarkAllAsRead ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = MarkAllAsReadWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public ApiResponse< List<UserVoicifyNotificationModel> > MarkAllAsReadWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAllAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;UserVoicifyNotificationModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<UserVoicifyNotificationModel>> MarkAllAsReadAsync ()
        {
             ApiResponse<List<UserVoicifyNotificationModel>> localVarResponse = await MarkAllAsReadAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;UserVoicifyNotificationModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<UserVoicifyNotificationModel>>> MarkAllAsReadAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/VoicifyNotification/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAllAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<UserVoicifyNotificationModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<UserVoicifyNotificationModel>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<UserVoicifyNotificationModel>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>UserVoicifyNotificationModel</returns>
        public UserVoicifyNotificationModel MarkAsRead (string notificationId)
        {
             ApiResponse<UserVoicifyNotificationModel> localVarResponse = MarkAsReadWithHttpInfo(notificationId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>ApiResponse of UserVoicifyNotificationModel</returns>
        public ApiResponse< UserVoicifyNotificationModel > MarkAsReadWithHttpInfo (string notificationId)
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling VoicifyNotificationApi->MarkAsRead");

            var localVarPath = "/api/VoicifyNotification/{notificationId}/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVoicifyNotificationModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserVoicifyNotificationModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVoicifyNotificationModel)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Task of UserVoicifyNotificationModel</returns>
        public async System.Threading.Tasks.Task<UserVoicifyNotificationModel> MarkAsReadAsync (string notificationId)
        {
             ApiResponse<UserVoicifyNotificationModel> localVarResponse = await MarkAsReadAsyncWithHttpInfo(notificationId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="notificationId"></param>
        /// <returns>Task of ApiResponse (UserVoicifyNotificationModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserVoicifyNotificationModel>> MarkAsReadAsyncWithHttpInfo (string notificationId)
        {
            // verify the required parameter 'notificationId' is set
            if (notificationId == null)
                throw new ApiException(400, "Missing required parameter 'notificationId' when calling VoicifyNotificationApi->MarkAsRead");

            var localVarPath = "/api/VoicifyNotification/{notificationId}/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (notificationId != null) localVarPathParams.Add("notificationId", this.Configuration.ApiClient.ParameterToString(notificationId)); // path parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsRead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserVoicifyNotificationModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserVoicifyNotificationModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserVoicifyNotificationModel)));
        }

    }
}
