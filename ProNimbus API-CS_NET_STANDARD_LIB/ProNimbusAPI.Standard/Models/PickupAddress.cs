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
    public class PickupAddress : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.AltLocationTypeEnum alternateLocationType;
        private string locationId;
        private string firstName;
        private string lastName;
        private string company;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string postalCode;
        private string country;
        private string phone;

        /// <summary>
        /// HAL for FedEx, ACP for UPS. Denotes type of pickup service.
        /// </summary>
        [JsonProperty("alternateLocationType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.AltLocationTypeEnum AlternateLocationType 
        { 
            get 
            {
                return this.alternateLocationType; 
            } 
            set 
            {
                this.alternateLocationType = value;
                onPropertyChanged("AlternateLocationType");
            }
        }

        /// <summary>
        /// The location ID for a UPS Access Point. Required for ACP deliveries.
        /// </summary>
        [JsonProperty("locationId")]
        public string LocationId 
        { 
            get 
            {
                return this.locationId; 
            } 
            set 
            {
                this.locationId = value;
                onPropertyChanged("LocationId");
            }
        }

        /// <summary>
        /// The first name of the recipient.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// The last name of the recipient.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// The company name of the pickup location.
        /// </summary>
        [JsonProperty("company")]
        public string Company 
        { 
            get 
            {
                return this.company; 
            } 
            set 
            {
                this.company = value;
                onPropertyChanged("Company");
            }
        }

        /// <summary>
        /// The address of the pickup location.
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
        /// The address of the pickup location.
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
        /// The city of the pickup location.
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
        /// The state code of the pickup location.
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
        /// The postal code of the pickup location.
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
        /// The country code of the pickup location.
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

        /// <summary>
        /// A phone number up to 10 numeric digits, other characters will be filtered out. Phone numbers with more than 10 numeric digits will be rejected. For example, the phone number (555) 123-4567 will be accepted in any of the following formats:
        ///   * `(555) 123-4567`
        ///   * `(555)123-4567`
        ///   * `555-123-4567`
        ///   * `5551234567`
        /// </summary>
        [JsonProperty("phone")]
        public string Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }
    }
} 