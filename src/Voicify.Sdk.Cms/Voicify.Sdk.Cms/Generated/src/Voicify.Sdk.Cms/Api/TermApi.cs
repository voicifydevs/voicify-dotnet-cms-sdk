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
    public interface ITermApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>UserTermModel</returns>
        UserTermModel AddTermAgreement (NewUserTermRequestModel model = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>ApiResponse of UserTermModel</returns>
        ApiResponse<UserTermModel> AddTermAgreementWithHttpInfo (NewUserTermRequestModel model = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TermModel</returns>
        TermModel GetLatestTerm ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TermModel</returns>
        ApiResponse<TermModel> GetLatestTermWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>Task of UserTermModel</returns>
        System.Threading.Tasks.Task<UserTermModel> AddTermAgreementAsync (NewUserTermRequestModel model = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>Task of ApiResponse (UserTermModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserTermModel>> AddTermAgreementAsyncWithHttpInfo (NewUserTermRequestModel model = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TermModel</returns>
        System.Threading.Tasks.Task<TermModel> GetLatestTermAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TermModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<TermModel>> GetLatestTermAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TermApi : ITermApi
    {
        private Voicify.Sdk.Cms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TermApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TermApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Cms.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Cms.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TermApi(Voicify.Sdk.Cms.Client.Configuration configuration = null)
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
        /// <param name="model"> (optional)</param>
        /// <returns>UserTermModel</returns>
        public UserTermModel AddTermAgreement (NewUserTermRequestModel model = null)
        {
             ApiResponse<UserTermModel> localVarResponse = AddTermAgreementWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>ApiResponse of UserTermModel</returns>
        public ApiResponse< UserTermModel > AddTermAgreementWithHttpInfo (NewUserTermRequestModel model = null)
        {

            var localVarPath = "/api/Term/agreement";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddTermAgreement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserTermModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserTermModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserTermModel)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>Task of UserTermModel</returns>
        public async System.Threading.Tasks.Task<UserTermModel> AddTermAgreementAsync (NewUserTermRequestModel model = null)
        {
             ApiResponse<UserTermModel> localVarResponse = await AddTermAgreementAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"> (optional)</param>
        /// <returns>Task of ApiResponse (UserTermModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserTermModel>> AddTermAgreementAsyncWithHttpInfo (NewUserTermRequestModel model = null)
        {

            var localVarPath = "/api/Term/agreement";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddTermAgreement", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserTermModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserTermModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserTermModel)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TermModel</returns>
        public TermModel GetLatestTerm ()
        {
             ApiResponse<TermModel> localVarResponse = GetLatestTermWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TermModel</returns>
        public ApiResponse< TermModel > GetLatestTermWithHttpInfo ()
        {

            var localVarPath = "/api/Term/latest";
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
                Exception exception = ExceptionFactory("GetLatestTerm", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TermModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TermModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TermModel)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TermModel</returns>
        public async System.Threading.Tasks.Task<TermModel> GetLatestTermAsync ()
        {
             ApiResponse<TermModel> localVarResponse = await GetLatestTermAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TermModel)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TermModel>> GetLatestTermAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/Term/latest";
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
                Exception exception = ExceptionFactory("GetLatestTerm", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TermModel>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TermModel) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(TermModel)));
        }

    }
}
