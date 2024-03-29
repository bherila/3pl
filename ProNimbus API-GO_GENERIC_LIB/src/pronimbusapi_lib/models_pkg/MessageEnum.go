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
 * Type definition for MessageEnum enum
 */
type MessageEnum int

/**
 * Value collection for MessageEnum enum
 */
const (
    Message_SUCCESS MessageEnum = 1 + iota
    Message_FAILURE
)

func (r MessageEnum) MarshalJSON() ([]byte, error) { 
    s := MessageEnumToValue(r)
    return json.Marshal(s) 
} 

func (r *MessageEnum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  MessageEnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts MessageEnum to its string representation
 */
func MessageEnumToValue(messageEnum MessageEnum) string {
    switch messageEnum {
        case Message_SUCCESS:
    		return "success"		
        case Message_FAILURE:
    		return "failure"		
        default:
        	return "success"
    }
}

/**
 * Converts MessageEnum Array to its string Array representation
*/
func MessageEnumArrayToValue(messageEnum []MessageEnum) []string {
    convArray := make([]string,len( messageEnum))
    for i:=0; i<len(messageEnum);i++ {
        convArray[i] = MessageEnumToValue(messageEnum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func MessageEnumFromValue(value string) MessageEnum {
    switch value {
        case "success":
            return Message_SUCCESS
        case "failure":
            return Message_FAILURE
        default:
            return Message_SUCCESS
    }
}
