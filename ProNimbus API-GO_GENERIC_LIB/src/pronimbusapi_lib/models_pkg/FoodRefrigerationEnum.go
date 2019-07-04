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
 * Type definition for FoodRefrigerationEnum enum
 */
type FoodRefrigerationEnum int

/**
 * Value collection for FoodRefrigerationEnum enum
 */
const (
    FoodRefrigeration_Y FoodRefrigerationEnum = 1 + iota
    FoodRefrigeration_N
)

func (r FoodRefrigerationEnum) MarshalJSON() ([]byte, error) { 
    s := FoodRefrigerationEnumToValue(r)
    return json.Marshal(s) 
} 

func (r *FoodRefrigerationEnum) UnmarshalJSON(data []byte) error { 
    var s string 
    json.Unmarshal(data, &s)
    v :=  FoodRefrigerationEnumFromValue(s)
    *r = v 
    return nil 
 } 


/**
 * Converts FoodRefrigerationEnum to its string representation
 */
func FoodRefrigerationEnumToValue(foodRefrigerationEnum FoodRefrigerationEnum) string {
    switch foodRefrigerationEnum {
        case FoodRefrigeration_Y:
    		return "Y"		
        case FoodRefrigeration_N:
    		return "N"		
        default:
        	return "Y"
    }
}

/**
 * Converts FoodRefrigerationEnum Array to its string Array representation
*/
func FoodRefrigerationEnumArrayToValue(foodRefrigerationEnum []FoodRefrigerationEnum) []string {
    convArray := make([]string,len( foodRefrigerationEnum))
    for i:=0; i<len(foodRefrigerationEnum);i++ {
        convArray[i] = FoodRefrigerationEnumToValue(foodRefrigerationEnum[i])
    }
    return convArray
}


/**
 * Converts given value to its enum representation
 */
func FoodRefrigerationEnumFromValue(value string) FoodRefrigerationEnum {
    switch value {
        case "Y":
            return FoodRefrigeration_Y
        case "N":
            return FoodRefrigeration_N
        default:
            return FoodRefrigeration_Y
    }
}
