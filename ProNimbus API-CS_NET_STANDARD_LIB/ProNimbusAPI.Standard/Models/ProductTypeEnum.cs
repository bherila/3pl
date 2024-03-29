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
    public enum ProductTypeEnum
    {
        WINE, //TODO: Write general description for this method
        FOOD, //TODO: Write general description for this method
        MERCHANDISE, //TODO: Write general description for this method
        COLLATERAL, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type ProductTypeEnum
    /// </summary>
    public static class ProductTypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "Wine", "Food", "Merchandise", "Collateral" };

        /// <summary>
        /// Converts a ProductTypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The ProductTypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(ProductTypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case ProductTypeEnum.WINE:
                case ProductTypeEnum.FOOD:
                case ProductTypeEnum.MERCHANDISE:
                case ProductTypeEnum.COLLATERAL:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of ProductTypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of ProductTypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<ProductTypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into ProductTypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed ProductTypeEnum value</returns>
        public static ProductTypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type ProductTypeEnum", value));

            return (ProductTypeEnum) index;
        }
    }
} 