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
    public class ProductUpdateRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string clientCode;
        private string productSku;
        private string productName;
        private string shortDescription;
        private string longDescription;
        private string labelDescription;
        private string retailPrice = "0.00";
        private Models.BackorderWarningEnum? backorderWarning = Models.BackorderWarningEnum.N;
        private int? backorderThreshold;
        private int? wineVintage;
        private double? pctAlcohol;
        private string wineVineyard;
        private string wineCOLA;

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
        /// Unique identifier for an item.
        /// </summary>
        [JsonProperty("productSku")]
        public string ProductSku 
        { 
            get 
            {
                return this.productSku; 
            } 
            set 
            {
                this.productSku = value;
                onPropertyChanged("ProductSku");
            }
        }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName 
        { 
            get 
            {
                return this.productName; 
            } 
            set 
            {
                this.productName = value;
                onPropertyChanged("ProductName");
            }
        }

        /// <summary>
        /// Short description of the product.
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription 
        { 
            get 
            {
                return this.shortDescription; 
            } 
            set 
            {
                this.shortDescription = value;
                onPropertyChanged("ShortDescription");
            }
        }

        /// <summary>
        /// Long description of the product.
        /// </summary>
        [JsonProperty("longDescription")]
        public string LongDescription 
        { 
            get 
            {
                return this.longDescription; 
            } 
            set 
            {
                this.longDescription = value;
                onPropertyChanged("LongDescription");
            }
        }

        /// <summary>
        /// Label description for the product
        /// </summary>
        [JsonProperty("labelDescription")]
        public string LabelDescription 
        { 
            get 
            {
                return this.labelDescription; 
            } 
            set 
            {
                this.labelDescription = value;
                onPropertyChanged("LabelDescription");
            }
        }

        /// <summary>
        /// Retail price per item for this SKU.
        /// </summary>
        [JsonProperty("retailPrice")]
        public string RetailPrice 
        { 
            get 
            {
                return this.retailPrice; 
            } 
            set 
            {
                this.retailPrice = value;
                onPropertyChanged("RetailPrice");
            }
        }

        /// <summary>
        /// Turns on and off a warning when inventory for this SKU drops below a specified value.
        /// </summary>
        [JsonProperty("backorderWarning", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.BackorderWarningEnum? BackorderWarning 
        { 
            get 
            {
                return this.backorderWarning; 
            } 
            set 
            {
                this.backorderWarning = value;
                onPropertyChanged("BackorderWarning");
            }
        }

        /// <summary>
        /// An integer value greater than or equal to 0.
        /// </summary>
        [JsonProperty("backorderThreshold")]
        public int? BackorderThreshold 
        { 
            get 
            {
                return this.backorderThreshold; 
            } 
            set 
            {
                this.backorderThreshold = value;
                onPropertyChanged("BackorderThreshold");
            }
        }

        /// <summary>
        /// Defines the wine vintage.
        /// </summary>
        [JsonProperty("wineVintage")]
        public int? WineVintage 
        { 
            get 
            {
                return this.wineVintage; 
            } 
            set 
            {
                this.wineVintage = value;
                onPropertyChanged("WineVintage");
            }
        }

        /// <summary>
        /// Defines the percentage alcohol by volume (ABV).
        /// </summary>
        [JsonProperty("pctAlcohol")]
        public double? PctAlcohol 
        { 
            get 
            {
                return this.pctAlcohol; 
            } 
            set 
            {
                this.pctAlcohol = value;
                onPropertyChanged("PctAlcohol");
            }
        }

        /// <summary>
        /// Defines the vineyard where the wine was produced.
        /// </summary>
        [JsonProperty("wineVineyard")]
        public string WineVineyard 
        { 
            get 
            {
                return this.wineVineyard; 
            } 
            set 
            {
                this.wineVineyard = value;
                onPropertyChanged("WineVineyard");
            }
        }

        /// <summary>
        /// Defines the COLA number, if applicable, for compliance reasons.
        /// </summary>
        [JsonProperty("wineCOLA")]
        public string WineCOLA 
        { 
            get 
            {
                return this.wineCOLA; 
            } 
            set 
            {
                this.wineCOLA = value;
                onPropertyChanged("WineCOLA");
            }
        }
    }
} 