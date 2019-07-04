/*
 * ProNimbusAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using ProNimbusAPI.Standard;
using ProNimbusAPI.Standard.Utilities;

namespace ProNimbusAPI.Standard.Models
{
    public enum DetailViewEnum
    {
        ENUM_0 = 0, //TODO: Write general description for this method
        ENUM_1 = 1, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type DetailViewEnum
    /// </summary>
    public static class DetailViewEnumHelper
    {
        /// <summary>
        /// Convert a list of DetailViewEnum values to a list of integers
        /// </summary>
        /// <param name="enumValues">The list of DetailViewEnum values to convert</param>
        /// <returns>The list of representative integer values</returns>
        public static List<int> ToValue(List<DetailViewEnum> enumValues)
        {
            if (null == enumValues)
                return null;
            
            return enumValues.Select(eVal => (int)eVal).ToList();
        }
    }
} 