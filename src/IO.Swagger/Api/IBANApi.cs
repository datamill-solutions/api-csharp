/* 
 * /data.mill for applications
 *
 * **&#47;data.mill for applications** is the most versatile and powerful API for all aspects of data quality in your business application.  Use **&#47;data.mill** to check, correct and enrich personal data and business information. The internationally applicable functions can be integrated easily into existing applications, whether desktop, online or mobile and thus enable you to professionally improve your customer or supplier database, directly in your system. Due to **&#47;data.mill**'s pay-per-use credit model there are no setup fees or fixed monthly subscription fees.  **&#47;data.mill** is constantly evolving and upgraded with the latest technology and data services available on the market. 
 *
 * OpenAPI spec version: 1.6.4
 * Contact: info@datamill.solutions
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIBANApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check IBAN for spelling
        /// </summary>
        /// <remarks>
        /// Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>IbanCheckResponse</returns>
        IbanCheckResponse CheckIBAN (string license, string guid, string iban);

        /// <summary>
        /// Check IBAN for spelling
        /// </summary>
        /// <remarks>
        /// Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>ApiResponse of IbanCheckResponse</returns>
        ApiResponse<IbanCheckResponse> CheckIBANWithHttpInfo (string license, string guid, string iban);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Check IBAN for spelling
        /// </summary>
        /// <remarks>
        /// Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>Task of IbanCheckResponse</returns>
        System.Threading.Tasks.Task<IbanCheckResponse> CheckIBANAsync (string license, string guid, string iban);

        /// <summary>
        /// Check IBAN for spelling
        /// </summary>
        /// <remarks>
        /// Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>Task of ApiResponse (IbanCheckResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IbanCheckResponse>> CheckIBANAsyncWithHttpInfo (string license, string guid, string iban);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IBANApi : IIBANApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IBANApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IBANApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IBANApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IBANApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Check IBAN for spelling Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>IbanCheckResponse</returns>
        public IbanCheckResponse CheckIBAN (string license, string guid, string iban)
        {
             ApiResponse<IbanCheckResponse> localVarResponse = CheckIBANWithHttpInfo(license, guid, iban);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check IBAN for spelling Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>ApiResponse of IbanCheckResponse</returns>
        public ApiResponse< IbanCheckResponse > CheckIBANWithHttpInfo (string license, string guid, string iban)
        {
            // verify the required parameter 'license' is set
            if (license == null)
                throw new ApiException(400, "Missing required parameter 'license' when calling IBANApi->CheckIBAN");
            // verify the required parameter 'guid' is set
            if (guid == null)
                throw new ApiException(400, "Missing required parameter 'guid' when calling IBANApi->CheckIBAN");
            // verify the required parameter 'iban' is set
            if (iban == null)
                throw new ApiException(400, "Missing required parameter 'iban' when calling IBANApi->CheckIBAN");

            var localVarPath = "/iban/check";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (license != null) localVarFormParams.Add("license", Configuration.ApiClient.ParameterToString(license)); // form parameter
            if (guid != null) localVarFormParams.Add("guid", Configuration.ApiClient.ParameterToString(guid)); // form parameter
            if (iban != null) localVarFormParams.Add("iban", Configuration.ApiClient.ParameterToString(iban)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CheckIBAN", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IbanCheckResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IbanCheckResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IbanCheckResponse)));
            
        }

        /// <summary>
        /// Check IBAN for spelling Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>Task of IbanCheckResponse</returns>
        public async System.Threading.Tasks.Task<IbanCheckResponse> CheckIBANAsync (string license, string guid, string iban)
        {
             ApiResponse<IbanCheckResponse> localVarResponse = await CheckIBANAsyncWithHttpInfo(license, guid, iban);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check IBAN for spelling Checks the spelling, country code and checksum of an IBAN (International Bank Account Number). The IBAN is an internationally agreed system of identifying bank accounts across national borders. The function does not verify if the IBAN really exists, instead the format is checked for validity only. 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="license">The license key is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="guid">The guid is part of the authentication key pair consisting of license and guid (global unique identifier). These two keys are used as your personal API keys. Note that every API request requires both keys, so you will need to include them in each request. </param>
        /// <param name="iban">IBAN to be checked.</param>
        /// <returns>Task of ApiResponse (IbanCheckResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IbanCheckResponse>> CheckIBANAsyncWithHttpInfo (string license, string guid, string iban)
        {
            // verify the required parameter 'license' is set
            if (license == null)
                throw new ApiException(400, "Missing required parameter 'license' when calling IBANApi->CheckIBAN");
            // verify the required parameter 'guid' is set
            if (guid == null)
                throw new ApiException(400, "Missing required parameter 'guid' when calling IBANApi->CheckIBAN");
            // verify the required parameter 'iban' is set
            if (iban == null)
                throw new ApiException(400, "Missing required parameter 'iban' when calling IBANApi->CheckIBAN");

            var localVarPath = "/iban/check";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (license != null) localVarFormParams.Add("license", Configuration.ApiClient.ParameterToString(license)); // form parameter
            if (guid != null) localVarFormParams.Add("guid", Configuration.ApiClient.ParameterToString(guid)); // form parameter
            if (iban != null) localVarFormParams.Add("iban", Configuration.ApiClient.ParameterToString(iban)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CheckIBAN", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IbanCheckResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IbanCheckResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IbanCheckResponse)));
            
        }

    }
}
