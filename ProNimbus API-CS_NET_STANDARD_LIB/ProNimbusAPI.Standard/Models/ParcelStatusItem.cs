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
    public class ParcelStatusItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string statusCode;
        private string statusMessage;
        private string statusDate;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusCode")]
        public string StatusCode 
        { 
            get 
            {
                return this.statusCode; 
            } 
            set 
            {
                this.statusCode = value;
                onPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("statusMessage")]
        public string StatusMessage 
        { 
            get 
            {
                return this.statusMessage; 
            } 
            set 
            {
                this.statusMessage = value;
                onPropertyChanged("StatusMessage");
            }
        }

        /// <summary>
        /// A date string, YYYY-MM-DD. If left blank, defaults to the current date.
        /// </summary>
        [JsonProperty("statusDate")]
        public string StatusDate 
        { 
            get 
            {
                return this.statusDate; 
            } 
            set 
            {
                this.statusDate = value;
                onPropertyChanged("StatusDate");
            }
        }
    }
} 