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
    public class GetNotificationsResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.Results5> results;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("results")]
        public List<Models.Results5> Results 
        { 
            get 
            {
                return this.results; 
            } 
            set 
            {
                this.results = value;
                onPropertyChanged("Results");
            }
        }
    }
} 