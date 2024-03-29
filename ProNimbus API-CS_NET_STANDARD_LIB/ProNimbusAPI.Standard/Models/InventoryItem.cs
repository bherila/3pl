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
    public class InventoryItem : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string facility;
        private string sku;
        private object errorMessage;
        private int? quantityOnHand;
        private int? quantityOnHold;
        private int? quantityDamaged;
        private int? quantityMissing;
        private int? quantityInventoryAllocated;
        private int? quantityAvailable;
        private object quantityNotAllocated;
        private object quantityNeeded;
        private object quantityInvalid;
        private object quantityRequested;
        private object quantityAllocated;
        private int? quantityTotal;

        /// <summary>
        /// A code that defines a facility.
        /// </summary>
        [JsonProperty("facility")]
        public string Facility 
        { 
            get 
            {
                return this.facility; 
            } 
            set 
            {
                this.facility = value;
                onPropertyChanged("Facility");
            }
        }

        /// <summary>
        /// Unique identifier for an item.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku 
        { 
            get 
            {
                return this.sku; 
            } 
            set 
            {
                this.sku = value;
                onPropertyChanged("Sku");
            }
        }

        /// <summary>
        /// An object describing the fields in the request that are in error. May contain multiple levels if the fields in error are part of a field that is an object. If there is no error this object is empty.
        /// </summary>
        [JsonProperty("errorMessage")]
        public object ErrorMessage 
        { 
            get 
            {
                return this.errorMessage; 
            } 
            set 
            {
                this.errorMessage = value;
                onPropertyChanged("ErrorMessage");
            }
        }

        /// <summary>
        /// A count of how much of this product is actually in the warehouse.  This count includes
        /// product on hold (`quantityOnHold`), damaged product (`quantityDamaged`), missing
        /// product (`quantityMissing`), product that has been assigned to an order and is
        /// "spoken for" (`quantityInventoryAllocated`), and product that is available to be
        /// allocated to orders (`quantityAvailable`). Synonymous with `quantityTotal`.
        /// </summary>
        [JsonProperty("quantityOnHand")]
        public int? QuantityOnHand 
        { 
            get 
            {
                return this.quantityOnHand; 
            } 
            set 
            {
                this.quantityOnHand = value;
                onPropertyChanged("QuantityOnHand");
            }
        }

        /// <summary>
        /// A count of how much of this product is on hold.
        /// </summary>
        [JsonProperty("quantityOnHold")]
        public int? QuantityOnHold 
        { 
            get 
            {
                return this.quantityOnHold; 
            } 
            set 
            {
                this.quantityOnHold = value;
                onPropertyChanged("QuantityOnHold");
            }
        }

        /// <summary>
        /// A count of how much of this product is damaged.
        /// </summary>
        [JsonProperty("quantityDamaged")]
        public int? QuantityDamaged 
        { 
            get 
            {
                return this.quantityDamaged; 
            } 
            set 
            {
                this.quantityDamaged = value;
                onPropertyChanged("QuantityDamaged");
            }
        }

        /// <summary>
        /// A count of how much of this product is missing
        /// </summary>
        [JsonProperty("quantityMissing")]
        public int? QuantityMissing 
        { 
            get 
            {
                return this.quantityMissing; 
            } 
            set 
            {
                this.quantityMissing = value;
                onPropertyChanged("QuantityMissing");
            }
        }

        /// <summary>
        /// A count of how much of this product has been assigned to an order and is "spoken for".
        /// </summary>
        [JsonProperty("quantityInventoryAllocated")]
        public int? QuantityInventoryAllocated 
        { 
            get 
            {
                return this.quantityInventoryAllocated; 
            } 
            set 
            {
                this.quantityInventoryAllocated = value;
                onPropertyChanged("QuantityInventoryAllocated");
            }
        }

        /// <summary>
        /// A count of how much of this product is in the warehouse and is available to be allocated
        /// to orders.
        /// </summary>
        [JsonProperty("quantityAvailable")]
        public int? QuantityAvailable 
        { 
            get 
            {
                return this.quantityAvailable; 
            } 
            set 
            {
                this.quantityAvailable = value;
                onPropertyChanged("QuantityAvailable");
            }
        }

        /// <summary>
        /// A count of how much of this product has been requested by an order but for some reason
        /// (inventory or exception) cannot yet be promised to that order.
        /// </summary>
        [JsonProperty("quantityNotAllocated")]
        public object QuantityNotAllocated 
        { 
            get 
            {
                return this.quantityNotAllocated; 
            } 
            set 
            {
                this.quantityNotAllocated = value;
                onPropertyChanged("QuantityNotAllocated");
            }
        }

        /// <summary>
        /// A count of how much more of this product beyond `quantityOnHold` is needed to fill all
        /// **VALID** orders requesting this product. Invalid orders are not counted as part of this field.
        /// </summary>
        [JsonProperty("quantityNeeded")]
        public object QuantityNeeded 
        { 
            get 
            {
                return this.quantityNeeded; 
            } 
            set 
            {
                this.quantityNeeded = value;
                onPropertyChanged("QuantityNeeded");
            }
        }

        /// <summary>
        /// A count of how much of this product is requested by orders in an Invalid state.
        /// Orders in an Invalid state must be edited or replaced before they can be processed further.
        /// </summary>
        [JsonProperty("quantityInvalid")]
        public object QuantityInvalid 
        { 
            get 
            {
                return this.quantityInvalid; 
            } 
            set 
            {
                this.quantityInvalid = value;
                onPropertyChanged("QuantityInvalid");
            }
        }

        /// <summary>
        /// A count of how much of this product has been requested by **VALID** orders in ProNimbus.
        /// This count includes both orders that have had product allocated to them
        /// (`quantityInventoryAllocated`) and orders that have not had product allocated to them
        /// (`quantityNotAllocated`). Synonymous with `quantityAllocated`.
        /// </summary>
        [JsonProperty("quantityRequested")]
        public object QuantityRequested 
        { 
            get 
            {
                return this.quantityRequested; 
            } 
            set 
            {
                this.quantityRequested = value;
                onPropertyChanged("QuantityRequested");
            }
        }

        /// <summary>
        /// A count of how much of this product has been requested by **VALID** orders in ProNimbus.
        /// This count includes both orders that have had product allocated to them
        /// (`quantityInventoryAllocated`) and orders that have not had product allocated to them
        /// (`quantityNotAllocated`). Synonymous with `quantityRequested`.
        /// </summary>
        [JsonProperty("quantityAllocated")]
        public object QuantityAllocated 
        { 
            get 
            {
                return this.quantityAllocated; 
            } 
            set 
            {
                this.quantityAllocated = value;
                onPropertyChanged("QuantityAllocated");
            }
        }

        /// <summary>
        /// A count of how much of this product is actually in the warehouse.  This count includes
        /// product on hold (`quantityOnHold`), damaged product (`quantityDamaged`), missing
        /// product (`quantityMissing`), product that has been assigned to an order and is
        /// "spoken for" (`quantityInventoryAllocated`), and product that is available to be
        /// allocated to orders (`quantityAvailable`). Synonymous with `quantityOnHand`.
        /// </summary>
        [JsonProperty("quantityTotal")]
        public int? QuantityTotal 
        { 
            get 
            {
                return this.quantityTotal; 
            } 
            set 
            {
                this.quantityTotal = value;
                onPropertyChanged("QuantityTotal");
            }
        }
    }
} 