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
    public class ProductDetailsItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string productSku;
        private Models.ProductTypeEnum? productType;
        private string productName;
        private string brandCode;
        private int? vintage;
        private Models.PendingEnum? pending;

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
        /// The product type for this SKU, will determine other key values for the SKU.
        /// </summary>
        [JsonProperty("productType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ProductTypeEnum? ProductType 
        { 
            get 
            {
                return this.productType; 
            } 
            set 
            {
                this.productType = value;
                onPropertyChanged("ProductType");
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
        /// A brand code associated with one of the client's brands
        /// </summary>
        [JsonProperty("brandCode")]
        public string BrandCode 
        { 
            get 
            {
                return this.brandCode; 
            } 
            set 
            {
                this.brandCode = value;
                onPropertyChanged("BrandCode");
            }
        }

        /// <summary>
        /// Defines the wine vintage.
        /// </summary>
        [JsonProperty("vintage")]
        public int? Vintage 
        { 
            get 
            {
                return this.vintage; 
            } 
            set 
            {
                this.vintage = value;
                onPropertyChanged("Vintage");
            }
        }

        /// <summary>
        /// Whether or not the product is in a pending state awaiting approval. Products in a pending state are considered an 'Unknown SKU' if they are used in orders.
        /// </summary>
        [JsonProperty("pending", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.PendingEnum? Pending 
        { 
            get 
            {
                return this.pending; 
            } 
            set 
            {
                this.pending = value;
                onPropertyChanged("Pending");
            }
        }
    }
} 