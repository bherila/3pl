/*
 * ProNimbusAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ProNimbusAPI.Standard.Http.Client;

using ProNimbusAPI.Standard.Models;
using ProNimbusAPI.Standard;
using ProNimbusAPI.Standard.Utilities;


namespace ProNimbusAPI.Standard.Exceptions
{
    public class ProductUpdateResponseFailureException : APIException 
    {
        // These fields hold the values for the public properties.
        private Models.Status2Enum? status;
        private Models.Results1 results;
        private List<Models.GenericError> errors;

        /// <summary>
        /// The status of the call.
        /// * `failure` - The system was not able to update the SKU
        /// * `success` - The system updated the SKU successfully
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Status2Enum? Status 
        { 
            get 
            {
                return this.status; 
            } 
            private set 
            {
                this.status = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("results")]
        public Models.Results1 Results 
        { 
            get 
            {
                return this.results; 
            } 
            private set 
            {
                this.results = value;
            }
        }

        /// <summary>
        /// An array of objects describing what input parameters caused errors.
        /// </summary>
        [JsonProperty("errors")]
        public List<Models.GenericError> Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            private set 
            {
                this.errors = value;
            }
        }

        /// <summary>
        /// Initialization constructor
        /// </summary>
        /// <param name="reason"> The reason for throwing exception </param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects </param>
        public ProductUpdateResponseFailureException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 