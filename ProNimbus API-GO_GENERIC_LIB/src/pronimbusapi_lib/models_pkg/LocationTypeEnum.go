/*
 * pronimbusapi_lib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package models_pkg

import(
    "encoding/json"
)

/**
 * Type definition for LocationTypeEnum enum
 */
type LocationTypeEnum int

/**
 * Value collection for LocationTypeEnum enum
 */
const (
    LocationType_HAL LocationTypeEnum = 1 + iota
    LocationType_ACP
)

func (r LocationTypeEnum) MarshalJSON() ([]byte, error) { 
    s := LocationTypeEnumToValue(r)
    return json.Marshal(s) 
} 

func (r *LocationTypeEnum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  LocationTypeEnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts LocationTypeEnum to its string representation
 */
func LocationTypeEnumToValue(locationTypeEnum LocationTypeEnum) string {
    switch locationTypeEnum {
        case LocationType_HAL:
    		return "HAL"		
        case LocationType_ACP:
    		return "ACP"		
        default:
        	return "HAL"
    }
}

/**
 * Converts LocationTypeEnum Array to its string Array representation
*/
func LocationTypeEnumArrayToValue(locationTypeEnum []LocationTypeEnum) []string {
    convArray := make([]string,len( locationTypeEnum))
    for i:=0; i<len(locationTypeEnum);i++ {
        convArray[i] = LocationTypeEnumToValue(locationTypeEnum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func LocationTypeEnumFromValue(value string) LocationTypeEnum {
    switch value {
        case "HAL":
            return LocationType_HAL
        case "ACP":
            return LocationType_ACP
        default:
            return LocationType_HAL
    }
}