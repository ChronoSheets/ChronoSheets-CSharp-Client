/* 
 * ChronoSheets API
 *
 * ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 5 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.
 *
 * OpenAPI spec version: v1
 * Contact: lachlan@chronosheets.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ChronoSheetsAPI.Client;
using ChronoSheetsAPI.ChronoSheetsClientLibModel;

namespace ChronoSheetsAPI.ChronoSheetsClientLibApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsualHoursApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseListUsualHoursDay</returns>
        CSApiResponseListUsualHoursDay UsualHoursGetUsualHours (int? userId, string xChronosheetsAuth);

        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseListUsualHoursDay</returns>
        ApiResponse<CSApiResponseListUsualHoursDay> UsualHoursGetUsualHoursWithHttpInfo (int? userId, string xChronosheetsAuth);
        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseBoolean</returns>
        CSApiResponseBoolean UsualHoursSetUsualHours (CSSetUsualHoursRequest request, string xChronosheetsAuth);

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseBoolean</returns>
        ApiResponse<CSApiResponseBoolean> UsualHoursSetUsualHoursWithHttpInfo (CSSetUsualHoursRequest request, string xChronosheetsAuth);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseListUsualHoursDay</returns>
        System.Threading.Tasks.Task<CSApiResponseListUsualHoursDay> UsualHoursGetUsualHoursAsync (int? userId, string xChronosheetsAuth);

        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseListUsualHoursDay)</returns>
        System.Threading.Tasks.Task<ApiResponse<CSApiResponseListUsualHoursDay>> UsualHoursGetUsualHoursAsyncWithHttpInfo (int? userId, string xChronosheetsAuth);
        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseBoolean</returns>
        System.Threading.Tasks.Task<CSApiResponseBoolean> UsualHoursSetUsualHoursAsync (CSSetUsualHoursRequest request, string xChronosheetsAuth);

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseBoolean)</returns>
        System.Threading.Tasks.Task<ApiResponse<CSApiResponseBoolean>> UsualHoursSetUsualHoursAsyncWithHttpInfo (CSSetUsualHoursRequest request, string xChronosheetsAuth);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsualHoursApi : IUsualHoursApi
    {
        private ChronoSheetsAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsualHoursApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsualHoursApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = ChronoSheetsAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsualHoursApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsualHoursApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
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
        public Configuration Configuration {get; set;}

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
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseListUsualHoursDay</returns>
        public CSApiResponseListUsualHoursDay UsualHoursGetUsualHours (int? userId, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseListUsualHoursDay> localVarResponse = UsualHoursGetUsualHoursWithHttpInfo(userId, xChronosheetsAuth);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseListUsualHoursDay</returns>
        public ApiResponse< CSApiResponseListUsualHoursDay > UsualHoursGetUsualHoursWithHttpInfo (int? userId, string xChronosheetsAuth)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsualHoursApi->UsualHoursGetUsualHours");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling UsualHoursApi->UsualHoursGetUsualHours");

            var localVarPath = "/api/UsualHours/GetUsualHours";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "UserId", userId)); // query parameter
            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsualHoursGetUsualHours", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseListUsualHoursDay>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseListUsualHoursDay) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseListUsualHoursDay)));
        }

        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseListUsualHoursDay</returns>
        public async System.Threading.Tasks.Task<CSApiResponseListUsualHoursDay> UsualHoursGetUsualHoursAsync (int? userId, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseListUsualHoursDay> localVarResponse = await UsualHoursGetUsualHoursAsyncWithHttpInfo(userId, xChronosheetsAuth);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">The ID of the User for which you want to get UsualHours for</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseListUsualHoursDay)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CSApiResponseListUsualHoursDay>> UsualHoursGetUsualHoursAsyncWithHttpInfo (int? userId, string xChronosheetsAuth)
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new ApiException(400, "Missing required parameter 'userId' when calling UsualHoursApi->UsualHoursGetUsualHours");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling UsualHoursApi->UsualHoursGetUsualHours");

            var localVarPath = "/api/UsualHours/GetUsualHours";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (userId != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "UserId", userId)); // query parameter
            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsualHoursGetUsualHours", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseListUsualHoursDay>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseListUsualHoursDay) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseListUsualHoursDay)));
        }

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>CSApiResponseBoolean</returns>
        public CSApiResponseBoolean UsualHoursSetUsualHours (CSSetUsualHoursRequest request, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseBoolean> localVarResponse = UsualHoursSetUsualHoursWithHttpInfo(request, xChronosheetsAuth);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>ApiResponse of CSApiResponseBoolean</returns>
        public ApiResponse< CSApiResponseBoolean > UsualHoursSetUsualHoursWithHttpInfo (CSSetUsualHoursRequest request, string xChronosheetsAuth)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling UsualHoursApi->UsualHoursSetUsualHours");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling UsualHoursApi->UsualHoursSetUsualHours");

            var localVarPath = "/api/UsualHours/SetUsualHours";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsualHoursSetUsualHours", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseBoolean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseBoolean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseBoolean)));
        }

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of CSApiResponseBoolean</returns>
        public async System.Threading.Tasks.Task<CSApiResponseBoolean> UsualHoursSetUsualHoursAsync (CSSetUsualHoursRequest request, string xChronosheetsAuth)
        {
             ApiResponse<CSApiResponseBoolean> localVarResponse = await UsualHoursSetUsualHoursAsyncWithHttpInfo(request, xChronosheetsAuth);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set usual hours (rostered hours) for an employee.  Requires the &#39;ManageOrganisationUsers&#39; or &#39;ManageOrganisationUsers&#39; permissions. 
        /// </summary>
        /// <exception cref="ChronoSheetsAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">A Set UsualHours Request object containing updated data.  Make sure to specify the Day types in the request object so that ChronoSheets knows which Days to update</param>
        /// <param name="xChronosheetsAuth">The ChronoSheets Auth Token</param>
        /// <returns>Task of ApiResponse (CSApiResponseBoolean)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CSApiResponseBoolean>> UsualHoursSetUsualHoursAsyncWithHttpInfo (CSSetUsualHoursRequest request, string xChronosheetsAuth)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling UsualHoursApi->UsualHoursSetUsualHours");
            // verify the required parameter 'xChronosheetsAuth' is set
            if (xChronosheetsAuth == null)
                throw new ApiException(400, "Missing required parameter 'xChronosheetsAuth' when calling UsualHoursApi->UsualHoursSetUsualHours");

            var localVarPath = "/api/UsualHours/SetUsualHours";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (xChronosheetsAuth != null) localVarHeaderParams.Add("x-chronosheets-auth", Configuration.ApiClient.ParameterToString(xChronosheetsAuth)); // header parameter
            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UsualHoursSetUsualHours", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CSApiResponseBoolean>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CSApiResponseBoolean) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CSApiResponseBoolean)));
        }

    }
}
