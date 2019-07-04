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
    public class Location : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string postalCode;
        private string country;

        /// <summary>
        /// The required first line of the address.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 
        { 
            get 
            {
                return this.address1; 
            } 
            set 
            {
                this.address1 = value;
                onPropertyChanged("Address1");
            }
        }

        /// <summary>
        /// The optional second line of the address.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 
        { 
            get 
            {
                return this.address2; 
            } 
            set 
            {
                this.address2 = value;
                onPropertyChanged("Address2");
            }
        }

        /// <summary>
        /// The city of the address.
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// The state code of the address.
        /// </summary>
        [JsonProperty("state")]
        public string State 
        { 
            get 
            {
                return this.state; 
            } 
            set 
            {
                this.state = value;
                onPropertyChanged("State");
            }
        }

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// The two-character country code of the address.
        /// </summary>
        [JsonProperty("country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }
    }
} 