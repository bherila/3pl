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
    public enum SlotEquivalentEnum
    {
        ENUM_0ML, //TODO: Write general description for this method
        ENUM_7ML, //TODO: Write general description for this method
        ENUM_50ML, //TODO: Write general description for this method
        ENUM_100ML, //TODO: Write general description for this method
        ENUM_125ML, //TODO: Write general description for this method
        ENUM_147ML, //TODO: Write general description for this method
        ENUM_187ML, //TODO: Write general description for this method
        ENUM_200ML, //TODO: Write general description for this method
        ENUM_250ML, //TODO: Write general description for this method
        ENUM_300ML, //TODO: Write general description for this method
        ENUM_330ML, //TODO: Write general description for this method
        ENUM_333ML, //TODO: Write general description for this method
        ENUM_341ML, //TODO: Write general description for this method
        ENUM_350ML, //TODO: Write general description for this method
        ENUM_355ML, //TODO: Write general description for this method
        ENUM_375ML, //TODO: Write general description for this method
        ENUM_376ML, //TODO: Write general description for this method
        ENUM_500ML, //TODO: Write general description for this method
        ENUM_620ML, //TODO: Write general description for this method
        ENUM_650ML, //TODO: Write general description for this method
        ENUM_680ML, //TODO: Write general description for this method
        ENUM_700ML, //TODO: Write general description for this method
        ENUM_720ML, //TODO: Write general description for this method
        ENUM_750ML, //TODO: Write general description for this method
        ENUM_751ML, //TODO: Write general description for this method
        ENUM_800ML, //TODO: Write general description for this method
        ENUM_1000ML, //TODO: Write general description for this method
        ENUM_1500ML, //TODO: Write general description for this method
        ENUM_1750ML, //TODO: Write general description for this method
        ENUM_1800ML, //TODO: Write general description for this method
        ENUM_1875ML, //TODO: Write general description for this method
        ENUM_2000ML, //TODO: Write general description for this method
        ENUM_3000ML, //TODO: Write general description for this method
        ENUM_4500ML, //TODO: Write general description for this method
        ENUM_5000ML, //TODO: Write general description for this method
        ENUM_6000ML, //TODO: Write general description for this method
        ENUM_9000ML, //TODO: Write general description for this method
        ENUM_10000ML, //TODO: Write general description for this method
        ENUM_12000ML, //TODO: Write general description for this method
        ENUM_15000ML, //TODO: Write general description for this method
        ENUM_18000ML, //TODO: Write general description for this method
        ENUM_19500ML, //TODO: Write general description for this method
        ENUM_20000ML, //TODO: Write general description for this method
        ENUM_27000ML, //TODO: Write general description for this method
        ENUM_50000ML, //TODO: Write general description for this method
        ENUM_56000ML, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type SlotEquivalentEnum
    /// </summary>
    public static class SlotEquivalentEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "0ml", "7ml", "50ml", "100ml", "125ml", "147ml", "187ml", "200ml", "250ml", "300ml", "330ml", "333ml", "341ml", "350ml", "355ml", "375ml", "376ml", "500ml", "620ml", "650ml", "680ml", "700ml", "720ml", "750ml", "751ml", "800ml", "1000ml", "1500ml", "1750ml", "1800ml", "1875ml", "2000ml", "3000ml", "4500ml", "5000ml", "6000ml", "9000ml", "10000ml", "12000ml", "15000ml", "18000ml", "19500ml", "20000ml", "27000ml", "50000ml", "56000ml" };

        /// <summary>
        /// Converts a SlotEquivalentEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The SlotEquivalentEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(SlotEquivalentEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case SlotEquivalentEnum.ENUM_0ML:
                case SlotEquivalentEnum.ENUM_7ML:
                case SlotEquivalentEnum.ENUM_50ML:
                case SlotEquivalentEnum.ENUM_100ML:
                case SlotEquivalentEnum.ENUM_125ML:
                case SlotEquivalentEnum.ENUM_147ML:
                case SlotEquivalentEnum.ENUM_187ML:
                case SlotEquivalentEnum.ENUM_200ML:
                case SlotEquivalentEnum.ENUM_250ML:
                case SlotEquivalentEnum.ENUM_300ML:
                case SlotEquivalentEnum.ENUM_330ML:
                case SlotEquivalentEnum.ENUM_333ML:
                case SlotEquivalentEnum.ENUM_341ML:
                case SlotEquivalentEnum.ENUM_350ML:
                case SlotEquivalentEnum.ENUM_355ML:
                case SlotEquivalentEnum.ENUM_375ML:
                case SlotEquivalentEnum.ENUM_376ML:
                case SlotEquivalentEnum.ENUM_500ML:
                case SlotEquivalentEnum.ENUM_620ML:
                case SlotEquivalentEnum.ENUM_650ML:
                case SlotEquivalentEnum.ENUM_680ML:
                case SlotEquivalentEnum.ENUM_700ML:
                case SlotEquivalentEnum.ENUM_720ML:
                case SlotEquivalentEnum.ENUM_750ML:
                case SlotEquivalentEnum.ENUM_751ML:
                case SlotEquivalentEnum.ENUM_800ML:
                case SlotEquivalentEnum.ENUM_1000ML:
                case SlotEquivalentEnum.ENUM_1500ML:
                case SlotEquivalentEnum.ENUM_1750ML:
                case SlotEquivalentEnum.ENUM_1800ML:
                case SlotEquivalentEnum.ENUM_1875ML:
                case SlotEquivalentEnum.ENUM_2000ML:
                case SlotEquivalentEnum.ENUM_3000ML:
                case SlotEquivalentEnum.ENUM_4500ML:
                case SlotEquivalentEnum.ENUM_5000ML:
                case SlotEquivalentEnum.ENUM_6000ML:
                case SlotEquivalentEnum.ENUM_9000ML:
                case SlotEquivalentEnum.ENUM_10000ML:
                case SlotEquivalentEnum.ENUM_12000ML:
                case SlotEquivalentEnum.ENUM_15000ML:
                case SlotEquivalentEnum.ENUM_18000ML:
                case SlotEquivalentEnum.ENUM_19500ML:
                case SlotEquivalentEnum.ENUM_20000ML:
                case SlotEquivalentEnum.ENUM_27000ML:
                case SlotEquivalentEnum.ENUM_50000ML:
                case SlotEquivalentEnum.ENUM_56000ML:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of SlotEquivalentEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of SlotEquivalentEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<SlotEquivalentEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into SlotEquivalentEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed SlotEquivalentEnum value</returns>
        public static SlotEquivalentEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type SlotEquivalentEnum", value));

            return (SlotEquivalentEnum) index;
        }
    }
} 