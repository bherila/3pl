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
    public class Results5 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int? messageCount;
        private DateTime? endTime;
        private List<Models.Message2> messages;

        /// <summary>
        /// Count of email messages sent
        /// </summary>
        [JsonProperty("messageCount")]
        public int? MessageCount 
        { 
            get 
            {
                return this.messageCount; 
            } 
            set 
            {
                this.messageCount = value;
                onPropertyChanged("MessageCount");
            }
        }

        /// <summary>
        /// TimeStamp of the last message sent during the specified timeframe,
        /// i.e. `2019-06-17 15:57:12`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTime")]
        public DateTime? EndTime 
        { 
            get 
            {
                return this.endTime; 
            } 
            set 
            {
                this.endTime = value;
                onPropertyChanged("EndTime");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("messages")]
        public List<Models.Message2> Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            set 
            {
                this.messages = value;
                onPropertyChanged("Messages");
            }
        }
    }
} 