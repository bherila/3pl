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
    public class ShippingAddress : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string firstName;
        private string lastName;
        private string company;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string postalCode;
        private string country;
        private string workPhone;
        private string homePhone;
        private string mobilePhone;
        private string email;
        private string dob;

        /// <summary>
        /// The first name associated with the address.
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
        /// The last name associated with the address.
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
        /// The company name of the address.
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

        /// <summary>
        /// A phone number up to 10 numeric digits, other characters will be filtered out. Phone numbers with more than 10 numeric digits will be rejected. For example, the phone number (555) 123-4567 will be accepted in any of the following formats:
        ///   * `(555) 123-4567`
        ///   * `(555)123-4567`
        ///   * `555-123-4567`
        ///   * `5551234567`
        /// </summary>
        [JsonProperty("workPhone")]
        public string WorkPhone 
        { 
            get 
            {
                return this.workPhone; 
            } 
            set 
            {
                this.workPhone = value;
                onPropertyChanged("WorkPhone");
            }
        }

        /// <summary>
        /// A phone number up to 10 numeric digits, other characters will be filtered out. Phone numbers with more than 10 numeric digits will be rejected. For example, the phone number (555) 123-4567 will be accepted in any of the following formats:
        ///   * `(555) 123-4567`
        ///   * `(555)123-4567`
        ///   * `555-123-4567`
        ///   * `5551234567`
        /// </summary>
        [JsonProperty("homePhone")]
        public string HomePhone 
        { 
            get 
            {
                return this.homePhone; 
            } 
            set 
            {
                this.homePhone = value;
                onPropertyChanged("HomePhone");
            }
        }

        /// <summary>
        /// A phone number up to 10 numeric digits, other characters will be filtered out. Phone numbers with more than 10 numeric digits will be rejected. For example, the phone number (555) 123-4567 will be accepted in any of the following formats:
        ///   * `(555) 123-4567`
        ///   * `(555)123-4567`
        ///   * `555-123-4567`
        ///   * `5551234567`
        /// </summary>
        [JsonProperty("mobilePhone")]
        public string MobilePhone 
        { 
            get 
            {
                return this.mobilePhone; 
            } 
            set 
            {
                this.mobilePhone = value;
                onPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Optional; if excluded, client will not receive email.
        /// </summary>
        [JsonProperty("email")]
        public string Email 
        { 
            get 
            {
                return this.email; 
            } 
            set 
            {
                this.email = value;
                onPropertyChanged("Email");
            }
        }

        /// <summary>
        /// A date string, YYYY-MM-DD. If left blank, defaults to no date.
        /// </summary>
        [JsonProperty("dob")]
        public string Dob 
        { 
            get 
            {
                return this.dob; 
            } 
            set 
            {
                this.dob = value;
                onPropertyChanged("Dob");
            }
        }
    }
} 