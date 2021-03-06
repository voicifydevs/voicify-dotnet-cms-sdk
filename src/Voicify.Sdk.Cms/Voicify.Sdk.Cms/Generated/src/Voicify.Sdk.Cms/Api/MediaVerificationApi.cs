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
    public interface IMediaVerificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>MediaContentItems</returns>
        MediaContentItems GetContentItemsForMediaItem (string mediaItemId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>ApiResponse of MediaContentItems</returns>
        ApiResponse<MediaContentItems> GetContentItemsForMediaItemWithHttpInfo (string mediaItemId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>Task of MediaContentItems</returns>
        System.Threading.Tasks.Task<MediaContentItems> GetContentItemsForMediaItemAsync (string mediaItemId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>Task of ApiResponse (MediaContentItems)</returns>
        System.Threading.Tasks.Task<ApiResponse<MediaContentItems>> GetContentItemsForMediaItemAsyncWithHttpInfo (string mediaItemId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MediaVerificationApi : IMediaVerificationApi
    {
        private Voicify.Sdk.Cms.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVerificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MediaVerificationApi(String basePath)
        {
            this.Configuration = new Voicify.Sdk.Cms.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Voicify.Sdk.Cms.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaVerificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MediaVerificationApi(Voicify.Sdk.Cms.Client.Configuration configuration = null)
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
        /// <param name="mediaItemId"></param>
        /// <returns>MediaContentItems</returns>
        public MediaContentItems GetContentItemsForMediaItem (string mediaItemId)
        {
             ApiResponse<MediaContentItems> localVarResponse = GetContentItemsForMediaItemWithHttpInfo(mediaItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>ApiResponse of MediaContentItems</returns>
        public ApiResponse< MediaContentItems > GetContentItemsForMediaItemWithHttpInfo (string mediaItemId)
        {
            // verify the required parameter 'mediaItemId' is set
            if (mediaItemId == null)
                throw new ApiException(400, "Missing required parameter 'mediaItemId' when calling MediaVerificationApi->GetContentItemsForMediaItem");

            var localVarPath = "/api/MediaVerification/contentItems/{mediaItemId}";
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

            if (mediaItemId != null) localVarPathParams.Add("mediaItemId", this.Configuration.ApiClient.ParameterToString(mediaItemId)); // path parameter

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
                Exception exception = ExceptionFactory("GetContentItemsForMediaItem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MediaContentItems>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MediaContentItems) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaContentItems)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>Task of MediaContentItems</returns>
        public async System.Threading.Tasks.Task<MediaContentItems> GetContentItemsForMediaItemAsync (string mediaItemId)
        {
             ApiResponse<MediaContentItems> localVarResponse = await GetContentItemsForMediaItemAsyncWithHttpInfo(mediaItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Voicify.Sdk.Cms.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mediaItemId"></param>
        /// <returns>Task of ApiResponse (MediaContentItems)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MediaContentItems>> GetContentItemsForMediaItemAsyncWithHttpInfo (string mediaItemId)
        {
            // verify the required parameter 'mediaItemId' is set
            if (mediaItemId == null)
                throw new ApiException(400, "Missing required parameter 'mediaItemId' when calling MediaVerificationApi->GetContentItemsForMediaItem");

            var localVarPath = "/api/MediaVerification/contentItems/{mediaItemId}";
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

            if (mediaItemId != null) localVarPathParams.Add("mediaItemId", this.Configuration.ApiClient.ParameterToString(mediaItemId)); // path parameter

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
                Exception exception = ExceptionFactory("GetContentItemsForMediaItem", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MediaContentItems>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MediaContentItems) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MediaContentItems)));
        }

    }
}
