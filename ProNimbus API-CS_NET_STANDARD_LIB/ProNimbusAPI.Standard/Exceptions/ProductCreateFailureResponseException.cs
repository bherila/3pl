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
    public class ProductCreateFailureResponseException : APIException 
    {
        // These fields hold the values for the public properties.
        private int? code;
        private Models.MessageEnum? message;
        private object errors;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("code")]
        public int? Code 
        { 
            get 
            {
                return this.code; 
            } 
            private set 
            {
                this.code = value;
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("message", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.MessageEnum? Message 
        { 
            get 
            {
                return this.message; 
            } 
            private set 
            {
                this.message = value;
            }
        }

        /// <summary>
        /// An object describing the fields in the request that are in error. May contain multiple levels if the fields in error are part of a field that is an object. If there is no error this object is empty.
        /// </summary>
        [JsonProperty("errors")]
        public object Errors 
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
        public ProductCreateFailureResponseException(string reason, HttpContext context)
            : base(reason, context)
        {
        }
    }
} 