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
    public enum Type8Enum
    {
        REGULAR, //TODO: Write general description for this method
        RETURN, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type Type8Enum
    /// </summary>
    public static class Type8EnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "REGULAR", "RETURN" };

        /// <summary>
        /// Converts a Type8Enum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The Type8Enum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(Type8Enum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case Type8Enum.REGULAR:
                case Type8Enum.RETURN:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of Type8Enum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of Type8Enum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<Type8Enum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into Type8Enum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed Type8Enum value</returns>
        public static Type8Enum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type Type8Enum", value));

            return (Type8Enum) index;
        }
    }
} 