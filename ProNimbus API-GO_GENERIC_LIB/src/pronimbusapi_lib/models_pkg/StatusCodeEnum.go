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
 * Type definition for StatusCodeEnum enum
 */
type StatusCodeEnum int

/**
 * Value collection for StatusCodeEnum enum
 */
const (
    StatusCode_SUCCESS StatusCodeEnum = 1 + iota
    StatusCode_FAILURE
)

func (r StatusCodeEnum) MarshalJSON() ([]byte, error) { 
    s := StatusCodeEnumToValue(r)
    return json.Marshal(s) 
} 

func (r *StatusCodeEnum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  StatusCodeEnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts StatusCodeEnum to its string representation
 */
func StatusCodeEnumToValue(statusCodeEnum StatusCodeEnum) string {
    switch statusCodeEnum {
        case StatusCode_SUCCESS:
    		return "success"		
        case StatusCode_FAILURE:
    		return "Failure"		
        default:
        	return "success"
    }
}

/**
 * Converts StatusCodeEnum Array to its string Array representation
*/
func StatusCodeEnumArrayToValue(statusCodeEnum []StatusCodeEnum) []string {
    convArray := make([]string,len( statusCodeEnum))
    for i:=0; i<len(statusCodeEnum);i++ {
        convArray[i] = StatusCodeEnumToValue(statusCodeEnum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func StatusCodeEnumFromValue(value string) StatusCodeEnum {
    switch value {
        case "success":
            return StatusCode_SUCCESS
        case "Failure":
            return StatusCode_FAILURE
        default:
            return StatusCode_SUCCESS
    }
}
