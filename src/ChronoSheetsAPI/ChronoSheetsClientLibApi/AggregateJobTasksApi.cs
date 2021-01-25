/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.ChronoSheetsClientLibApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAggregateJobTasksApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponseListAggregateJobCode</returns>
        ApiResponseListAggregateJobCode AggregateJobTasksGetAggregateJobTasks (string xChronosheetsAuth);

        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of ApiResponseListAggregateJobCode</returns>
        ApiResponse<ApiResponseListAggregateJobCode> AggregateJobTasksGetAggregateJobTasksWithHttpInfo (string xChronosheetsAuth);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponseListAggregateJobCode</returns>
        System.Threading.Tasks.Task<ApiResponseListAggregateJobCode> AggregateJobTasksGetAggregateJobTasksAsync (string xChronosheetsAuth, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiResponseListAggregateJobCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponseListAggregateJobCode>> AggregateJobTasksGetAggregateJobTasksWithHttpInfoAsync (string xChronosheetsAuth, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AggregateJobTasksApi : IAggregateJobTasksApi
    {
        private ChronoSheetsAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateJobTasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AggregateJobTasksApi(String basePath)
        {
            this.Configuration = new ChronoSheetsAPI.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateJobTasksApi"/> class
        /// </summary>
        /// <returns></returns>
        public AggregateJobTasksApi()
        {
            this.Configuration = ChronoSheetsAPI.Client.Configuration.Default;

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateJobTasksApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AggregateJobTasksApi(ChronoSheetsAPI.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ChronoSheetsAPI.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
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
        public ChronoSheetsAPI.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChronoSheetsAPI.Client.ExceptionFactory ExceptionFactory
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
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponseListAggregateJobCode</returns>
        public ApiResponseListAggregateJobCode AggregateJobTasksGetAggregateJobTasks (string xChronosheetsAuth)
        {
             ApiResponse<ApiResponseListAggregateJobCode> localVarResponse = AggregateJobTasksGetAggregateJobTasksWithHttpInfo(xChronosheetsAuth);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of ApiResponseListAggregateJobCode</returns>
        public ApiResponse<ApiResponseListAggregateJobCode> AggregateJobTasksGetAggregateJobTasksWithHttpInfo (string xChronosheetsAuth)
        {
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling AggregateJobTasksApi->AggregateJobTasksGetAggregateJobTasks");

            var localVarPath = "/AggregateJobTasks/GetAggregateJobTasks";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", this.Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AggregateJobTasksGetAggregateJobTasks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseListAggregateJobCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiResponseListAggregateJobCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseListAggregateJobCode)));
        }

        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponseListAggregateJobCode</returns>
        public async System.Threading.Tasks.Task<ApiResponseListAggregateJobCode> AggregateJobTasksGetAggregateJobTasksAsync (string xChronosheetsAuth, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ApiResponseListAggregateJobCode> localVarResponse = await AggregateJobTasksGetAggregateJobTasksWithHttpInfoAsync(xChronosheetsAuth, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get jobs and tasks information, aggregated.    Requires the &#39;SubmitTimesheets&#39; or &#39;ManageJobsAndTask&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiResponseListAggregateJobCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponseListAggregateJobCode>> AggregateJobTasksGetAggregateJobTasksWithHttpInfoAsync (string xChronosheetsAuth, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling AggregateJobTasksApi->AggregateJobTasksGetAggregateJobTasks");

            var localVarPath = "/AggregateJobTasks/GetAggregateJobTasks";
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
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", this.Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AggregateJobTasksGetAggregateJobTasks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponseListAggregateJobCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiResponseListAggregateJobCode) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponseListAggregateJobCode)));
        }

    }
}
