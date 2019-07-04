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
 * Type definition for Status1Enum enum
 */
type Status1Enum int

/**
 * Value collection for Status1Enum enum
 */
const (
    Status1_SUCCESS Status1Enum = 1 + iota
    Status1_FAILURE
)

func (r Status1Enum) MarshalJSON() ([]byte, error) { 
    s := Status1EnumToValue(r)
    return json.Marshal(s) 
} 

func (r *Status1Enum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  Status1EnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts Status1Enum to its string representation
 */
func Status1EnumToValue(status1Enum Status1Enum) string {
    switch status1Enum {
        case Status1_SUCCESS:
    		return "success"		
        case Status1_FAILURE:
    		return "failure"		
        default:
        	return "success"
    }
}

/**
 * Converts Status1Enum Array to its string Array representation
*/
func Status1EnumArrayToValue(status1Enum []Status1Enum) []string {
    convArray := make([]string,len( status1Enum))
    for i:=0; i<len(status1Enum);i++ {
        convArray[i] = Status1EnumToValue(status1Enum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func Status1EnumFromValue(value string) Status1Enum {
    switch value {
        case "success":
            return Status1_SUCCESS
        case "failure":
            return Status1_FAILURE
        default:
            return Status1_SUCCESS
    }
}