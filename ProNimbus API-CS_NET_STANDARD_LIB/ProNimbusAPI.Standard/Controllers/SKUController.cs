/*
 * ProNimbusAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using ProNimbusAPI.Standard;
using ProNimbusAPI.Standard.Utilities;
using ProNimbusAPI.Standard.Http.Request;
using ProNimbusAPI.Standard.Http.Response;
using ProNimbusAPI.Standard.Http.Client;
using ProNimbusAPI.Standard.Exceptions;

namespace ProNimbusAPI.Standard.Controllers
{
    public partial class SKUController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static SKUController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static SKUController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new SKUController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// RESTful web service to fetch information about SKUs.
        /// [Download the YAML for this call](API_productDetails.yaml)
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.ProductDetailsResponse response from the API call</return>
        public Models.ProductDetailsResponse CreateProductDetailsWebService(Models.ProductDetailsRequest request)
        {
            Task<Models.ProductDetailsResponse> t = CreateProductDetailsWebServiceAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// RESTful web service to fetch information about SKUs.
        /// [Download the YAML for this call](API_productDetails.yaml)
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.ProductDetailsResponse response from the API call</return>
        public async Task<Models.ProductDetailsResponse> CreateProductDetailsWebServiceAsync(Models.ProductDetailsRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/call/productDetails");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ProductDetailsErrorResponseException(@"Response on Failure", _context);

            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new Error1Exception(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ProductDetailsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// RESTful web service to create new SKUs.
        /// </summary>
        /// <param name="request">Required parameter: The product you want to add</param>
        /// <return>Returns the Models.ProductCreateResponse response from the API call</return>
        public Models.ProductCreateResponse CreateProductCreateWebService(Models.ProductCreateRequest request)
        {
            Task<Models.ProductCreateResponse> t = CreateProductCreateWebServiceAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// RESTful web service to create new SKUs.
        /// </summary>
        /// <param name="request">Required parameter: The product you want to add</param>
        /// <return>Returns the Models.ProductCreateResponse response from the API call</return>
        public async Task<Models.ProductCreateResponse> CreateProductCreateWebServiceAsync(Models.ProductCreateRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/call/productCreate");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ProductCreateFailureResponseException(@"Response on Failure", _context);

            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new Error1Exception(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ProductCreateResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// RESTful web service to update product information.
        /// [Download the YAML for this call](API_product.yaml)
        /// </summary>
        /// <param name="request">Required parameter: The product you want to update</param>
        /// <return>Returns the Models.ProductUpdateResponseSuccess response from the API call</return>
        public Models.ProductUpdateResponseSuccess UpdateProductUpdate(Models.ProductUpdateRequest request)
        {
            Task<Models.ProductUpdateResponseSuccess> t = UpdateProductUpdateAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// RESTful web service to update product information.
        /// [Download the YAML for this call](API_product.yaml)
        /// </summary>
        /// <param name="request">Required parameter: The product you want to update</param>
        /// <return>Returns the Models.ProductUpdateResponseSuccess response from the API call</return>
        public async Task<Models.ProductUpdateResponseSuccess> UpdateProductUpdateAsync(Models.ProductUpdateRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v2/product");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(request);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PatchBody(_queryUrl, _headers, _body);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);

            //Error handling using HTTP status codes
            if (_response.StatusCode == 400)
                throw new ProductUpdateResponseFailureException(@"Response on Failure", _context);

            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new GenericError2Exception(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.ProductUpdateResponseSuccess>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 