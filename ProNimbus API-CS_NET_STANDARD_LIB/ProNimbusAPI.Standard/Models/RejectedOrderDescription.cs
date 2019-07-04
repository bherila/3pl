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
using ProNimbusAPI.Standard;
using ProNimbusAPI.Standard.Utilities;


namespace ProNimbusAPI.Standard.Models
{
    public class RejectedOrderDescription : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string dateInvalidDate;
        private string isEmpty;
        private string noRecordFound;
        private string callbackValue;

        /// <summary>
        /// The input does not appear to be a valid date
        /// </summary>
        [JsonProperty("dateInvalidDate")]
        public string DateInvalidDate 
        { 
            get 
            {
                return this.dateInvalidDate; 
            } 
            set 
            {
                this.dateInvalidDate = value;
                onPropertyChanged("DateInvalidDate");
            }
        }

        /// <summary>
        /// Value is required and can't be empty
        /// </summary>
        [JsonProperty("isEmpty")]
        public string IsEmpty 
        { 
            get 
            {
                return this.isEmpty; 
            } 
            set 
            {
                this.isEmpty = value;
                onPropertyChanged("IsEmpty");
            }
        }

        /// <summary>
        /// No corresponsing value was found for this enumerated data type.
        /// </summary>
        [JsonProperty("noRecordFound")]
        public string NoRecordFound 
        { 
            get 
            {
                return this.noRecordFound; 
            } 
            set 
            {
                this.noRecordFound = value;
                onPropertyChanged("NoRecordFound");
            }
        }

        /// <summary>
        /// This is the key for specialized validation for a given field. Please see the value of the string for the description of the validation error.  An example of an error that could appear as a `callbackValue` would be `The 'orderItems' field must be an array of order item records`
        /// </summary>
        [JsonProperty("callbackValue")]
        public string CallbackValue 
        { 
            get 
            {
                return this.callbackValue; 
            } 
            set 
            {
                this.callbackValue = value;
                onPropertyChanged("CallbackValue");
            }
        }
    }
} 