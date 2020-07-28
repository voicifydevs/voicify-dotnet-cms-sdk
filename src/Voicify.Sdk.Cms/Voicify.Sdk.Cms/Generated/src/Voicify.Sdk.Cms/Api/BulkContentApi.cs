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
    public interface IBulkContentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        string BulkCopyContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BulkCopyContentToApplicationFeatureWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        string BulkMoveContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> BulkMoveContentToApplicationFeatureWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        string DeleteContentInBulk (BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteContentInBulkWithHttpInfo (BulkContentRequest request = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BulkCopyContentToApplicationFeatureAsync (string applicationFeatureId, BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BulkCopyContentToApplicationFeatureAsyncWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> BulkMoveContentToApplicationFeatureAsync (string applicationFeatureId, BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> BulkMoveContentToApplicationFeatureAsyncWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteContentInBulkAsync (BulkContentRequest request = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteContentInBulkAsyncWithHttpInfo (BulkContentRequest request = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BulkContentApi : IBulkContentApi
    {
        private Voicify.Sdk.Cms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkContentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkContentApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Cms.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Cms.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkContentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BulkContentApi(Voicify.Sdk.Cms.Client.Configuration configuration = null)
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
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        public string BulkCopyContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = BulkCopyContentToApplicationFeatureWithHttpInfo(applicationFeatureId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BulkCopyContentToApplicationFeatureWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null)
        {
            // verify the required parameter 'applicationFeatureId' is set
            if (applicationFeatureId == null)
                throw new ApiException(400, "Missing required parameter 'applicationFeatureId' when calling BulkContentApi->BulkCopyContentToApplicationFeature");

            var localVarPath = "/api/BulkContent/CopyToFeature/{applicationFeatureId}";
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

            if (applicationFeatureId != null) localVarPathParams.Add("applicationFeatureId", this.Configuration.ApiClient.ParameterToString(applicationFeatureId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("BulkCopyContentToApplicationFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BulkCopyContentToApplicationFeatureAsync (string applicationFeatureId, BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = await BulkCopyContentToApplicationFeatureAsyncWithHttpInfo(applicationFeatureId, request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BulkCopyContentToApplicationFeatureAsyncWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null)
        {
            // verify the required parameter 'applicationFeatureId' is set
            if (applicationFeatureId == null)
                throw new ApiException(400, "Missing required parameter 'applicationFeatureId' when calling BulkContentApi->BulkCopyContentToApplicationFeature");

            var localVarPath = "/api/BulkContent/CopyToFeature/{applicationFeatureId}";
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

            if (applicationFeatureId != null) localVarPathParams.Add("applicationFeatureId", this.Configuration.ApiClient.ParameterToString(applicationFeatureId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("BulkCopyContentToApplicationFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        public string BulkMoveContentToApplicationFeature (string applicationFeatureId, BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = BulkMoveContentToApplicationFeatureWithHttpInfo(applicationFeatureId, request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > BulkMoveContentToApplicationFeatureWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null)
        {
            // verify the required parameter 'applicationFeatureId' is set
            if (applicationFeatureId == null)
                throw new ApiException(400, "Missing required parameter 'applicationFeatureId' when calling BulkContentApi->BulkMoveContentToApplicationFeature");

            var localVarPath = "/api/BulkContent/MoveToFeature/{applicationFeatureId}";
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

            if (applicationFeatureId != null) localVarPathParams.Add("applicationFeatureId", this.Configuration.ApiClient.ParameterToString(applicationFeatureId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("BulkMoveContentToApplicationFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> BulkMoveContentToApplicationFeatureAsync (string applicationFeatureId, BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = await BulkMoveContentToApplicationFeatureAsyncWithHttpInfo(applicationFeatureId, request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="applicationFeatureId"></param>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> BulkMoveContentToApplicationFeatureAsyncWithHttpInfo (string applicationFeatureId, BulkContentRequest request = null)
        {
            // verify the required parameter 'applicationFeatureId' is set
            if (applicationFeatureId == null)
                throw new ApiException(400, "Missing required parameter 'applicationFeatureId' when calling BulkContentApi->BulkMoveContentToApplicationFeature");

            var localVarPath = "/api/BulkContent/MoveToFeature/{applicationFeatureId}";
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

            if (applicationFeatureId != null) localVarPathParams.Add("applicationFeatureId", this.Configuration.ApiClient.ParameterToString(applicationFeatureId)); // path parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("BulkMoveContentToApplicationFeature", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>string</returns>
        public string DeleteContentInBulk (BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = DeleteContentInBulkWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteContentInBulkWithHttpInfo (BulkContentRequest request = null)
        {

            var localVarPath = "/api/BulkContent/Delete";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("DeleteContentInBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteContentInBulkAsync (BulkContentRequest request = null)
        {
             ApiResponse<string> localVarResponse = await DeleteContentInBulkAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteContentInBulkAsyncWithHttpInfo (BulkContentRequest request = null)
        {

            var localVarPath = "/api/BulkContent/Delete";
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

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

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
                Exception exception = ExceptionFactory("DeleteContentInBulk", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}