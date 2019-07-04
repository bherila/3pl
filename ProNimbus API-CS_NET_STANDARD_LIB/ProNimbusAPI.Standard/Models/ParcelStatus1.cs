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
    public class ParcelStatus1 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string carrierTrackingNo;
        private string internalTrackingNo;
        private List<Models.ParcelStatusItem1> updates;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("carrierTrackingNo")]
        public string CarrierTrackingNo 
        { 
            get 
            {
                return this.carrierTrackingNo; 
            } 
            set 
            {
                this.carrierTrackingNo = value;
                onPropertyChanged("CarrierTrackingNo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("internalTrackingNo")]
        public string InternalTrackingNo 
        { 
            get 
            {
                return this.internalTrackingNo; 
            } 
            set 
            {
                this.internalTrackingNo = value;
                onPropertyChanged("InternalTrackingNo");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("updates")]
        public List<Models.ParcelStatusItem1> Updates 
        { 
            get 
            {
                return this.updates; 
            } 
            set 
            {
                this.updates = value;
                onPropertyChanged("Updates");
            }
        }
    }
} 