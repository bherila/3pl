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
    public class AcceptedOrder : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string status;
        private string description;
        private string orderNo;

        /// <summary>
        /// The string 'success'
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The string 'SUCCESS'
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Customer order number.
        /// </summary>
        [JsonProperty("orderNo")]
        public string OrderNo 
        { 
            get 
            {
                return this.orderNo; 
            } 
            set 
            {
                this.orderNo = value;
                onPropertyChanged("OrderNo");
            }
        }
    }
} 