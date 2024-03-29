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
    public partial class NotificationsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static NotificationsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static NotificationsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new NotificationsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// RESTful web service to fetch info about email notificatios sent on behalf of a client. [Download the YAML for this call](API_getNotifications.yaml)
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetNotificationsResponse response from the API call</return>
        public Models.GetNotificationsResponse CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(Models.GetNotificationsRequest request)
        {
            Task<Models.GetNotificationsResponse> t = CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClientAsync(request);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// RESTful web service to fetch info about email notificatios sent on behalf of a client. [Download the YAML for this call](API_getNotifications.yaml)
        /// </summary>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetNotificationsResponse response from the API call</return>
        public async Task<Models.GetNotificationsResponse> CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClientAsync(Models.GetNotificationsRequest request)
        {
            //the base uri for api requests
            string _baseUri = Configuration.GetBaseURI();

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/call/getNotifications");


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
            if ((_response.StatusCode < 200) || (_response.StatusCode > 208)) //[200,208] = HTTP OK
                throw new Error1Exception(@"Unexpected error", _context);

            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<Models.GetNotificationsResponse>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 