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
    public class Food : ProductCreateRequest 
    {
        // These fields hold the values for the public properties.
        private Models.FoodTypeEnum foodType;
        private string foodOrigin;
        private Models.FoodRefrigerationEnum? foodRefrigeration = Models.FoodRefrigerationEnum.N;
        private Models.FoodPerishableEnum? foodPerishable = Models.FoodPerishableEnum.N;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("foodType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.FoodTypeEnum FoodType 
        { 
            get 
            {
                return this.foodType; 
            } 
            set 
            {
                this.foodType = value;
                onPropertyChanged("FoodType");
            }
        }

        /// <summary>
        /// Defines the location where this food originated.
        /// </summary>
        [JsonProperty("foodOrigin")]
        public string FoodOrigin 
        { 
            get 
            {
                return this.foodOrigin; 
            } 
            set 
            {
                this.foodOrigin = value;
                onPropertyChanged("FoodOrigin");
            }
        }

        /// <summary>
        /// Defines whether or not this food requires refrigeration.
        /// </summary>
        [JsonProperty("foodRefrigeration", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.FoodRefrigerationEnum? FoodRefrigeration 
        { 
            get 
            {
                return this.foodRefrigeration; 
            } 
            set 
            {
                this.foodRefrigeration = value;
                onPropertyChanged("FoodRefrigeration");
            }
        }

        /// <summary>
        /// Defines whether or not this food is perishable and expiration dates must be tracked.
        /// </summary>
        [JsonProperty("foodPerishable", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.FoodPerishableEnum? FoodPerishable 
        { 
            get 
            {
                return this.foodPerishable; 
            } 
            set 
            {
                this.foodPerishable = value;
                onPropertyChanged("FoodPerishable");
            }
        }
    }
} 