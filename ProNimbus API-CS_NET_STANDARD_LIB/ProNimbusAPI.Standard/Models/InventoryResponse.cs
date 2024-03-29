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
    public class InventoryResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool? success;
        private List<Models.InventoryItem> items;

        /// <summary>
        /// This field is set to `true` if inventory records were found for **any** of the SKUs.
        /// </summary>
        [JsonProperty("success")]
        public bool? Success 
        { 
            get 
            {
                return this.success; 
            } 
            set 
            {
                this.success = value;
                onPropertyChanged("Success");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("items")]
        public List<Models.InventoryItem> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }
    }
} 