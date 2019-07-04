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
 * Type definition for Units1Enum enum
 */
type Units1Enum int

/**
 * Value collection for Units1Enum enum
 */
const (
    Units1_POUNDS Units1Enum = 1 + iota
)

func (r Units1Enum) MarshalJSON() ([]byte, error) { 
    s := Units1EnumToValue(r)
    return json.Marshal(s) 
} 

func (r *Units1Enum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  Units1EnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts Units1Enum to its string representation
 */
func Units1EnumToValue(units1Enum Units1Enum) string {
    switch units1Enum {
        case Units1_POUNDS:
    		return "pounds"		
        default:
        	return "pounds"
    }
}

/**
 * Converts Units1Enum Array to its string Array representation
*/
func Units1EnumArrayToValue(units1Enum []Units1Enum) []string {
    convArray := make([]string,len( units1Enum))
    for i:=0; i<len(units1Enum);i++ {
        convArray[i] = Units1EnumToValue(units1Enum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func Units1EnumFromValue(value string) Units1Enum {
    switch value {
        case "pounds":
            return Units1_POUNDS
        default:
            return Units1_POUNDS
    }
}