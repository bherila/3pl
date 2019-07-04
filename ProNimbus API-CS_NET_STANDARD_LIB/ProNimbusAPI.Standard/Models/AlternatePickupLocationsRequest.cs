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
    public class AlternatePickupLocationsRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string clientCode;
        private Models.LocationTypeEnum locationType;
        private int radius;
        private int limit;
        private Models.Location location;

        /// <summary>
        /// Unique client identifier
        /// </summary>
        [JsonProperty("clientCode")]
        public string ClientCode 
        { 
            get 
            {
                return this.clientCode; 
            } 
            set 
            {
                this.clientCode = value;
                onPropertyChanged("ClientCode");
            }
        }

        /// <summary>
        /// Type of alternate pickup location. Valid Values are
        ///   * `HAL` - FedEx® Hold at Location
        ///   * `ACP` - UPS Access Point™
        /// </summary>
        [JsonProperty("locationType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.LocationTypeEnum LocationType 
        { 
            get 
            {
                return this.locationType; 
            } 
            set 
            {
                this.locationType = value;
                onPropertyChanged("LocationType");
            }
        }

        /// <summary>
        /// The distance radius for the alternate location search.
        /// </summary>
        [JsonProperty("radius")]
        public int Radius 
        { 
            get 
            {
                return this.radius; 
            } 
            set 
            {
                this.radius = value;
                onPropertyChanged("Radius");
            }
        }

        /// <summary>
        /// The maximum number of results to return. For ACP locations, the maximum number of results returned by UPS' API appears to be 10.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("location")]
        public Models.Location Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }
    }
} 