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
    public enum Units1Enum
    {
        POUNDS, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Units1Enum
    /// </summary>
    public static class Units1EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "pounds" };

        /// <summary>
        /// Converts a Units1Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Units1Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Units1Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Units1Enum.POUNDS:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Units1Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Units1Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Units1Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Units1Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Units1Enum value</returns>
        public static Units1Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Units1Enum", value));

            return (Units1Enum) index;
        }
    }
} 