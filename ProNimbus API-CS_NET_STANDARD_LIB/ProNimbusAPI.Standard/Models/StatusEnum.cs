/*
 * ProNimbusAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ProNimbusAPI.Standard;
using ProNimbusAPI.Standard.Utilities;

namespace ProNimbusAPI.Standard.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum StatusEnum
    {
        SUCCESS, //TODO: Write general description for this method
        ENUM_PARTIAL, //TODO: Write general description for this method
        FAILURE, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type StatusEnum
    /// </summary>
    public static class StatusEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "success", "partial", "failure" };

        /// <summary>
        /// Converts a StatusEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The StatusEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(StatusEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case StatusEnum.SUCCESS:
                case StatusEnum.ENUM_PARTIAL:
                case StatusEnum.FAILURE:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of StatusEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of StatusEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<StatusEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into StatusEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed StatusEnum value</returns>
        public static StatusEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type StatusEnum", value));

            return (StatusEnum) index;
        }
    }
} 